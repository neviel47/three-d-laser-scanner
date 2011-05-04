using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.VideoSurveillance;
using System.Drawing;
using System.Windows.Forms;
using WebCam_Capture;
using System.Drawing.Imaging;
//---
using AForge.Video;
using AForge.Video.DirectShow;
using NxtNet;
using IKLib;
using System.IO.Ports;
using System.Threading;



namespace _3Dwebcam
{
    public partial class Form1 : Form
    {
        static string logfile = DateTime.Now.ToShortDateString().Replace(@"/", @"-").Replace(@"\", @"-") + ".txt";
        StreamWriter swFromFile = new StreamWriter(logfile);

        //--------------------------------------------------------------------------

        private Nxt _nxt = null;
        private Nxt _nxt2 = null;

        private IK ik = new IK();

        //--------------------------------------------------------------------------
        
        FilterInfoCollection DeviceList;
        AForge.Video.DirectShow.VideoCaptureDevice Device;

        //--------------------------------------------------------------------------

        public Bitmap cimage;

        WebCamCapture cap = new WebCamCapture();

        int w;
        int h;
        float intensity = 200;
        List<List<Point>> ponttomb = new List<List<Point>>();
        Bitmap testbitmap;
                                                      
        //--------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------
        #region Image processing

        public Image<Gray, Byte> FilterImage(Image<Bgr, Byte> img)
        {
            Image<Bgr, Byte> temp = (Image<Bgr, Byte>)img;
            temp._ThresholdBinary(new Bgr(255 ,255 , this.trackBar1.Value), new Bgr(255, 255, 255));
            Image<Gray, Byte> gray_temp = temp.Convert<Gray, Byte>();
            gray_temp._EqualizeHist();


            return gray_temp;
        }

        List<Point> p = new List<Point>();
        Image<Bgr, Byte> img;
        Image<Gray, Byte> g_img;
        Image<Gray, Byte> r_img;
        Image<Gray, Byte> tempimage;

        public float[] distance = new float[240];
        public void ContourCoordinates()
        {

            textBox1.Text = "";

            img = capture.QueryFrame().Convert<Bgr, Byte>();
            g_img = this.FilterImage(img);

            r_img = new Image<Gray, Byte>(new Size(g_img.Width, g_img.Height));
            this.h = g_img.Width;
            this.w = g_img.Height;
            testbitmap = new Bitmap(this.h, this.w);
            //grafika = Graphics.FromImage(testbitmap);
            //Pen pen = new Pen(Color.Blue);
                        
            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
            {
               
                for (Contour<Point> contours = g_img.FindContours(
                    Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_NONE,
                    Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_CCOMP,
                    storage);
                    contours != null;
                    contours = contours.HNext)
                {
                    Contour<Point> contour = contours.ApproxPoly(contours.Perimeter * 0.0000000000005, storage);

                    Point[] pts = contour.ToArray();
                    l_contour.Text = pts.Length.ToString();
                    LineSegment2D[] edges = PointCollection.PolyLine(pts, false);

                    tempimage = new Image<Gray, byte>(r_img.Width, r_img.Height);

                    CvInvoke.cvDrawContours(r_img, contour, new MCvScalar(200), new MCvScalar(0, 200, 0), 5, -1, LINE_TYPE.CV_AA, new Point(0, 0));

                    p.Clear();
                    for (int k = 0; k < pts.Length; k++)
                    {
                        //r_img.Draw(new CircleF(pts[k], 2), new Gray(255), 1);
                        //this.showimg = r_img;
                        //this.Coord2d.Add(pts[k]);

                        p.Add(pts[k]);
                        this.ponttomb.Add(p);
                    }

                    //for (int z = 0; z < distance.Length; z++)
                    //{
                    //    try
                    //    {
                    //        if (pts[z].Y == z)
                    //        {
                    //            distance[z] = (240 - pts[z].X);
                    //        }
                    //    }
                    //    catch (Exception e)
                    //    {
                    //        distance[z] = -1;
                    //    }
                    //}

                    tempimage.DrawPolyline(pts, true, new Gray(200), 1);
                    this.imageBox1.Image = tempimage;
                }

            }

        }

        bool vane;
        int kozep;
        int tavolsag;
        public void ContourCoordinates2()
        {
            vane = false;
            kozep = tresholdImageBox.Image.Bitmap.Width / 2;
            tavolsag = 0;

            for (int y = 0; y < tresholdImageBox.Image.Bitmap.Height; y++)
			{
                vane = false;

                for (int x = 0; x < kozep; x++)
			    {
                    Color c = tresholdImageBox.Image.Bitmap.GetPixel(x, y);

                    if (c.R > 100)
                    {
                        tavolsag = kozep - x;
                        //swFromFile.Write(x.ToString() + ";" + y.ToString() + ";" + tavolsag.ToString());
                        swFromFile.Write(tavolsag.ToString()+",");
                        
                        vane = true;
                        break;
                    }                                        
			    }

                

                if (!vane)
                {
                    tavolsag = 0;
                    //swFromFile.Write("-1;" + y.ToString() + ";" + tavolsag.ToString());
                    swFromFile.Write("-1,");
                    //swFromFile.Write("\r\n");
                }

                
			}

            swFromFile.Write("\r\n");
            
        }
       
        public void StartWebcam()
        {
            chb_webcam.Checked = true;
        }
        public void StopWebcam()
        {
            chb_webcam.Checked = false;
        }


        #endregion
        //--------------------------------------------------------------------------        
        #region Get Set methods
      
        public List<List<Point>> getMatrix()
        {
            return this.ponttomb;
        }
        public void ClearCoordinates()
        {
            this.ponttomb.Clear();
        }
        public int getW()
        {
            return this.w;
        }
        public int getH()
        {
            return this.h;
        }
        #endregion
        //--------------------------------------------------------------------------
        #region Form events

        ImageViewer viewer;
        Capture capture;

        private void Form1_Load(object sender, EventArgs e)
        {            


            // Loading ports for NXT
            combox_port1.DataSource = SerialPort.GetPortNames();
            combox_port2.DataSource = SerialPort.GetPortNames();
            combox_port1.Text = "COM15";
            combox_port2.Text = "COM5";

            // Get video input device list
            GetDevices();

            // Camera
            viewer = new ImageViewer(); //create an image viewer
            capture = new Capture(); //create a camera captue                        
            //capture.FlipVertical = true;

            Application.Idle += new EventHandler(Application_Idle);            
        }

        // Capture WebCam
        void Application_Idle(object sender, EventArgs e)
        {
            viewer.Image = capture.QueryFrame(); //draw the image obtained from camera

            webcamImageBox.Image = viewer.Image;

            Image<Bgr, Byte> tresholdframe = (Emgu.CV.Image<Bgr, Byte>)webcamImageBox.Image.Clone();
            FilterImage(tresholdframe);
            this.tresholdImageBox.Image = tresholdframe;

            //ContourCoordinates();            
        }
        
        // Start / Stop Webcamera 
        private void chb_webcam_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_webcam.Checked)
            {
                Application.Idle += Application_Idle;
            }
            else
            {
                Application.Idle -= Application_Idle;
            }
        }

        void cap_ImageCaptured(object source, WebcamEventArgs e)
        {            
            webcamPictureBox.Image = e.WebCamImage;            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.ContourCoordinates();            
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.intensity = this.trackBar1.Value;
            this.label1.Text = Convert.ToString(this.intensity);
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // laser dispose
            if (Device != null)
            {
                if (Device.IsRunning)
                {
                    try
                    {
                        Device.Stop();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // nxt dispose
            if (_nxt != null)
            {
                if (chb_connect_nxt1.Checked)
                {
                    // disconnect nxt
                    chb_connect_nxt1.Checked = false;
                }

                _nxt.Dispose();
                _nxt = null;
            }
            // //capture dispose

            //if (capture != null)
            //{
            //    capture.Dispose();
            //    capture = null;
            //}

           
        }

        private void chb_laser_CheckedChanged(object sender, EventArgs e)
        {
            if (Device != null)
            {
                switch (Device.IsRunning)
                {
                    case true: { Device.Stop(); } break;
                    case false: { Device.Start(); } break;
                }
            }
            else
            {
                MessageBox.Show("gebasz");
            }
        }

        #endregion                
        //-------------------------------------------------------------------------
        #region Devices

        // Get Devices List
        private void btn_get_devices_Click(object sender, EventArgs e)
        {
            GetDevices();
        }

        private void GetDevices()
        {
            listBox1.Items.Clear();

            DeviceList = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo fi in DeviceList)
            {
                listBox1.Items.Add(fi.Name);

                if (fi.Name.Contains("Trust"))
                {
                    Device = new VideoCaptureDevice(fi.MonikerString);
                }
            }
        }

        #endregion        
        //-------------------------------------------------------------------------
        #region NXT

        // Csatlakozás NXT 1
        private void ConnectNXT1()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Application.DoEvents();

                // _nxt.Connect
                this._nxt = new Nxt();
                this._nxt.Connect(combox_port1.Text);


                combox_port1.Enabled = false;

                btn_status_1.PerformClick();

                ik.SetNxt1(ref _nxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // Csatlakozás NXT 2
        private void ConnectNXT2()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Application.DoEvents();

                // _nxt.Connect
                this._nxt2 = new Nxt();
                this._nxt2.Connect(combox_port2.Text);


                combox_port2.Enabled = false;

                btn_status_2.PerformClick();

                ik.SetNxt2(ref _nxt2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // Kapcsolat bontás NXT 1
        private void DisconnectNXT1()
        {
            Cursor.Current = Cursors.WaitCursor;


            // _nxt.Disconnect
            if (this._nxt != null)
            {
                this._nxt.Disconnect();
                ik.DelNxt1();
            }


            Cursor.Current = Cursors.Default;

            combox_port1.Enabled = true;

            tb_name.Text = "";
            tb_version.Text = "";
            pb_nxt1.Value = 0;
            tb_bluetooth.Text = "";


        }

        // Kapcsolatbontás NXT 2
        private void DisconnectNXT2()
        {
            Cursor.Current = Cursors.WaitCursor;


            // _nxt.Disconnect
            if (this._nxt2 != null)
            {
                this._nxt2.Disconnect();
                ik.DelNxt2();
            }


            Cursor.Current = Cursors.Default;

            combox_port2.Enabled = true;

            tb_name2.Text = "";
            tb_version2.Text = "";
            pb_nxt2.Value = 0;
            tb_bluetooth2.Text = "";

        }        

        // Információk lekérdezése NXT 1
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (_nxt != null)
            {

                // név
                DeviceInfo deviceInfo = this._nxt.GetDeviceInfo();

                // device name
                tb_name.Text = deviceInfo.Name;

                // bluetooth
                tb_bluetooth.Text = deviceInfo.BluetoothAddress.ToHexString();

                // verzió
                tb_version.Text = this._nxt.GetVersion().ToString();

                // töltés
                ushort batteryLevel = this._nxt.GetBatteryLevel();
                pb_nxt1.Value = batteryLevel;

            }
        }

        // Információk lekérdezése NXT 2
        private void btn_status_2_Click(object sender, EventArgs e)
        {

            if (_nxt2 != null)
            {

                // név
                DeviceInfo deviceInfo2 = this._nxt2.GetDeviceInfo();
                tb_name2.Text = deviceInfo2.Name;

                // verzió                
                tb_version2.Text = this._nxt2.GetVersion().ToString();

                // töltés
                ushort batteryLevel2 = this._nxt2.GetBatteryLevel();
                pb_nxt2.Value = batteryLevel2;

                // bluetooth
                tb_bluetooth2.Text = deviceInfo2.BluetoothAddress.ToHexString();

            }
        }

        private void chb_connect_nxt1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                ConnectNXT1();
            }
            else
            {
                DisconnectNXT1();
            }
        }

        private void chb_connect_nxt2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                ConnectNXT2();
            }
            else
            {
                DisconnectNXT2();
            }
        }

        #endregion
        //-------------------------------------------------------------------------
        #region Rotate

        string path = @"D:\Dropbox\polish\splines\v_images\";                

        // Rotate Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            // rotate
            button6.PerformClick();

            // save contours
            //for (int z = 0; z < distance.Length; z++)
            //{
            //    string imagelog = distance[z] + ", ";
            //    swFromFile.Write(Convert.ToString(imagelog));
            //}
            //swFromFile.Write("\r\n");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }

        private int fordul = 0;
        double x = 360 / 100;
        //double forgas = 0.11545;
        double forgas;
        private void button6_Click(object sender, EventArgs e)
        {
            forgas = 0.11545 * x;
            if (chb_using_nxt.Checked)
            {
                ik.DegreeToOutput(forgas, forgas, forgas, forgas);
            }
            fordul++;
            tb_rotate.Text = fordul.ToString();


            StopWebcam();
            //tresholdImageBox.Image.Save(path + "v_image_" + fordul + ".jpg");
            ContourCoordinates2();
            
            StartWebcam();


            //if (fordul == 360)
            if (fordul == 100)
            {
                checkBox1.Checked = false;
            }
        }

        #endregion                        
        //--------------------------------------------------------------------------
    }
}
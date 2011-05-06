namespace _3Dwebcam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webcamImageBox = new Emgu.CV.UI.ImageBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.tresholdImageBox = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_contour = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webcamPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_rotate = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.pb_nxt2 = new System.Windows.Forms.ProgressBar();
            this.pb_nxt1 = new System.Windows.Forms.ProgressBar();
            this.chb_connect_nxt2 = new System.Windows.Forms.CheckBox();
            this.chb_connect_nxt1 = new System.Windows.Forms.CheckBox();
            this.btn_status_2 = new System.Windows.Forms.Button();
            this.btn_status_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_port2 = new System.Windows.Forms.ComboBox();
            this.tb_bluetooth2 = new System.Windows.Forms.TextBox();
            this.tb_name2 = new System.Windows.Forms.TextBox();
            this.combox_port1 = new System.Windows.Forms.ComboBox();
            this.tb_version2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_bluetooth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.btn_get_devices = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chb_using_nxt = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chb_laser = new System.Windows.Forms.CheckBox();
            this.chb_webcam = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chb_webcam_flip = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.webcamImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webcamPictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.gb_info.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // webcamImageBox
            // 
            this.webcamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webcamImageBox.Location = new System.Drawing.Point(6, 19);
            this.webcamImageBox.Name = "webcamImageBox";
            this.webcamImageBox.Size = new System.Drawing.Size(320, 240);
            this.webcamImageBox.TabIndex = 2;
            this.webcamImageBox.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 260);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(320, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Contour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tresholdImageBox
            // 
            this.tresholdImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tresholdImageBox.Location = new System.Drawing.Point(5, 19);
            this.tresholdImageBox.Name = "tresholdImageBox";
            this.tresholdImageBox.Size = new System.Drawing.Size(320, 240);
            this.tresholdImageBox.TabIndex = 13;
            this.tresholdImageBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.webcamImageBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 311);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebCam";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(9, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 1);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(166, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 240);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tresholdImageBox);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(340, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 311);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treshold";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Treshold value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_contour);
            this.groupBox3.Controls.Add(this.imageBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(677, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 311);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contour";
            // 
            // l_contour
            // 
            this.l_contour.Location = new System.Drawing.Point(6, 288);
            this.l_contour.Name = "l_contour";
            this.l_contour.Size = new System.Drawing.Size(320, 17);
            this.l_contour.TabIndex = 24;
            this.l_contour.Text = "Contour value";
            this.l_contour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(6, 19);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(320, 240);
            this.imageBox1.TabIndex = 3;
            this.imageBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webcamPictureBox);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 470);
            this.panel1.TabIndex = 22;
            // 
            // webcamPictureBox
            // 
            this.webcamPictureBox.Location = new System.Drawing.Point(9, 327);
            this.webcamPictureBox.Name = "webcamPictureBox";
            this.webcamPictureBox.Size = new System.Drawing.Size(320, 240);
            this.webcamPictureBox.TabIndex = 21;
            this.webcamPictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 311);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coordinates";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(231, 286);
            this.textBox1.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Rotate";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_rotate
            // 
            this.tb_rotate.Location = new System.Drawing.Point(83, 42);
            this.tb_rotate.Name = "tb_rotate";
            this.tb_rotate.Size = new System.Drawing.Size(61, 20);
            this.tb_rotate.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 20);
            this.button6.TabIndex = 26;
            this.button6.Text = "Rotate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.pb_nxt2);
            this.gb_info.Controls.Add(this.pb_nxt1);
            this.gb_info.Controls.Add(this.chb_connect_nxt2);
            this.gb_info.Controls.Add(this.chb_connect_nxt1);
            this.gb_info.Controls.Add(this.btn_status_2);
            this.gb_info.Controls.Add(this.btn_status_1);
            this.gb_info.Controls.Add(this.label2);
            this.gb_info.Controls.Add(this.combox_port2);
            this.gb_info.Controls.Add(this.tb_bluetooth2);
            this.gb_info.Controls.Add(this.tb_name2);
            this.gb_info.Controls.Add(this.combox_port1);
            this.gb_info.Controls.Add(this.tb_version2);
            this.gb_info.Controls.Add(this.label11);
            this.gb_info.Controls.Add(this.tb_bluetooth);
            this.gb_info.Controls.Add(this.label10);
            this.gb_info.Controls.Add(this.label3);
            this.gb_info.Controls.Add(this.label4);
            this.gb_info.Controls.Add(this.tb_name);
            this.gb_info.Controls.Add(this.tb_version);
            this.gb_info.Location = new System.Drawing.Point(370, 7);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(414, 227);
            this.gb_info.TabIndex = 25;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "NXT Infos";
            // 
            // pb_nxt2
            // 
            this.pb_nxt2.Location = new System.Drawing.Point(247, 134);
            this.pb_nxt2.Maximum = 10000;
            this.pb_nxt2.Name = "pb_nxt2";
            this.pb_nxt2.Size = new System.Drawing.Size(160, 23);
            this.pb_nxt2.TabIndex = 22;
            // 
            // pb_nxt1
            // 
            this.pb_nxt1.Location = new System.Drawing.Point(80, 134);
            this.pb_nxt1.Maximum = 10000;
            this.pb_nxt1.Name = "pb_nxt1";
            this.pb_nxt1.Size = new System.Drawing.Size(161, 23);
            this.pb_nxt1.TabIndex = 21;
            // 
            // chb_connect_nxt2
            // 
            this.chb_connect_nxt2.AutoSize = true;
            this.chb_connect_nxt2.Location = new System.Drawing.Point(270, 28);
            this.chb_connect_nxt2.Name = "chb_connect_nxt2";
            this.chb_connect_nxt2.Size = new System.Drawing.Size(100, 17);
            this.chb_connect_nxt2.TabIndex = 20;
            this.chb_connect_nxt2.Text = "Connect NXT 2";
            this.chb_connect_nxt2.UseVisualStyleBackColor = true;
            this.chb_connect_nxt2.CheckedChanged += new System.EventHandler(this.chb_connect_nxt2_CheckedChanged);
            // 
            // chb_connect_nxt1
            // 
            this.chb_connect_nxt1.AutoSize = true;
            this.chb_connect_nxt1.Location = new System.Drawing.Point(110, 28);
            this.chb_connect_nxt1.Name = "chb_connect_nxt1";
            this.chb_connect_nxt1.Size = new System.Drawing.Size(100, 17);
            this.chb_connect_nxt1.TabIndex = 19;
            this.chb_connect_nxt1.Text = "Connect NXT 1";
            this.chb_connect_nxt1.UseVisualStyleBackColor = true;
            this.chb_connect_nxt1.CheckedChanged += new System.EventHandler(this.chb_connect_nxt1_CheckedChanged);
            // 
            // btn_status_2
            // 
            this.btn_status_2.Location = new System.Drawing.Point(247, 189);
            this.btn_status_2.Name = "btn_status_2";
            this.btn_status_2.Size = new System.Drawing.Size(161, 26);
            this.btn_status_2.TabIndex = 16;
            this.btn_status_2.Text = "Get status";
            this.btn_status_2.UseVisualStyleBackColor = true;
            this.btn_status_2.Click += new System.EventHandler(this.btn_status_2_Click);
            // 
            // btn_status_1
            // 
            this.btn_status_1.Location = new System.Drawing.Point(81, 189);
            this.btn_status_1.Name = "btn_status_1";
            this.btn_status_1.Size = new System.Drawing.Size(160, 26);
            this.btn_status_1.TabIndex = 2;
            this.btn_status_1.Text = "Get status";
            this.btn_status_1.UseVisualStyleBackColor = true;
            this.btn_status_1.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combox_port2
            // 
            this.combox_port2.FormattingEnabled = true;
            this.combox_port2.Location = new System.Drawing.Point(247, 51);
            this.combox_port2.Name = "combox_port2";
            this.combox_port2.Size = new System.Drawing.Size(161, 21);
            this.combox_port2.TabIndex = 4;
            // 
            // tb_bluetooth2
            // 
            this.tb_bluetooth2.Location = new System.Drawing.Point(247, 163);
            this.tb_bluetooth2.Name = "tb_bluetooth2";
            this.tb_bluetooth2.ReadOnly = true;
            this.tb_bluetooth2.Size = new System.Drawing.Size(161, 20);
            this.tb_bluetooth2.TabIndex = 13;
            // 
            // tb_name2
            // 
            this.tb_name2.Location = new System.Drawing.Point(247, 81);
            this.tb_name2.Name = "tb_name2";
            this.tb_name2.ReadOnly = true;
            this.tb_name2.Size = new System.Drawing.Size(161, 20);
            this.tb_name2.TabIndex = 11;
            // 
            // combox_port1
            // 
            this.combox_port1.FormattingEnabled = true;
            this.combox_port1.Location = new System.Drawing.Point(80, 51);
            this.combox_port1.Name = "combox_port1";
            this.combox_port1.Size = new System.Drawing.Size(161, 21);
            this.combox_port1.TabIndex = 1;
            // 
            // tb_version2
            // 
            this.tb_version2.Location = new System.Drawing.Point(247, 107);
            this.tb_version2.Name = "tb_version2";
            this.tb_version2.ReadOnly = true;
            this.tb_version2.Size = new System.Drawing.Size(161, 20);
            this.tb_version2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(13, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bluetooth:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_bluetooth
            // 
            this.tb_bluetooth.Location = new System.Drawing.Point(80, 163);
            this.tb_bluetooth.Name = "tb_bluetooth";
            this.tb_bluetooth.ReadOnly = true;
            this.tb_bluetooth.Size = new System.Drawing.Size(161, 20);
            this.tb_bluetooth.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Battery:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(80, 81);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(161, 20);
            this.tb_name.TabIndex = 1;
            // 
            // tb_version
            // 
            this.tb_version.Location = new System.Drawing.Point(80, 107);
            this.tb_version.Name = "tb_version";
            this.tb_version.ReadOnly = true;
            this.tb_version.Size = new System.Drawing.Size(161, 20);
            this.tb_version.TabIndex = 0;
            // 
            // btn_get_devices
            // 
            this.btn_get_devices.Location = new System.Drawing.Point(6, 22);
            this.btn_get_devices.Name = "btn_get_devices";
            this.btn_get_devices.Size = new System.Drawing.Size(143, 23);
            this.btn_get_devices.TabIndex = 24;
            this.btn_get_devices.Text = "Get devices";
            this.btn_get_devices.UseVisualStyleBackColor = true;
            this.btn_get_devices.Click += new System.EventHandler(this.btn_get_devices_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 173);
            this.listBox1.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 502);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Webcam";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coordinates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.gb_info);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1035, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Devices";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.btn_get_devices);
            this.groupBox5.Location = new System.Drawing.Point(8, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(356, 227);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DeviceList";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.chb_using_nxt);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.tb_rotate);
            this.groupBox6.Location = new System.Drawing.Point(164, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(154, 71);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rotate";
            // 
            // chb_using_nxt
            // 
            this.chb_using_nxt.AutoSize = true;
            this.chb_using_nxt.Location = new System.Drawing.Point(19, 19);
            this.chb_using_nxt.Name = "chb_using_nxt";
            this.chb_using_nxt.Size = new System.Drawing.Size(125, 17);
            this.chb_using_nxt.TabIndex = 2;
            this.chb_using_nxt.Text = "NXT Rotate On / Off";
            this.chb_using_nxt.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox8);
            this.panel4.Controls.Add(this.groupBox7);
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 98);
            this.panel4.TabIndex = 23;
            // 
            // chb_laser
            // 
            this.chb_laser.AutoSize = true;
            this.chb_laser.Location = new System.Drawing.Point(16, 19);
            this.chb_laser.Name = "chb_laser";
            this.chb_laser.Size = new System.Drawing.Size(94, 17);
            this.chb_laser.TabIndex = 1;
            this.chb_laser.Text = "Laser On / Off";
            this.chb_laser.UseVisualStyleBackColor = true;
            this.chb_laser.CheckedChanged += new System.EventHandler(this.chb_laser_CheckedChanged);
            // 
            // chb_webcam
            // 
            this.chb_webcam.AutoSize = true;
            this.chb_webcam.Checked = true;
            this.chb_webcam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_webcam.Location = new System.Drawing.Point(18, 19);
            this.chb_webcam.Name = "chb_webcam";
            this.chb_webcam.Size = new System.Drawing.Size(112, 17);
            this.chb_webcam.TabIndex = 0;
            this.chb_webcam.Text = "WebCam On / Off";
            this.chb_webcam.UseVisualStyleBackColor = true;
            this.chb_webcam.CheckedChanged += new System.EventHandler(this.chb_webcam_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chb_webcam_flip);
            this.groupBox7.Controls.Add(this.chb_webcam);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(146, 71);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Webcam";
            // 
            // chb_webcam_flip
            // 
            this.chb_webcam_flip.AutoSize = true;
            this.chb_webcam_flip.Location = new System.Drawing.Point(18, 42);
            this.chb_webcam_flip.Name = "chb_webcam_flip";
            this.chb_webcam_flip.Size = new System.Drawing.Size(80, 17);
            this.chb_webcam_flip.TabIndex = 1;
            this.chb_webcam_flip.Text = "Flip Vertical";
            this.chb_webcam_flip.UseVisualStyleBackColor = true;
            this.chb_webcam_flip.CheckedChanged += new System.EventHandler(this.chb_webcam_flip_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chb_laser);
            this.groupBox8.Location = new System.Drawing.Point(324, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(124, 71);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Laser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Laser Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webcamImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webcamPictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox webcamImageBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox tresholdImageBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox webcamPictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_get_devices;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_rotate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.ProgressBar pb_nxt2;
        private System.Windows.Forms.ProgressBar pb_nxt1;
        private System.Windows.Forms.CheckBox chb_connect_nxt2;
        private System.Windows.Forms.CheckBox chb_connect_nxt1;
        private System.Windows.Forms.Button btn_status_2;
        private System.Windows.Forms.Button btn_status_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combox_port2;
        private System.Windows.Forms.TextBox tb_bluetooth2;
        private System.Windows.Forms.TextBox tb_name2;
        private System.Windows.Forms.ComboBox combox_port1;
        private System.Windows.Forms.TextBox tb_version2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_bluetooth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chb_laser;
        private System.Windows.Forms.CheckBox chb_webcam;
        private System.Windows.Forms.CheckBox chb_using_nxt;
        private System.Windows.Forms.Label l_contour;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chb_webcam_flip;
    }
}


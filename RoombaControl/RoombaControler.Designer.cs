namespace RoombaControl
{
    partial class RoombaControler
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_open = new System.Windows.Forms.Button();
            this.select_port = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_keycontrol = new System.Windows.Forms.Label();
            this.button_power = new System.Windows.Forms.Button();
            this.button_full = new System.Windows.Forms.Button();
            this.button_safe = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_drive = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.checkBox_sidebrush = new System.Windows.Forms.CheckBox();
            this.checkBox_vaccum = new System.Windows.Forms.CheckBox();
            this.checkBox_mainbrush = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_radius = new System.Windows.Forms.Label();
            this.trackbar_radius = new System.Windows.Forms.TrackBar();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_front = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackbar_speed = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.songTestButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_speed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(256, 15);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // select_port
            // 
            this.select_port.FormattingEnabled = true;
            this.select_port.Location = new System.Drawing.Point(47, 17);
            this.select_port.Name = "select_port";
            this.select_port.Size = new System.Drawing.Size(75, 20);
            this.select_port.TabIndex = 2;
            this.select_port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_baud);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.select_port);
            this.groupBox2.Controls.Add(this.button_open);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baud.Location = new System.Drawing.Point(128, 17);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(121, 20);
            this.comboBox_baud.TabIndex = 5;
            this.comboBox_baud.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_keycontrol);
            this.groupBox3.Controls.Add(this.button_power);
            this.groupBox3.Controls.Add(this.button_full);
            this.groupBox3.Controls.Add(this.button_safe);
            this.groupBox3.Controls.Add(this.button_start);
            this.groupBox3.Controls.Add(this.button_drive);
            this.groupBox3.Controls.Add(this.button_clean);
            this.groupBox3.Controls.Add(this.checkBox_sidebrush);
            this.groupBox3.Controls.Add(this.checkBox_vaccum);
            this.groupBox3.Controls.Add(this.checkBox_mainbrush);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label_radius);
            this.groupBox3.Controls.Add(this.trackbar_radius);
            this.groupBox3.Controls.Add(this.button_stop);
            this.groupBox3.Controls.Add(this.button_right);
            this.groupBox3.Controls.Add(this.button_left);
            this.groupBox3.Controls.Add(this.button_back);
            this.groupBox3.Controls.Add(this.button_front);
            this.groupBox3.Controls.Add(this.label_speed);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trackbar_speed);
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 428);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label_keycontrol
            // 
            this.label_keycontrol.BackColor = System.Drawing.SystemColors.Info;
            this.label_keycontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_keycontrol.Location = new System.Drawing.Point(141, 261);
            this.label_keycontrol.Name = "label_keycontrol";
            this.label_keycontrol.Size = new System.Drawing.Size(123, 23);
            this.label_keycontrol.TabIndex = 30;
            this.label_keycontrol.Text = "Key Control";
            this.label_keycontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_keycontrol.Click += new System.EventHandler(this.label_keycontrol_Click);
            this.label_keycontrol.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label_keycontrol_PreviewKeyDown);
            // 
            // button_power
            // 
            this.button_power.Location = new System.Drawing.Point(294, 19);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(85, 23);
            this.button_power.TabIndex = 29;
            this.button_power.Text = "Power";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // button_full
            // 
            this.button_full.Location = new System.Drawing.Point(198, 19);
            this.button_full.Name = "button_full";
            this.button_full.Size = new System.Drawing.Size(90, 23);
            this.button_full.TabIndex = 28;
            this.button_full.Text = "Full";
            this.button_full.UseVisualStyleBackColor = true;
            this.button_full.Click += new System.EventHandler(this.button_full_Click);
            // 
            // button_safe
            // 
            this.button_safe.Location = new System.Drawing.Point(102, 18);
            this.button_safe.Name = "button_safe";
            this.button_safe.Size = new System.Drawing.Size(90, 23);
            this.button_safe.TabIndex = 27;
            this.button_safe.Text = "Safe";
            this.button_safe.UseVisualStyleBackColor = true;
            this.button_safe.Click += new System.EventHandler(this.button_safe_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(6, 18);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(90, 23);
            this.button_start.TabIndex = 26;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_drive
            // 
            this.button_drive.Location = new System.Drawing.Point(102, 47);
            this.button_drive.Name = "button_drive";
            this.button_drive.Size = new System.Drawing.Size(90, 23);
            this.button_drive.TabIndex = 25;
            this.button_drive.Text = "Drive";
            this.button_drive.UseVisualStyleBackColor = true;
            this.button_drive.Click += new System.EventHandler(this.button_drive_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(6, 46);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(90, 23);
            this.button_clean.TabIndex = 24;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // checkBox_sidebrush
            // 
            this.checkBox_sidebrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_sidebrush.Location = new System.Drawing.Point(198, 74);
            this.checkBox_sidebrush.Name = "checkBox_sidebrush";
            this.checkBox_sidebrush.Size = new System.Drawing.Size(90, 24);
            this.checkBox_sidebrush.TabIndex = 19;
            this.checkBox_sidebrush.Text = "Side Brush";
            this.checkBox_sidebrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_sidebrush.UseVisualStyleBackColor = true;
            this.checkBox_sidebrush.CheckedChanged += new System.EventHandler(this.checkBox_sidebrush_CheckedChanged);
            // 
            // checkBox_vaccum
            // 
            this.checkBox_vaccum.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_vaccum.Location = new System.Drawing.Point(102, 75);
            this.checkBox_vaccum.Name = "checkBox_vaccum";
            this.checkBox_vaccum.Size = new System.Drawing.Size(90, 24);
            this.checkBox_vaccum.TabIndex = 18;
            this.checkBox_vaccum.Text = "Vacuum";
            this.checkBox_vaccum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_vaccum.UseVisualStyleBackColor = true;
            this.checkBox_vaccum.CheckedChanged += new System.EventHandler(this.checkBox_vaccum_CheckedChanged);
            // 
            // checkBox_mainbrush
            // 
            this.checkBox_mainbrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_mainbrush.Location = new System.Drawing.Point(6, 75);
            this.checkBox_mainbrush.Name = "checkBox_mainbrush";
            this.checkBox_mainbrush.Size = new System.Drawing.Size(90, 24);
            this.checkBox_mainbrush.TabIndex = 17;
            this.checkBox_mainbrush.Text = "Main Brush";
            this.checkBox_mainbrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_mainbrush.UseVisualStyleBackColor = true;
            this.checkBox_mainbrush.CheckedChanged += new System.EventHandler(this.checkBox_mainbrush_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Radius";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Location = new System.Drawing.Point(343, 390);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(11, 12);
            this.label_radius.TabIndex = 11;
            this.label_radius.Text = "0";
            this.label_radius.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackbar_radius
            // 
            this.trackbar_radius.Location = new System.Drawing.Point(56, 360);
            this.trackbar_radius.Maximum = 2000;
            this.trackbar_radius.Name = "trackbar_radius";
            this.trackbar_radius.Size = new System.Drawing.Size(299, 45);
            this.trackbar_radius.TabIndex = 15;
            this.trackbar_radius.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(141, 188);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(123, 26);
            this.button_stop.TabIndex = 14;
            this.button_stop.Text = "Stop (Space)";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(270, 188);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(109, 26);
            this.button_right.TabIndex = 14;
            this.button_right.Text = "Turn Right(→)";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(18, 188);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(117, 26);
            this.button_left.TabIndex = 14;
            this.button_left.Text = "Turn Left(←)";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(141, 220);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(123, 26);
            this.button_back.TabIndex = 14;
            this.button_back.Text = "Back(↓)";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_front
            // 
            this.button_front.Location = new System.Drawing.Point(141, 156);
            this.button_front.Name = "button_front";
            this.button_front.Size = new System.Drawing.Size(123, 26);
            this.button_front.TabIndex = 14;
            this.button_front.Text = "Front(↑) ";
            this.button_front.UseVisualStyleBackColor = true;
            this.button_front.Click += new System.EventHandler(this.button_front_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(343, 342);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(11, 12);
            this.label_speed.TabIndex = 11;
            this.label_speed.Text = "0";
            this.label_speed.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Speed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackbar_speed
            // 
            this.trackbar_speed.Location = new System.Drawing.Point(56, 309);
            this.trackbar_speed.Maximum = 500;
            this.trackbar_speed.Name = "trackbar_speed";
            this.trackbar_speed.Size = new System.Drawing.Size(299, 45);
            this.trackbar_speed.TabIndex = 9;
            this.trackbar_speed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Location = new System.Drawing.Point(16, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 44);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(479, 13);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(77, 23);
            this.button_send.TabIndex = 7;
            this.button_send.Text = "Send (todo)";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 15);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(52, 19);
            this.textBox10.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(238, 15);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(52, 19);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(64, 15);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(52, 19);
            this.textBox9.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(180, 15);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(52, 19);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(122, 15);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(52, 19);
            this.textBox8.TabIndex = 4;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM8";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.playButton);
            this.groupBox5.Controls.Add(this.songTestButton);
            this.groupBox5.Location = new System.Drawing.Point(409, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 476);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Song";
            // 
            // songTestButton
            // 
            this.songTestButton.Location = new System.Drawing.Point(7, 12);
            this.songTestButton.Name = "songTestButton";
            this.songTestButton.Size = new System.Drawing.Size(151, 23);
            this.songTestButton.TabIndex = 0;
            this.songTestButton.Text = "Family Mart";
            this.songTestButton.UseVisualStyleBackColor = true;
            this.songTestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 19);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(412, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 19);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(7, 430);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(151, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "かえるのうた1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "かえるのうた2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(584, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 532);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox_received);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(6, 6);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.ReadOnly = true;
            this.richTextBox_received.Size = new System.Drawing.Size(334, 494);
            this.richTextBox_received.TabIndex = 0;
            this.richTextBox_received.Text = "";
            this.richTextBox_received.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(7, 7);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(333, 493);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "接続→start→safe or full で動作開始\r\n\r\n動作しない場合は本体のSPOTとDOCKを10秒以上同時押しして離すとリセットされる\r\n\r\n車輪が動" +
    "かない場合はスピードが0になっていないか確認する\r\n\r\nsafeモード中に車輪を浮かす等するとpassiveモードに移行する．再動作させたい場合はもう一度モード" +
    "切替すること";
            this.textBox4.UseWaitCursor = true;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // RoombaControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoombaControler";
            this.Text = "RoombaControler";
            this.Load += new System.EventHandler(this.RoombaControler_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_speed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ComboBox select_port;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackbar_speed;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_front;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackbar_radius;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_sidebrush;
        private System.Windows.Forms.CheckBox checkBox_vaccum;
        private System.Windows.Forms.CheckBox checkBox_mainbrush;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Button button_drive;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button_full;
        private System.Windows.Forms.Button button_safe;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_keycontrol;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button songTestButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private System.Windows.Forms.TextBox textBox4;
    }
}


﻿namespace WindowsFormsApplication1.Exam
{
    partial class JiaoYan
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.uiLedLabel4 = new Sunny.UI.UILedLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new Sunny.UI.UILedLabel();
            this.label4 = new Sunny.UI.UILedLabel();
            this.label10 = new Sunny.UI.UILedLabel();
            this.uiLight6 = new Sunny.UI.UILight();
            this.uiLight5 = new Sunny.UI.UILight();
            this.label34 = new System.Windows.Forms.Label();
            this.uiLight4 = new Sunny.UI.UILight();
            this.uiLight3 = new Sunny.UI.UILight();
            this.uiLight2 = new Sunny.UI.UILight();
            this.uiLight1 = new Sunny.UI.UILight();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(381, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 56);
            this.button2.TabIndex = 40;
            this.button2.Text = "结束校验";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(381, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 56);
            this.button1.TabIndex = 39;
            this.button1.Text = "测试开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(381, 186);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 56);
            this.button3.TabIndex = 38;
            this.button3.Text = "开始校验";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 64);
            this.label2.TabIndex = 37;
            this.label2.Text = "安全阀模拟考试系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "点击连接";
            this.toolStripStatusLabel1.Visible = false;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(419, 569);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 74);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(811, 569);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(200, 74);
            this.richTextBox2.TabIndex = 45;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged_2);
            // 
            // uiLedLabel4
            // 
            this.uiLedLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLedLabel4.BackColor = System.Drawing.Color.Black;
            this.uiLedLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLedLabel4.ForeColor = System.Drawing.Color.Lime;
            this.uiLedLabel4.IntervalOn = 3;
            this.uiLedLabel4.Location = new System.Drawing.Point(38, 76);
            this.uiLedLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.uiLedLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel4.Name = "uiLedLabel4";
            this.uiLedLabel4.Size = new System.Drawing.Size(319, 28);
            this.uiLedLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel4.StyleCustomMode = true;
            this.uiLedLabel4.TabIndex = 99;
            this.uiLedLabel4.Text = "1111111";
            this.uiLedLabel4.Visible = false;
            this.uiLedLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiLedLabel4.Click += new System.EventHandler(this.uiLedLabel4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(0, 655);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 100;
            this.label1.Text = "压力选择范围";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(0, 643);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 101;
            this.label3.Text = "当前压力：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(11, 567);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(239, 74);
            this.richTextBox3.TabIndex = 102;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(741, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 104;
            this.label5.Text = "考试总计时：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(741, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "单元倒计时：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 631);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 106;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(38, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 108;
            this.label8.Text = "离线校验实景";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(51, 354);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(75, 28);
            this.uiButton1.TabIndex = 109;
            this.uiButton1.Text = "拍照";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Visible = false;
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(701, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "保压倒计时3Min：";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.IntervalOn = 3;
            this.lbltime.Location = new System.Drawing.Point(884, 188);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2);
            this.lbltime.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(116, 42);
            this.lbltime.Style = Sunny.UI.UIStyle.Custom;
            this.lbltime.StyleCustomMode = true;
            this.lbltime.TabIndex = 114;
            this.lbltime.Text = "--:--";
            this.lbltime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.IntervalOn = 3;
            this.label4.Location = new System.Drawing.Point(886, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.MinimumSize = new System.Drawing.Size(1, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 40);
            this.label4.Style = Sunny.UI.UIStyle.Custom;
            this.label4.StyleCustomMode = true;
            this.label4.TabIndex = 115;
            this.label4.Text = "--:--";
            this.label4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.IntervalOn = 3;
            this.label10.Location = new System.Drawing.Point(886, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(2);
            this.label10.MinimumSize = new System.Drawing.Size(1, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 42);
            this.label10.Style = Sunny.UI.UIStyle.Custom;
            this.label10.StyleCustomMode = true;
            this.label10.TabIndex = 116;
            this.label10.Text = "--:--";
            this.label10.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight6
            // 
            this.uiLight6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight6.Location = new System.Drawing.Point(306, 37);
            this.uiLight6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight6.Name = "uiLight6";
            this.uiLight6.Radius = 35;
            this.uiLight6.Size = new System.Drawing.Size(35, 35);
            this.uiLight6.TabIndex = 143;
            this.uiLight6.Text = "uiLight6";
            this.uiLight6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight5
            // 
            this.uiLight5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight5.Location = new System.Drawing.Point(252, 36);
            this.uiLight5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight5.Name = "uiLight5";
            this.uiLight5.Radius = 35;
            this.uiLight5.Size = new System.Drawing.Size(35, 35);
            this.uiLight5.TabIndex = 142;
            this.uiLight5.Text = "uiLight5";
            this.uiLight5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("宋体", 12F);
            this.label34.Location = new System.Drawing.Point(46, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(311, 16);
            this.label34.TabIndex = 141;
            this.label34.Text = "阀帽，工具，泄压阀,量程1，量程2，量称3";
            // 
            // uiLight4
            // 
            this.uiLight4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight4.Location = new System.Drawing.Point(199, 36);
            this.uiLight4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight4.Name = "uiLight4";
            this.uiLight4.Radius = 35;
            this.uiLight4.Size = new System.Drawing.Size(35, 35);
            this.uiLight4.TabIndex = 140;
            this.uiLight4.Text = "uiLight4";
            this.uiLight4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight3
            // 
            this.uiLight3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight3.Location = new System.Drawing.Point(149, 36);
            this.uiLight3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight3.Name = "uiLight3";
            this.uiLight3.Radius = 35;
            this.uiLight3.Size = new System.Drawing.Size(35, 35);
            this.uiLight3.TabIndex = 139;
            this.uiLight3.Text = "uiLight3";
            this.uiLight3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight2
            // 
            this.uiLight2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight2.Location = new System.Drawing.Point(97, 36);
            this.uiLight2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight2.Name = "uiLight2";
            this.uiLight2.Radius = 35;
            this.uiLight2.Size = new System.Drawing.Size(35, 35);
            this.uiLight2.TabIndex = 138;
            this.uiLight2.Text = "uiLight2";
            this.uiLight2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight1
            // 
            this.uiLight1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight1.Location = new System.Drawing.Point(44, 37);
            this.uiLight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight1.Name = "uiLight1";
            this.uiLight1.Radius = 35;
            this.uiLight1.Size = new System.Drawing.Size(35, 35);
            this.uiLight1.TabIndex = 137;
            this.uiLight1.Text = "阀帽";
            this.uiLight1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.uiLight6);
            this.groupBox1.Controls.Add(this.uiLight1);
            this.groupBox1.Controls.Add(this.uiLight5);
            this.groupBox1.Controls.Add(this.uiLight2);
            this.groupBox1.Controls.Add(this.uiLight3);
            this.groupBox1.Controls.Add(this.uiLight4);
            this.groupBox1.Controls.Add(this.uiLedLabel4);
            this.groupBox1.Location = new System.Drawing.Point(286, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 124);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            // 
            // JiaoYan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 689);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JiaoYan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "校验";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JiaoYan_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closed);
            this.Load += new System.EventHandler(this.JiaoYan_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Sunny.UI.UILedLabel uiLedLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
      
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer3;
        private Sunny.UI.UILedLabel lbltime;
        private Sunny.UI.UILedLabel label4;
        private Sunny.UI.UILedLabel label10;
        private Sunny.UI.UILight uiLight6;
        private Sunny.UI.UILight uiLight5;
        private System.Windows.Forms.Label label34;
        private Sunny.UI.UILight uiLight4;
        private Sunny.UI.UILight uiLight3;
        private Sunny.UI.UILight uiLight2;
        private Sunny.UI.UILight uiLight1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
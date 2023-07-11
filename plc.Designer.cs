namespace WindowsFormsApplication1
{
    partial class plc
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.uiLight1 = new Sunny.UI.UILight();
            this.uiLight2 = new Sunny.UI.UILight();
            this.uiLight3 = new Sunny.UI.UILight();
            this.uiLight4 = new Sunny.UI.UILight();
            this.uiLight5 = new Sunny.UI.UILight();
            this.uiLight6 = new Sunny.UI.UILight();
            this.uiLight7 = new Sunny.UI.UILight();
            this.uiLight8 = new Sunny.UI.UILight();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(500, 60);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(500, 92);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 20);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(500, 124);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(92, 20);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(500, 156);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(92, 20);
            this.comboBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 61);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 115);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 38);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 18);
            this.button2.TabIndex = 8;
            this.button2.Text = "强制`关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 287);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "联机";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 287);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "读IO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(193, 287);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 27);
            this.button5.TabIndex = 11;
            this.button5.Text = "读模拟量";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 205);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 61);
            this.textBox3.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(274, 287);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 27);
            this.button6.TabIndex = 13;
            this.button6.Text = "摄像头1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "评分项";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(373, 287);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 27);
            this.button7.TabIndex = 15;
            this.button7.Text = "摄像头2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(473, 287);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 27);
            this.button8.TabIndex = 16;
            this.button8.Text = "拍照1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 322);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 27);
            this.button9.TabIndex = 17;
            this.button9.Text = "拆帽";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // uiLight1
            // 
            this.uiLight1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight1.Location = new System.Drawing.Point(90, 173);
            this.uiLight1.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight1.Name = "uiLight1";
            this.uiLight1.Radius = 26;
            this.uiLight1.Size = new System.Drawing.Size(26, 28);
            this.uiLight1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLight1.TabIndex = 47;
            this.uiLight1.Text = "uiLight1";
            this.uiLight1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight2
            // 
            this.uiLight2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight2.Location = new System.Drawing.Point(135, 173);
            this.uiLight2.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight2.Name = "uiLight2";
            this.uiLight2.Radius = 26;
            this.uiLight2.Size = new System.Drawing.Size(26, 28);
            this.uiLight2.Style = Sunny.UI.UIStyle.Red;
            this.uiLight2.TabIndex = 48;
            this.uiLight2.Text = "uiLight2";
            this.uiLight2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight3
            // 
            this.uiLight3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight3.Location = new System.Drawing.Point(178, 173);
            this.uiLight3.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight3.Name = "uiLight3";
            this.uiLight3.Radius = 26;
            this.uiLight3.Size = new System.Drawing.Size(26, 28);
            this.uiLight3.Style = Sunny.UI.UIStyle.Red;
            this.uiLight3.TabIndex = 49;
            this.uiLight3.Text = "uiLight3";
            this.uiLight3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight4
            // 
            this.uiLight4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight4.Location = new System.Drawing.Point(223, 173);
            this.uiLight4.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight4.Name = "uiLight4";
            this.uiLight4.Radius = 26;
            this.uiLight4.Size = new System.Drawing.Size(26, 28);
            this.uiLight4.Style = Sunny.UI.UIStyle.Red;
            this.uiLight4.TabIndex = 50;
            this.uiLight4.Text = "uiLight4";
            this.uiLight4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight5
            // 
            this.uiLight5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight5.Location = new System.Drawing.Point(274, 173);
            this.uiLight5.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight5.Name = "uiLight5";
            this.uiLight5.Radius = 26;
            this.uiLight5.Size = new System.Drawing.Size(26, 28);
            this.uiLight5.Style = Sunny.UI.UIStyle.Red;
            this.uiLight5.TabIndex = 51;
            this.uiLight5.Text = "uiLight5";
            this.uiLight5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight6
            // 
            this.uiLight6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight6.Location = new System.Drawing.Point(317, 173);
            this.uiLight6.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight6.Name = "uiLight6";
            this.uiLight6.Radius = 26;
            this.uiLight6.Size = new System.Drawing.Size(26, 28);
            this.uiLight6.Style = Sunny.UI.UIStyle.Red;
            this.uiLight6.TabIndex = 52;
            this.uiLight6.Text = "uiLight6";
            this.uiLight6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight7
            // 
            this.uiLight7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight7.Location = new System.Drawing.Point(373, 173);
            this.uiLight7.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight7.Name = "uiLight7";
            this.uiLight7.Radius = 26;
            this.uiLight7.Size = new System.Drawing.Size(26, 28);
            this.uiLight7.Style = Sunny.UI.UIStyle.Red;
            this.uiLight7.TabIndex = 53;
            this.uiLight7.Text = "uiLight7";
            this.uiLight7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLight8
            // 
            this.uiLight8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight8.Location = new System.Drawing.Point(416, 173);
            this.uiLight8.Margin = new System.Windows.Forms.Padding(2);
            this.uiLight8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight8.Name = "uiLight8";
            this.uiLight8.Radius = 26;
            this.uiLight8.Size = new System.Drawing.Size(26, 28);
            this.uiLight8.Style = Sunny.UI.UIStyle.Red;
            this.uiLight8.TabIndex = 54;
            this.uiLight8.Text = "uiLight8";
            this.uiLight8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(193, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // plc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiLight8);
            this.Controls.Add(this.uiLight7);
            this.Controls.Add(this.uiLight6);
            this.Controls.Add(this.uiLight5);
            this.Controls.Add(this.uiLight4);
            this.Controls.Add(this.uiLight3);
            this.Controls.Add(this.uiLight2);
            this.Controls.Add(this.uiLight1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "plc";
            this.Text = "plc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.plc_FormClosing);
            this.Load += new System.EventHandler(this.plc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private Sunny.UI.UILight uiLight1;
        private Sunny.UI.UILight uiLight2;
        private Sunny.UI.UILight uiLight3;
        private Sunny.UI.UILight uiLight4;
        private Sunny.UI.UILight uiLight5;
        private Sunny.UI.UILight uiLight6;
        private Sunny.UI.UILight uiLight7;
        private Sunny.UI.UILight uiLight8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
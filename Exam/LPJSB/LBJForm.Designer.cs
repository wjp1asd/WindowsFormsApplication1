﻿namespace WindowsFormsApplication1.Exam
{
    partial class LBJForm
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
            this.btnUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.CheckBox();
            this.rdbC = new System.Windows.Forms.CheckBox();
            this.rdbB = new System.Windows.Forms.CheckBox();
            this.rdbA = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltime = new Sunny.UI.UILedLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.Location = new System.Drawing.Point(165, 15);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(120, 48);
            this.btnUp.TabIndex = 24;
            this.btnUp.Text = "上一题";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "请认真阅读题目";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(395, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 48);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 20F);
            this.label5.Location = new System.Drawing.Point(616, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "选项";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "总题数：10，当前：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(196, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "第       题";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(656, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "总题数：20，当前：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(656, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "总题数：20，当前：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(57, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 20F);
            this.label7.Location = new System.Drawing.Point(282, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "1";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 14F);
            this.label9.Location = new System.Drawing.Point(656, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "总题数：20，当前：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(656, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "总题数：20，当前：";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbD.Location = new System.Drawing.Point(620, 205);
            this.rdbD.Margin = new System.Windows.Forms.Padding(2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(157, 31);
            this.rdbD.TabIndex = 35;
            this.rdbD.Tag = "D";
            this.rdbD.Text = "checkBox4";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbC.Location = new System.Drawing.Point(620, 178);
            this.rdbC.Margin = new System.Windows.Forms.Padding(2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(157, 31);
            this.rdbC.TabIndex = 34;
            this.rdbC.Tag = "C";
            this.rdbC.Text = "checkBox3";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbB.Location = new System.Drawing.Point(620, 150);
            this.rdbB.Margin = new System.Windows.Forms.Padding(2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(157, 31);
            this.rdbB.TabIndex = 33;
            this.rdbB.Tag = "B";
            this.rdbB.Text = "checkBox2";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbA.Location = new System.Drawing.Point(620, 123);
            this.rdbA.Margin = new System.Windows.Forms.Padding(2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(157, 31);
            this.rdbA.TabIndex = 32;
            this.rdbA.Tag = "A";
            this.rdbA.Text = "checkBox1";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 63);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(618, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 117;
            this.button1.Text = "结束";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.IntervalOn = 3;
            this.lbltime.Location = new System.Drawing.Point(1109, 22);
            this.lbltime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltime.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(155, 52);
            this.lbltime.Style = Sunny.UI.UIStyle.Custom;
            this.lbltime.StyleCustomMode = true;
            this.lbltime.TabIndex = 116;
            this.lbltime.Text = "--:--";
            this.lbltime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 14F);
            this.label10.Location = new System.Drawing.Point(705, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 105;
            this.label10.Text = "分值：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 14F);
            this.label11.Location = new System.Drawing.Point(773, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 106;
            this.label11.Text = "0";
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLedLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uiLedLabel1.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.uiLedLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLedLabel1.IntervalOn = 3;
            this.uiLedLabel1.Location = new System.Drawing.Point(818, 9);
            this.uiLedLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(116, 42);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.StyleCustomMode = true;
            this.uiLedLabel1.TabIndex = 116;
            this.uiLedLabel1.Text = "--:--";
            this.uiLedLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LBJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 619);
            this.Controls.Add(this.uiLedLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LBJForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "零配件答题";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SizeChanged += new System.EventHandler(this.groupBox1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox rdbD;
        private System.Windows.Forms.CheckBox rdbC;
        private System.Windows.Forms.CheckBox rdbB;
        public System.Windows.Forms.CheckBox rdbA;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UILedLabel lbltime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private System.Windows.Forms.Button button1;
    }
}
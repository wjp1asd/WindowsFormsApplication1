﻿namespace WindowsFormsApplication1.Exam.MF
{
    partial class XHForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestionContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.CheckBox();
            this.rdbB = new System.Windows.Forms.CheckBox();
            this.rdbC = new System.Windows.Forms.CheckBox();
            this.rdbD = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.lbltime = new Sunny.UI.UILedLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(270, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "第       题";
            // 
            // txtQuestionContent
            // 
            this.txtQuestionContent.Font = new System.Drawing.Font("宋体", 20F);
            this.txtQuestionContent.Location = new System.Drawing.Point(44, 89);
            this.txtQuestionContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestionContent.Multiline = true;
            this.txtQuestionContent.Name = "txtQuestionContent";
            this.txtQuestionContent.ReadOnly = true;
            this.txtQuestionContent.Size = new System.Drawing.Size(829, 121);
            this.txtQuestionContent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "总题数：10，当前：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 20F);
            this.label5.Location = new System.Drawing.Point(44, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "选项";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNext.Location = new System.Drawing.Point(454, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 48);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "请认真阅读题目";
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUp.Location = new System.Drawing.Point(217, 16);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(120, 48);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "上一题";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(339, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(703, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "总题数：20，当前：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 14F);
            this.label7.Location = new System.Drawing.Point(703, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "总题数：20，当前：";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbA.Location = new System.Drawing.Point(49, 262);
            this.rdbA.Margin = new System.Windows.Forms.Padding(2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(157, 31);
            this.rdbA.TabIndex = 13;
            this.rdbA.Tag = "A";
            this.rdbA.Text = "checkBox1";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbB.Location = new System.Drawing.Point(49, 292);
            this.rdbB.Margin = new System.Windows.Forms.Padding(2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(157, 31);
            this.rdbB.TabIndex = 14;
            this.rdbB.Tag = "B";
            this.rdbB.Text = "checkBox2";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.CheckedChanged += new System.EventHandler(this.rdbB_CheckedChanged_1);
            this.rdbB.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbC.Location = new System.Drawing.Point(49, 321);
            this.rdbC.Margin = new System.Windows.Forms.Padding(2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(157, 31);
            this.rdbC.TabIndex = 15;
            this.rdbC.Tag = "C";
            this.rdbC.Text = "checkBox3";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.CheckedChanged += new System.EventHandler(this.rdbC_CheckedChanged_1);
            this.rdbC.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("宋体", 20F);
            this.rdbD.Location = new System.Drawing.Point(49, 352);
            this.rdbD.Margin = new System.Windows.Forms.Padding(2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(157, 31);
            this.rdbD.TabIndex = 16;
            this.rdbD.Tag = "D";
            this.rdbD.Text = "checkBox4";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(703, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "总题数：20，当前：";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 14F);
            this.label9.Location = new System.Drawing.Point(703, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "总题数：20，当前：";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(718, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "[]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiLedLabel1);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rdbD);
            this.groupBox1.Controls.Add(this.rdbC);
            this.groupBox1.Controls.Add(this.rdbB);
            this.groupBox1.Controls.Add(this.rdbA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuestionContent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(957, 557);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLedLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uiLedLabel1.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.uiLedLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLedLabel1.IntervalOn = 3;
            this.uiLedLabel1.Location = new System.Drawing.Point(832, 18);
            this.uiLedLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(116, 42);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.StyleCustomMode = true;
            this.uiLedLabel1.TabIndex = 117;
            this.uiLedLabel1.Text = "--:--";
            this.uiLedLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.IntervalOn = 3;
            this.lbltime.Location = new System.Drawing.Point(1071, 18);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2);
            this.lbltime.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(116, 42);
            this.lbltime.Style = Sunny.UI.UIStyle.Custom;
            this.lbltime.StyleCustomMode = true;
            this.lbltime.TabIndex = 116;
            this.lbltime.Text = "--:--";
            this.lbltime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(2, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 70);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(679, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "结束";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // XHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 557);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XHForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "型号识别答题";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuestionContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rdbA;
        private System.Windows.Forms.CheckBox rdbB;
        private System.Windows.Forms.CheckBox rdbC;
        private System.Windows.Forms.CheckBox rdbD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UILedLabel lbltime;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private System.Windows.Forms.Timer timer2;
    }
}
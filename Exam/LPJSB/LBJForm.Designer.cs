namespace WindowsFormsApplication1.Exam
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
            this.lbltime = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.Location = new System.Drawing.Point(385, 483);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(124, 35);
            this.btnUp.TabIndex = 24;
            this.btnUp.Text = "上一题";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "请认真阅读题目";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(722, 483);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 35);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(507, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "选项";
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltime.Location = new System.Drawing.Point(1122, 6);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(129, 25);
            this.lbltime.TabIndex = 23;
            this.lbltime.Text = "          ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "总题数：10，当前：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(243, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
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
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(173, 555);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "总题数：20，当前：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(173, 592);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "总题数：20，当前：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.zx;
            this.pictureBox1.Location = new System.Drawing.Point(124, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(314, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 14F);
            this.label9.Location = new System.Drawing.Point(537, 349);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "总题数：20，当前：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(155, 526);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "总题数：20，当前：";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbD.Location = new System.Drawing.Point(1041, 230);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(140, 28);
            this.rdbD.TabIndex = 35;
            this.rdbD.Tag = "D";
            this.rdbD.Text = "checkBox4";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbC.Location = new System.Drawing.Point(511, 230);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(140, 28);
            this.rdbC.TabIndex = 34;
            this.rdbC.Tag = "C";
            this.rdbC.Text = "checkBox3";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbB.Location = new System.Drawing.Point(1041, 173);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(140, 28);
            this.rdbB.TabIndex = 33;
            this.rdbB.Tag = "B";
            this.rdbB.Text = "checkBox2";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbA.Location = new System.Drawing.Point(511, 173);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(140, 28);
            this.rdbA.TabIndex = 32;
            this.rdbA.Tag = "A";
            this.rdbA.Text = "checkBox1";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // LBJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 634);
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
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "LBJForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "答题中请勿退出";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SizeChanged += new System.EventHandler(this.groupBox1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime;
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
    }
}
namespace WindowsFormsApplication1
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestionContent = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltime = new Sunny.UI.UILedLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.CheckBox();
            this.rdbC = new System.Windows.Forms.CheckBox();
            this.rdbB = new System.Windows.Forms.CheckBox();
            this.rdbA = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "请认真阅读题目";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "总题数：10，当前：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(192, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "第       题";
            // 
            // txtQuestionContent
            // 
            this.txtQuestionContent.Font = new System.Drawing.Font("宋体", 14F);
            this.txtQuestionContent.Location = new System.Drawing.Point(130, 88);
            this.txtQuestionContent.Multiline = true;
            this.txtQuestionContent.Name = "txtQuestionContent";
            this.txtQuestionContent.ReadOnly = true;
            this.txtQuestionContent.Size = new System.Drawing.Size(829, 146);
            this.txtQuestionContent.TabIndex = 4;
            this.txtQuestionContent.TextChanged += new System.EventHandler(this.txtQuestionContent_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(467, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 43);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrent.Location = new System.Drawing.Point(183, 88);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(17, 20);
            this.lblCurrent.TabIndex = 6;
            this.lblCurrent.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label5.Location = new System.Drawing.Point(130, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "选项：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUp.Location = new System.Drawing.Point(194, 20);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(128, 43);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "上一题";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Size = new System.Drawing.Size(974, 587);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(776, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 19);
            this.label11.TabIndex = 116;
            this.label11.Text = "[]";
            this.label11.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 21F);
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.IntervalOn = 3;
            this.lbltime.Location = new System.Drawing.Point(842, 16);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2);
            this.lbltime.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(116, 42);
            this.lbltime.Style = Sunny.UI.UIStyle.Custom;
            this.lbltime.StyleCustomMode = true;
            this.lbltime.TabIndex = 115;
            this.lbltime.Text = "--:--";
            this.lbltime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(2, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 69);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(722, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "结束";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(336, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "[]";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 14F);
            this.label9.Location = new System.Drawing.Point(735, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "总题数：20，当前：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(735, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "总题数：20，当前：";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("宋体", 18F);
            this.rdbD.Location = new System.Drawing.Point(130, 376);
            this.rdbD.Margin = new System.Windows.Forms.Padding(2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(137, 28);
            this.rdbD.TabIndex = 16;
            this.rdbD.Tag = "D";
            this.rdbD.Text = "checkBox4";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.CheckedChanged += new System.EventHandler(this.rdbA_CheckedChanged_1);
            this.rdbD.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("宋体", 18F);
            this.rdbC.Location = new System.Drawing.Point(130, 349);
            this.rdbC.Margin = new System.Windows.Forms.Padding(2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(137, 28);
            this.rdbC.TabIndex = 15;
            this.rdbC.Tag = "C";
            this.rdbC.Text = "checkBox3";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.CheckedChanged += new System.EventHandler(this.rdbA_CheckedChanged_1);
            this.rdbC.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("宋体", 18F);
            this.rdbB.Location = new System.Drawing.Point(130, 320);
            this.rdbB.Margin = new System.Windows.Forms.Padding(2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(137, 28);
            this.rdbB.TabIndex = 14;
            this.rdbB.Tag = "B";
            this.rdbB.Text = "checkBox2";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.CheckStateChanged += new System.EventHandler(this.rdbA_CheckedChanged_1);
            this.rdbB.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("宋体", 18F);
            this.rdbA.Location = new System.Drawing.Point(130, 293);
            this.rdbA.Margin = new System.Windows.Forms.Padding(2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(137, 28);
            this.rdbA.TabIndex = 13;
            this.rdbA.Tag = "A";
            this.rdbA.Text = "checkBox1";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.CheckedChanged += new System.EventHandler(this.rdbA_CheckedChanged_1);
            this.rdbA.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 14F);
            this.label7.Location = new System.Drawing.Point(735, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "总题数：20，当前：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(735, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "总题数：20，当前：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(239, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(974, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回答问题";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuestionContent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rdbD;
        private System.Windows.Forms.CheckBox rdbC;
        private System.Windows.Forms.CheckBox rdbB;
        private System.Windows.Forms.CheckBox rdbA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UILedLabel lbltime;
        private System.Windows.Forms.Label label11;
    }
}
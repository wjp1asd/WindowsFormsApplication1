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
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.txtQuestionContent = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rbdC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "请认真阅读题目";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "总题数：10，当前：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(256, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "第       题";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.BackColor = System.Drawing.Color.Transparent;
            this.rdbA.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbA.Location = new System.Drawing.Point(178, 345);
            this.rdbA.Margin = new System.Windows.Forms.Padding(4);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(175, 28);
            this.rdbA.TabIndex = 3;
            this.rdbA.TabStop = true;
            this.rdbA.Tag = "A";
            this.rdbA.Text = "radioButton1";
            this.rdbA.UseVisualStyleBackColor = false;
            this.rdbA.CheckedChanged += new System.EventHandler(this.rdbA_CheckedChanged);
            this.rdbA.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // txtQuestionContent
            // 
            this.txtQuestionContent.Font = new System.Drawing.Font("宋体", 14F);
            this.txtQuestionContent.Location = new System.Drawing.Point(173, 110);
            this.txtQuestionContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestionContent.Multiline = true;
            this.txtQuestionContent.Name = "txtQuestionContent";
            this.txtQuestionContent.Size = new System.Drawing.Size(1104, 181);
            this.txtQuestionContent.TabIndex = 4;
            this.txtQuestionContent.TextChanged += new System.EventHandler(this.txtQuestionContent_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(735, 498);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 35);
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
            this.lblCurrent.Location = new System.Drawing.Point(244, 110);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(21, 24);
            this.lblCurrent.TabIndex = 6;
            this.lblCurrent.Text = "1";
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.BackColor = System.Drawing.Color.Transparent;
            this.rdbB.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbB.Location = new System.Drawing.Point(968, 345);
            this.rdbB.Margin = new System.Windows.Forms.Padding(4);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(175, 28);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.Tag = "B";
            this.rdbB.Text = "radioButton1";
            this.rdbB.UseVisualStyleBackColor = false;
            this.rdbB.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rbdC
            // 
            this.rbdC.AutoSize = true;
            this.rbdC.BackColor = System.Drawing.Color.Transparent;
            this.rbdC.Font = new System.Drawing.Font("宋体", 14F);
            this.rbdC.Location = new System.Drawing.Point(178, 409);
            this.rbdC.Margin = new System.Windows.Forms.Padding(4);
            this.rbdC.Name = "rbdC";
            this.rbdC.Size = new System.Drawing.Size(175, 28);
            this.rbdC.TabIndex = 3;
            this.rbdC.TabStop = true;
            this.rbdC.Tag = "C";
            this.rbdC.Text = "radioButton1";
            this.rbdC.UseVisualStyleBackColor = false;
            this.rbdC.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.BackColor = System.Drawing.Color.Transparent;
            this.rdbD.Font = new System.Drawing.Font("宋体", 14F);
            this.rdbD.Location = new System.Drawing.Point(968, 409);
            this.rdbD.Margin = new System.Windows.Forms.Padding(4);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(175, 28);
            this.rdbD.TabIndex = 3;
            this.rdbD.TabStop = true;
            this.rdbD.Tag = "D";
            this.rdbD.Text = "radioButton1";
            this.rdbD.UseVisualStyleBackColor = false;
            this.rdbD.Click += new System.EventHandler(this.rdbA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(174, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "选项";
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltime.Location = new System.Drawing.Point(1135, 21);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(129, 25);
            this.lbltime.TabIndex = 8;
            this.lbltime.Text = "          ";
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.Location = new System.Drawing.Point(398, 498);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(124, 35);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "上一题";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuestionContent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdbD);
            this.groupBox1.Controls.Add(this.rdbA);
            this.groupBox1.Controls.Add(this.rbdC);
            this.groupBox1.Controls.Add(this.rdbB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1298, 634);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(319, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(169, 571);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "总题数：20，当前：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 14F);
            this.label7.Location = new System.Drawing.Point(169, 534);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "总题数：20，当前：";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1298, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回答问题";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.TextBox txtQuestionContent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rbdC;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
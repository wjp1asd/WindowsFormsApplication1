﻿namespace WindowsFormsApplication1.Exam
{
    partial class Print
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
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.queue = new System.Windows.Forms.Label();
            this.ksname = new System.Windows.Forms.Label();
            this.kstime = new System.Windows.Forms.Label();
            this.ksId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.zxlx = new System.Windows.Forms.Label();
            this.zxyl = new System.Windows.Forms.Label();
            this.aqfxh = new System.Windows.Forms.Label();
            this.lxlx = new System.Windows.Forms.Label();
            this.lxyl = new System.Windows.Forms.Label();
            this.uiLight1 = new Sunny.UI.UILight();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(503, 566);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(209, 62);
            this.button7.TabIndex = 25;
            this.button7.Text = "<返回>";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(73, 566);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 62);
            this.button3.TabIndex = 24;
            this.button3.Text = "打印";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(181, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 52);
            this.label2.TabIndex = 21;
            this.label2.Text = "安全阀模拟考试系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(71, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "排队号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(336, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "加载打印机配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(515, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "考试时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(515, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "身份证号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(71, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "考 生：";
            // 
            // queue
            // 
            this.queue.AutoSize = true;
            this.queue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queue.Location = new System.Drawing.Point(152, 70);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(79, 15);
            this.queue.TabIndex = 32;
            this.queue.Text = "********";
            // 
            // ksname
            // 
            this.ksname.AutoSize = true;
            this.ksname.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ksname.Location = new System.Drawing.Point(152, 98);
            this.ksname.Name = "ksname";
            this.ksname.Size = new System.Drawing.Size(79, 15);
            this.ksname.TabIndex = 33;
            this.ksname.Text = "********";
            // 
            // kstime
            // 
            this.kstime.AutoSize = true;
            this.kstime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kstime.Location = new System.Drawing.Point(613, 70);
            this.kstime.Name = "kstime";
            this.kstime.Size = new System.Drawing.Size(142, 15);
            this.kstime.TabIndex = 34;
            this.kstime.Text = "2023/1/20 15:52";
            this.kstime.Click += new System.EventHandler(this.kstime_Click);
            // 
            // ksId
            // 
            this.ksId.AutoSize = true;
            this.ksId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ksId.Location = new System.Drawing.Point(613, 98);
            this.ksId.Name = "ksId";
            this.ksId.Size = new System.Drawing.Size(160, 15);
            this.ksId.TabIndex = 35;
            this.ksId.Text = "*****************";
            this.ksId.Click += new System.EventHandler(this.ksId_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(47, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "1、离线校验";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(47, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "2、在线校验";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(47, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 24);
            this.label13.TabIndex = 38;
            this.label13.Text = "3、密封面研磨";
            // 
            // zxlx
            // 
            this.zxlx.AutoSize = true;
            this.zxlx.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.zxlx.Location = new System.Drawing.Point(95, 326);
            this.zxlx.Name = "zxlx";
            this.zxlx.Size = new System.Drawing.Size(314, 24);
            this.zxlx.TabIndex = 42;
            this.zxlx.Text = "使用设备类型：********；";
            // 
            // zxyl
            // 
            this.zxyl.AutoSize = true;
            this.zxyl.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.zxyl.Location = new System.Drawing.Point(95, 290);
            this.zxyl.Name = "zxyl";
            this.zxyl.Size = new System.Drawing.Size(341, 24);
            this.zxyl.TabIndex = 41;
            this.zxyl.Text = "要求整定压力：****.***Mpa;";
            // 
            // aqfxh
            // 
            this.aqfxh.AutoSize = true;
            this.aqfxh.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.aqfxh.Location = new System.Drawing.Point(95, 419);
            this.aqfxh.Name = "aqfxh";
            this.aqfxh.Size = new System.Drawing.Size(289, 24);
            this.aqfxh.TabIndex = 43;
            this.aqfxh.Text = "安全阀型号：********；";
            // 
            // lxlx
            // 
            this.lxlx.AutoSize = true;
            this.lxlx.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lxlx.Location = new System.Drawing.Point(95, 206);
            this.lxlx.Name = "lxlx";
            this.lxlx.Size = new System.Drawing.Size(314, 24);
            this.lxlx.TabIndex = 45;
            this.lxlx.Text = "使用设备类型：********；";
            // 
            // lxyl
            // 
            this.lxyl.AutoSize = true;
            this.lxyl.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lxyl.Location = new System.Drawing.Point(95, 170);
            this.lxyl.Name = "lxyl";
            this.lxyl.Size = new System.Drawing.Size(341, 24);
            this.lxyl.TabIndex = 44;
            this.lxyl.Text = "要求整定压力：****.***Mpa;";
            // 
            // uiLight1
            // 
            this.uiLight1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight1.Location = new System.Drawing.Point(373, 592);
            this.uiLight1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiLight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight1.Name = "uiLight1";
            this.uiLight1.Radius = 35;
            this.uiLight1.Size = new System.Drawing.Size(35, 35);
            this.uiLight1.Style = Sunny.UI.UIStyle.Red;
            this.uiLight1.TabIndex = 46;
            this.uiLight1.Text = "uiLight1";
            this.uiLight1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiLight1.Click += new System.EventHandler(this.uiLight1_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 669);
            this.Controls.Add(this.uiLight1);
            this.Controls.Add(this.lxlx);
            this.Controls.Add(this.lxyl);
            this.Controls.Add(this.aqfxh);
            this.Controls.Add(this.zxlx);
            this.Controls.Add(this.zxyl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ksId);
            this.Controls.Add(this.kstime);
            this.Controls.Add(this.ksname);
            this.Controls.Add(this.queue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考生信息打印";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label queue;
        private System.Windows.Forms.Label ksname;
        private System.Windows.Forms.Label kstime;
        private System.Windows.Forms.Label ksId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label zxlx;
        private System.Windows.Forms.Label zxyl;
        private System.Windows.Forms.Label aqfxh;
        private System.Windows.Forms.Label lxlx;
        private System.Windows.Forms.Label lxyl;
        private Sunny.UI.UILight uiLight1;
    }
}
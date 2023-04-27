namespace WindowsFormsApplication1.Exam
{
    partial class Exam1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiBreadcrumb1 = new Sunny.UI.UIBreadcrumb();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(225, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 70);
            this.button2.TabIndex = 44;
            this.button2.Text = "在线校验";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(225, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 70);
            this.button1.TabIndex = 43;
            this.button1.Text = "离线校验";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(225, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 70);
            this.button3.TabIndex = 42;
            this.button3.Text = "密封面研磨";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(216, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 52);
            this.label2.TabIndex = 41;
            this.label2.Text = "安全阀模拟考试系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uiBreadcrumb1
            // 
            this.uiBreadcrumb1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBreadcrumb1.Items.AddRange(new object[] {
            "步骤一",
            "步骤二",
            "步骤三",
            "步骤四"});
            this.uiBreadcrumb1.ItemWidth = 192;
            this.uiBreadcrumb1.Location = new System.Drawing.Point(38, 527);
            this.uiBreadcrumb1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBreadcrumb1.Name = "uiBreadcrumb1";
            this.uiBreadcrumb1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiBreadcrumb1.Size = new System.Drawing.Size(725, 29);
            this.uiBreadcrumb1.Style = Sunny.UI.UIStyle.LayuiRed;
            this.uiBreadcrumb1.TabIndex = 45;
            this.uiBreadcrumb1.Text = "1";
            this.uiBreadcrumb1.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.uiBreadcrumb1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiBreadcrumb1.ItemIndexChanged += new Sunny.UI.UIBreadcrumb.OnValueChanged(this.uiBreadcrumb1_ItemIndexChanged);
            // 
            // Exam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.uiBreadcrumb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Name = "Exam1";
            this.Text = "考试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Exam1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIBreadcrumb uiBreadcrumb1;
    }
}
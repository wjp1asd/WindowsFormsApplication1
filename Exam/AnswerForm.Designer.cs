namespace WindowsFormsApplication1
{
    partial class AnswerForm
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
            this.btnsend = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsend.BackColor = System.Drawing.Color.Turquoise;
            this.btnsend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsend.ForeColor = System.Drawing.Color.Transparent;
            this.btnsend.Location = new System.Drawing.Point(430, 400);
            this.btnsend.Margin = new System.Windows.Forms.Padding(4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(119, 45);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "提交";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltime.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.lbltime.Location = new System.Drawing.Point(790, 9);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(155, 39);
            this.lbltime.TabIndex = 1;
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 458);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnsend);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "答题卡";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;

    }
}
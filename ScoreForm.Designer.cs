namespace WindowsFormsApplication1
{
    partial class ScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            this.lblscore = new System.Windows.Forms.Label();
            this.lblAllscore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblSpeak = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAllResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblscore.Location = new System.Drawing.Point(99, 265);
            this.lblscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(133, 25);
            this.lblscore.TabIndex = 4;
            this.lblscore.Click += new System.EventHandler(this.lblscore_Click);
            // 
            // lblAllscore
            // 
            this.lblAllscore.BackColor = System.Drawing.Color.Green;
            this.lblAllscore.Location = new System.Drawing.Point(99, 322);
            this.lblAllscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllscore.Name = "lblAllscore";
            this.lblAllscore.Size = new System.Drawing.Size(400, 25);
            this.lblAllscore.TabIndex = 4;
            this.lblAllscore.Click += new System.EventHandler(this.lblAllscore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(27, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "得分";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "满分";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.gif");
            this.imageList1.Images.SetKeyName(1, "2.gif");
            this.imageList1.Images.SetKeyName(2, "3.gif");
            this.imageList1.Images.SetKeyName(3, "4.gif");
            this.imageList1.Images.SetKeyName(4, "5.gif");
            // 
            // lblSpeak
            // 
            this.lblSpeak.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeak.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpeak.Location = new System.Drawing.Point(207, 105);
            this.lblSpeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeak.Name = "lblSpeak";
            this.lblSpeak.Size = new System.Drawing.Size(200, 38);
            this.lblSpeak.TabIndex = 7;
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.Transparent;
            this.picFace.Location = new System.Drawing.Point(16, 62);
            this.picFace.Margin = new System.Windows.Forms.Padding(4);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(183, 115);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 8;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(520, 261);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 25);
            this.lblResult.TabIndex = 9;
            // 
            // lblAllResult
            // 
            this.lblAllResult.BackColor = System.Drawing.Color.Transparent;
            this.lblAllResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAllResult.Location = new System.Drawing.Point(520, 322);
            this.lblAllResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllResult.Name = "lblAllResult";
            this.lblAllResult.Size = new System.Drawing.Size(67, 25);
            this.lblAllResult.TabIndex = 10;
            this.lblAllResult.Text = "100分";
            this.lblAllResult.Click += new System.EventHandler(this.lblAllResult_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(248, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(99, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 25);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAllResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.lblSpeak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAllscore);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblAllscore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblSpeak;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAllResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
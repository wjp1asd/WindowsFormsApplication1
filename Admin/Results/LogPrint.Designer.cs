namespace WindowsFormsApplication1.Admin.Results
{
    partial class LogPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kfdm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kffz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kssj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.itemname,
            this.kfdm,
            this.kffz,
            this.kssj,
            this.qid});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(11, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(892, 341);
            this.dataGridView1.TabIndex = 53;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 10F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemname.DataPropertyName = "itemname";
            dataGridViewCellStyle3.NullValue = "0";
            this.itemname.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemname.HeaderText = "操作描述";
            this.itemname.MinimumWidth = 6;
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemname.Width = 168;
            // 
            // kfdm
            // 
            this.kfdm.DataPropertyName = "kfdm";
            this.kfdm.FillWeight = 14.59391F;
            this.kfdm.HeaderText = "代码";
            this.kfdm.Name = "kfdm";
            this.kfdm.ReadOnly = true;
            // 
            // kffz
            // 
            this.kffz.DataPropertyName = "kffz";
            this.kffz.FillWeight = 14.59391F;
            this.kffz.HeaderText = "分值";
            this.kffz.MinimumWidth = 6;
            this.kffz.Name = "kffz";
            this.kffz.ReadOnly = true;
            // 
            // kssj
            // 
            this.kssj.DataPropertyName = "kssj";
            this.kssj.FillWeight = 14.59391F;
            this.kssj.HeaderText = "考试日期";
            this.kssj.MinimumWidth = 6;
            this.kssj.Name = "kssj";
            this.kssj.ReadOnly = true;
            // 
            // qid
            // 
            this.qid.DataPropertyName = "qid";
            this.qid.FillWeight = 14.59391F;
            this.qid.HeaderText = "考试序列号";
            this.qid.MinimumWidth = 6;
            this.qid.Name = "qid";
            this.qid.ReadOnly = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(11, 11);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(166, 21);
            this.textBox8.TabIndex = 59;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(180, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 24);
            this.button5.TabIndex = 58;
            this.button5.Text = "查询\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(235, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 24);
            this.button6.TabIndex = 57;
            this.button6.Text = "关闭";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(853, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 24);
            this.button1.TabIndex = 60;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 24);
            this.button2.TabIndex = 61;
            this.button2.Text = "特检上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LogPrint";
            this.Text = "日志";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn kfdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn kffz;
        private System.Windows.Forms.DataGridViewTextBoxColumn kssj;
        private System.Windows.Forms.DataGridViewTextBoxColumn qid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
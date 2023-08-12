namespace WindowsFormsApplication1
{
    partial class ResultSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dick = new System.Windows.Forms.DataGridViewButtonColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cz,
            this.dick,
            this.path,
            this.name,
            this.idcard,
            this.testid,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(29, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 426);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(29, 26);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(220, 25);
            this.textBox8.TabIndex = 56;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 30);
            this.button5.TabIndex = 55;
            this.button5.Text = "查询\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(328, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 53;
            this.button6.Text = "关闭";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cz
            // 
            this.cz.DataPropertyName = "testid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "操作";
            this.cz.DefaultCellStyle = dataGridViewCellStyle1;
            this.cz.HeaderText = "打印";
            this.cz.MinimumWidth = 6;
            this.cz.Name = "cz";
            this.cz.ReadOnly = true;
            this.cz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cz.Text = "打印";
            this.cz.ToolTipText = "打印";
            this.cz.UseColumnTextForButtonValue = true;
            // 
            // dick
            // 
            this.dick.DataPropertyName = "testid";
            this.dick.HeaderText = "补打考试条";
            this.dick.MinimumWidth = 6;
            this.dick.Name = "dick";
            this.dick.ReadOnly = true;
            this.dick.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dick.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dick.Text = "补打考试条";
            this.dick.ToolTipText = "补打考试条";
            this.dick.UseColumnTextForButtonValue = true;
            // 
            // path
            // 
            this.path.DataPropertyName = "path";
            dataGridViewCellStyle2.NullValue = "0";
            this.path.DefaultCellStyle = dataGridViewCellStyle2;
            this.path.HeaderText = "成绩";
            this.path.MinimumWidth = 6;
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // idcard
            // 
            this.idcard.DataPropertyName = "idcard";
            this.idcard.HeaderText = "身份证";
            this.idcard.MinimumWidth = 6;
            this.idcard.Name = "idcard";
            this.idcard.ReadOnly = true;
            // 
            // testid
            // 
            this.testid.DataPropertyName = "testid";
            this.testid.HeaderText = "考试码";
            this.testid.MinimumWidth = 6;
            this.testid.Name = "testid";
            this.testid.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "ksdate";
            this.date.HeaderText = "考试日期";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // ResultSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ResultSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResultSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewButtonColumn cz;
        private System.Windows.Forms.DataGridViewButtonColumn dick;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn testid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
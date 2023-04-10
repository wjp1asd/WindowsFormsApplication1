namespace WindowsFormsApplication1.Admin.Students
{
    partial class studentRecord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aqfXh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lxyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LxLx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zxyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZxLx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lxquestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zxquestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ymgquestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyquestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xhquestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpjquestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qrcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
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
            this.pick,
            this.ID,
            this.ksid,
            this.ksname,
            this.aqfXh,
            this.Lxyl,
            this.LxLx,
            this.Zxyl,
            this.ZxLx,
            this.lxquestions,
            this.zxquestions,
            this.ymgquestions,
            this.gyquestions,
            this.xhquestions,
            this.lpjquestions,
            this.qrcode});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 600);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pick
            // 
            this.pick.HeaderText = "选择";
            this.pick.MinimumWidth = 6;
            this.pick.Name = "pick";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ksid
            // 
            this.ksid.DataPropertyName = "ksid";
            this.ksid.HeaderText = "身份证";
            this.ksid.MinimumWidth = 6;
            this.ksid.Name = "ksid";
            // 
            // ksname
            // 
            this.ksname.DataPropertyName = "ksname";
            this.ksname.HeaderText = "姓名";
            this.ksname.MinimumWidth = 6;
            this.ksname.Name = "ksname";
            // 
            // aqfXh
            // 
            this.aqfXh.DataPropertyName = "aqfXh";
            this.aqfXh.HeaderText = "安全阀型号";
            this.aqfXh.MinimumWidth = 6;
            this.aqfXh.Name = "aqfXh";
            // 
            // Lxyl
            // 
            this.Lxyl.DataPropertyName = "Lxyl";
            this.Lxyl.HeaderText = "离线压力";
            this.Lxyl.MinimumWidth = 6;
            this.Lxyl.Name = "Lxyl";
            // 
            // LxLx
            // 
            this.LxLx.DataPropertyName = "LxLx";
            this.LxLx.HeaderText = "离线类型";
            this.LxLx.MinimumWidth = 6;
            this.LxLx.Name = "LxLx";
            // 
            // Zxyl
            // 
            this.Zxyl.DataPropertyName = "Zxyl";
            this.Zxyl.HeaderText = "在线压力";
            this.Zxyl.MinimumWidth = 6;
            this.Zxyl.Name = "Zxyl";
            // 
            // ZxLx
            // 
            this.ZxLx.DataPropertyName = "ZxLx";
            this.ZxLx.HeaderText = "在线类型";
            this.ZxLx.MinimumWidth = 6;
            this.ZxLx.Name = "ZxLx";
            // 
            // lxquestions
            // 
            this.lxquestions.DataPropertyName = "lxquestions";
            this.lxquestions.HeaderText = "离线题";
            this.lxquestions.MinimumWidth = 6;
            this.lxquestions.Name = "lxquestions";
            // 
            // zxquestions
            // 
            this.zxquestions.DataPropertyName = "zxquestions";
            this.zxquestions.HeaderText = "在线题";
            this.zxquestions.MinimumWidth = 6;
            this.zxquestions.Name = "zxquestions";
            // 
            // ymgquestions
            // 
            this.ymgquestions.DataPropertyName = "ymgquestions";
            this.ymgquestions.HeaderText = "研磨题";
            this.ymgquestions.MinimumWidth = 6;
            this.ymgquestions.Name = "ymgquestions";
            // 
            // gyquestions
            // 
            this.gyquestions.DataPropertyName = "gyquestions";
            this.gyquestions.HeaderText = "工艺题";
            this.gyquestions.MinimumWidth = 6;
            this.gyquestions.Name = "gyquestions";
            // 
            // xhquestions
            // 
            this.xhquestions.DataPropertyName = "xhquestions";
            this.xhquestions.HeaderText = "型号识别题";
            this.xhquestions.MinimumWidth = 6;
            this.xhquestions.Name = "xhquestions";
            // 
            // lpjquestions
            // 
            this.lpjquestions.DataPropertyName = "lpjquestions";
            this.lpjquestions.HeaderText = "零配件识别题";
            this.lpjquestions.MinimumWidth = 6;
            this.lpjquestions.Name = "lpjquestions";
            // 
            // qrcode
            // 
            this.qrcode.DataPropertyName = "qrcode";
            this.qrcode.HeaderText = "考试码";
            this.qrcode.MinimumWidth = 6;
            this.qrcode.Name = "qrcode";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 56;
            this.button4.Text = "全选";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // studentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 689);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentRecord";
            this.Text = "学生考试记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.studentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksname;
        private System.Windows.Forms.DataGridViewTextBoxColumn aqfXh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lxyl;
        private System.Windows.Forms.DataGridViewTextBoxColumn LxLx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zxyl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZxLx;
        private System.Windows.Forms.DataGridViewTextBoxColumn lxquestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn zxquestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ymgquestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyquestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn xhquestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpjquestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn qrcode;
    }
}
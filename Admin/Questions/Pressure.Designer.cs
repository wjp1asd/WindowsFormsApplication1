namespace WindowsFormsApplication1.Questions
{
    partial class Pressure
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 46;
            this.button4.Text = "全选";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 45;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(301, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 330);
            this.panel1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(118, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 27);
            this.label5.TabIndex = 62;
            this.label5.Text = "第三次测试压力Mpa:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(350, 217);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 25);
            this.textBox5.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(118, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 27);
            this.label3.TabIndex = 60;
            this.label3.Text = "第二次测试压力Mpa:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 137);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 25);
            this.textBox3.TabIndex = 55;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(350, 173);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 25);
            this.textBox4.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(118, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 27);
            this.label4.TabIndex = 52;
            this.label4.Text = "第一次测试压力Mpa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(480, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 25);
            this.textBox2.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 25);
            this.textBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(291, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 47;
            this.label2.Text = "初次测试压力Mpa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(188, 277);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(50, 30, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 38);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "新增";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(326, 277);
            this.btnExit.Margin = new System.Windows.Forms.Padding(70, 30, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 38);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "要求整定压力Mpa:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsername.Location = new System.Drawing.Point(10, 30);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 27);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.Text = "项目：";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(108, 30);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(439, 25);
            this.txtUsername.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 43;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.type,
            this.ID,
            this.sub,
            this.f0,
            this.f1,
            this.f2,
            this.f3,
            this.f4});
            this.dataGridView1.Location = new System.Drawing.Point(27, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 419);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // pick
            // 
            this.pick.HeaderText = "选择";
            this.pick.MinimumWidth = 6;
            this.pick.Name = "pick";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "类型（0是离线1是在线）";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // sub
            // 
            this.sub.DataPropertyName = "sub";
            this.sub.HeaderText = "项目";
            this.sub.MinimumWidth = 6;
            this.sub.Name = "sub";
            // 
            // f0
            // 
            this.f0.DataPropertyName = "f0";
            this.f0.HeaderText = "要求整定压力MPa";
            this.f0.MinimumWidth = 6;
            this.f0.Name = "f0";
            // 
            // f1
            // 
            this.f1.DataPropertyName = "f1";
            this.f1.HeaderText = "初次测试压力MPa";
            this.f1.MinimumWidth = 6;
            this.f1.Name = "f1";
            // 
            // f2
            // 
            this.f2.DataPropertyName = "f2";
            this.f2.HeaderText = "第一次测试压力Mpa";
            this.f2.MinimumWidth = 6;
            this.f2.Name = "f2";
            // 
            // f3
            // 
            this.f3.DataPropertyName = "f3";
            this.f3.HeaderText = "第二次测试压力Mpa";
            this.f3.MinimumWidth = 6;
            this.f3.Name = "f3";
            // 
            // f4
            // 
            this.f4.DataPropertyName = "f4";
            this.f4.HeaderText = "第三次测试压力Mpa";
            this.f4.MinimumWidth = 6;
            this.f4.Name = "f4";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(440, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 41;
            this.button6.Text = "关闭";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 40;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 529);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(758, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "注意：提取规则，上一次提取调压需要紧定压螺母，本次抽题需要松定压螺母，因此抽考题需要注意\r\n";
            // 
            // Pressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Name = "Pressure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试压力";
            this.Load += new System.EventHandler(this.Pressure_Load);
            this.SizeChanged += new System.EventHandler(this.groupBox1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pick;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn f0;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f2;
        private System.Windows.Forms.DataGridViewTextBoxColumn f3;
        private System.Windows.Forms.DataGridViewTextBoxColumn f4;
    }
}
﻿using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Questions
{
    public partial class Pressure : Form
    {
        int row;
        String TableName = "pressure";
        String Subtype = "0";

        Boolean all = false;
        StringBuilder s1;


        public Pressure(String subtype)
        {
            InitializeComponent();

            switch (subtype)
            {
                case "0":
                    this.Text = "离线压力设置";
                    break;
                case "1":
                    this.Text = "在线压力设置";
                    break;
            }
            Subtype = subtype;
            string sql = "select * from " + TableName + " where type = " + Subtype;
            this.panel1.Hide();
            InitTable(sql);
            ff.dataview(this.dataGridView1);
        }
        private void InitTable(string sql)
        {
            this.dataGridView1.Visible = true;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);

            DataSet ds = new DataSet();
            sda.Fill(ds, "question");
            //   qs = ds.Tables[0];

            this.dataGridView1.DataSource = ds.Tables["question"];
            row = this.dataGridView1.RowCount;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Offline_JiaoYan j = new Offline_JiaoYan();
            j.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (all)
            {

                for (int i = 0; i < row; i++)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = "False";


                }
                this.button4.Text = "全选";
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = "True";


                }

                this.button4.Text = "反选";
            }
            all = !all;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);

                string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题

                if (strcolumn == "pick")
                {

                    return;
                }
                string strrow = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();//获取焦点触发行的第一个值
                string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//获取焦点触发行的第一个值
                string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

                string strcomm = "update " + TableName + " set " + strcolumn + "='" + value + "'where id = " + id;
                //  ff.ShowInfoTip("已更新");

                con.Open();
                SqlCommand comm = new SqlCommand(strcomm, con);
                comm.ExecuteNonQuery();

                con.Close();
                ff.ShowInfoTip("已更新");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sub = this.txtUsername.Text.ToString();
            string f0 = this.textBox1.Text.ToString();
            string f1 = this.textBox2.Text.ToString();
            string f2 = this.textBox3.Text.ToString();
            string f3 = this.textBox4.Text.ToString();
            string f4 = this.textBox5.Text.ToString();
            if (sub.Length == 0 || f0.Length == 0 || f1.Length == 0 ||
                f2.Length == 0 || f3.Length == 0 || f4.Length == 0)
            {
                ff.ShowInfoTip("字段不能为空");
                return;
            }
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into " + TableName + "([type],[sub], [f0], [f1],[f2],[f3],[f4]) VALUES(" +
             "'" + Subtype.ToString() + "'" + "," +
                "'" + sub.ToString() + "'" + "," +
               "'" + f0.ToString() + "'" + "," +
                  "'" + f1.ToString() + "'" + "," +
   "'" + f2.ToString() + "'" + "," +
      "'" + f3.ToString() + "'" + "," +
               "'" + f4.ToString() + "'" + ")"
              ;
            //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')
            //ff.ShowInfoTip(strcomm);
            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
            ff.ShowInfoTip("已更新");
            string sql = "select * from " + TableName + " where type = " + Subtype; ;

            this.InitTable(sql);
        }
        private Fuc ff = new Fuc();
        private void button2_Click(object sender, EventArgs e)
        {
            s1 = new StringBuilder();



            for (int i = 0; i < row; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    //{
                    //ff.ShowInfoTip(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                    s1.Append(this.dataGridView1.Rows[i].Cells[1].Value + ",");
                // }
            }
            if (s1.Length > 0)
            {

                s1.Remove(s1.Length - 1, 1);
            }

            if (s1.Length != 0)
            {
                if (MessageBox.Show("确定删除id" + s1.ToString() + " ? ", "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)

                {

                    string connectionString = ConfigurationManager.AppSettings["sqlc"];
                    SqlConnection con = new SqlConnection(connectionString);



                    string strcomm = "delete from " + TableName + " where id in (" + s1 + ")";
                    //update FilTer set 列名 = value where id = 3
                    //MessageBox.Show(strcomm);

                    con.Open();
                    SqlCommand comm = new SqlCommand(strcomm, con);
                    comm.ExecuteNonQuery();

                    con.Close();
                    ff.ShowInfoTip("已删除");
                    string sql = "select * from " + TableName + " where type = " + Subtype; ;

                    this.InitTable(sql);
                }

            }
            else
            {
                ff.ShowInfoTip("当前没有选择");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from " + TableName + " where type = " + Subtype;
            this.panel1.Hide();
            InitTable(sql);
        }

        private void lblUsername_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }
        private void Pressure_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}


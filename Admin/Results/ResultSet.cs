﻿using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Results;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class ResultSet : Form
    {
        int row;
        String TableName = "Grade";

        Boolean all = false;
        StringBuilder s1;
        public ResultSet()
        {
            InitializeComponent();
            string sql = "Select a.id,a.path,a.name,a.idcard, a.testid,b.ksdate from Grade as a,TestRecord as b Where a.testid = b.qrcode";

            InitTable(sql);
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



        private void button6_Click(object sender, EventArgs e)
        {
            AdminIndex a = new AdminIndex();
            a.Show();
            this.Close();
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }


        private void StudentSet_Load(object sender, EventArgs e)
        {

        }
        private void ResultSet_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "Select a.id,a.path,a.name,a.idcard, a.testid,b.ksdate from Grade as a,TestRecord as b Where a.testid = b.qrcode" + " and  concat(idcard,name) like '%" + this.textBox8.Text + "%'";

            InitTable(sql);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        Fuc ff = new Fuc();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int a = e.RowIndex;
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    //这里可以编写你需要的任意关于按钮事件的操作~
                    string id = dataGridView1.Rows[a].Cells[6].Value.ToString();//获取焦点触发行的第一个值
                    string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题
                    ff.ShowInfoTip("按钮被点击" + id);

                    if (strcolumn == "选取")
                    {

                        return;
                    }


                    if (strcolumn == "cz")
                    {


                        GradePrint gradePrint = new GradePrint(id);
                        gradePrint.Show();
                    }

                }
            }
            else
            {

                return;
            }
        }
    }
}

﻿using AutoWindowsSize;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApplication1.Admin.Results
{
    public partial class LogPrint : Form
    {

        int row;
        String TableName = "log";
        string uid;
        Boolean all = false;
        StringBuilder s1;
        public LogPrint(string id)
        {
            InitializeComponent();
            string sql = "Select * from "+TableName+" Where qid = '"+id.Trim()+"'";
            MessageBox.Show(sql);
            uid = id;
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
            for(int i=0;i<row;i++)
            {
                Kfitems ks = new Kfitems();

                ks.kfdm=this.dataGridView1.Rows[i].Cells[2].Value.ToString(); 
                ks.kffz=this.dataGridView1.Rows[i].Cells[3].ToString(); 
                ks.itemname=this.dataGridView1.Rows[i].Cells[1].ToString(); 




                bb.Add(ks);
            }
        }
        List<Kfitems> bb = new List<Kfitems>();


        private void button6_Click(object sender, EventArgs e)
        {

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
        private void LogPrint_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
          
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox8.Text.Trim().Length > 0)
            {

                string sql = "Select * from " + TableName + " Where qid =" + uid
                + " and itemname like '%" + this.textBox8.Text.Trim() + "%'";

                InitTable(sql);
            }
            else {
                string sql = "Select * from " + TableName + " Where qid =" + uid;

                InitTable(sql);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        Fuc ff = new Fuc();
        private int fz;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int a = e.RowIndex;
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    //这里可以编写你需要的任意关于按钮事件的操作~
                    string id = dataGridView1.Rows[a].Cells[7].Value.ToString();//获取焦点触发行的第一个值
                    string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题
                                                                                            // ff.ShowInfoTip("按钮被点击" + id+ dataGridView1.Rows[a].Cells[1].Value.ToString()+ dataGridView1.Rows[a].Cells[7].Value.ToString());

                    if (strcolumn == "选取")
                    {

                        return;
                    }
                    if (strcolumn == "ksrz")
                    {


                        Print pp = new Print(id);
                        pp.Show();
                    }


                    if (strcolumn == "dick")
                    {


                        Print pp = new Print(id);
                        pp.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "delete  " + TableName + " Where qid = '" + uid+"'"
           ;
            // MessageBox.Show(sql);
            InitTable(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Api a = new Api();
            Grade g = new Grade();
            TestRecord t = new TestRecord();
             t= t.getRecord(uid);
            Student sc=new Student(uid); 
            fz= g.getGrade("path", uid);
            
            
            a.uploadgrade(fz,t.Ksdate,sc.password,sc.loginid,bb);
        }
    }
}

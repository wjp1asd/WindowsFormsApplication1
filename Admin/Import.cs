
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Import : Form
    {

        int row;
        String TableName = "question";
        String Subtype = "1";
        Boolean all = false;
        List<int> s1;
        public static int type = 1;


        public Import(String subtype)
        {

            InitializeComponent();
            switch (subtype)
            {
                case "1":
                    this.Text = "离线校验题库导入";
                    break;
                case "2":
                    this.Text = "在线校验题库导入";
                    break;
                case "3":
                    this.Text = "校验工艺题库导入";
                    break;

                case "4":
                    this.Text = "密封面研磨题库导入";
                    break;
            }
            Subtype = subtype;
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
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        public void GetData(string Id, string name, bool rt)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = new List<int>(); ;



            for (int i = 0; i < row; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    //ff.ShowInfoTip(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                    s1.Add(i);
                }
            }

            // ff.ShowInfoTip(s1.ToString());
            if (s1.Count > 0)
            {
                if (MessageBox.Show("开始批量上传 ? ", "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)

                {
                    string connectionString = ConfigurationManager.AppSettings["sqlc"];
                    SqlConnection con = new SqlConnection(connectionString);
                    this.progressBar1.Maximum = 10;
                    this.progressBar1.Step = 10 / s1.Count;

                    for (int i = 0; i < s1.Count; i++)
                    {
                        var x = s1[i];
                        string question = "'" + this.dataGridView1.Rows[x].Cells[1].Value.ToString() + "'";
                        string answer = "'" + this.dataGridView1.Rows[x].Cells[2].Value.ToString() + "'";
                        string mtype = "'" + this.dataGridView1.Rows[x].Cells[7].Value.ToString() + "'";
                        string oa = "'" + "无" + "'";
                        string ob = "'" + "无" + "'";
                        string oc = "'" + "无" + "'";
                        string od = "'" + "无" + "'";
                        if (this.dataGridView1.Rows[x].Cells[3].Value != null)
                        {
                            oa = "'" + this.dataGridView1.Rows[x].Cells[3].Value.ToString() + "'";
                        }
                        if (this.dataGridView1.Rows[x].Cells[4].Value != null)
                        {
                            ob = "'" + this.dataGridView1.Rows[x].Cells[4].Value.ToString() + "'";
                        }
                        if (this.dataGridView1.Rows[x].Cells[5].Value != null)
                        {
                            oc = "'" + this.dataGridView1.Rows[x].Cells[5].Value.ToString() + "'";

                        }
                        if (this.dataGridView1.Rows[x].Cells[6].Value != null)
                        {
                            od = "'" + this.dataGridView1.Rows[x].Cells[6].Value.ToString() + "'";
                        }

                        string strcomm = "insert into " + TableName + "([question],[type], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(" +
                 question + ","
                  + mtype + ","
                 + answer + ","
                 + Subtype + ","
                 + oa + ","
                  + ob + ","
                   + oc + ","
                    + od + ")";
                        con.Open();
                        // ff.ShowInfoTip(strcomm);
                        SqlCommand comm = new SqlCommand(strcomm, con);
                        comm.ExecuteNonQuery();
                        this.progressBar1.Value = (i + 1) * this.progressBar1.Step;
                        con.Close();

                    }





                    ff.ShowInfoTip("已更新");

                }

            }
            else
            {
                ff.ShowInfoTip("当前没有选择");
            }


        }
        private Fuc ff = new Fuc();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\

            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                this.textBox1.Text = System.IO.Path.GetFullPath(openFileDialog.FileName);
                var url = this.textBox1.Text.ToString();
                if (!url.Contains("xlsx"))
                {

                    ff.ShowInfoTip("请上传有效文件");
                    return;


                }
                var list = MiniExcel.Query<QuestionA>(url).ToList();


                dataGridView1.DataSource = list;
                row = list.Count;
                if (this.textBox1.Text.Length > 0)
                {

                    this.button1.Text = "上传";
                }

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (all)
            {

                for (int i = 0; i < row; i++)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = "False";


                }
                this.button2.Text = "全选";
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = "True";


                }

                this.button2.Text = "反选";
            }
            all = !all;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

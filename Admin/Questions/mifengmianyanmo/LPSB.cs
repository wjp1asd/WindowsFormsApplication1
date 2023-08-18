using AutoWindowsSize;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Questions.mifengmianyanmo;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.YanMO
{
    public partial class LPSB : Form
    {
        int row;
        String TableName = "ymg";

        Boolean all = false;
        StringBuilder s1;
        public LPSB()
        {
            InitializeComponent();
            string sql = "select * from " + TableName;
            this.panel1.Hide();
            InitTable(sql);
        }
        //List<QuestionA> qs;
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

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);

                string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题

                if (strcolumn == "选取")
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
                this.panel1.Hide();
            }
        }
        private Fuc ff = new Fuc();
        private void button6_Click(object sender, EventArgs e)
        {
            mf f = new mf();
            f.Show();
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Import F10 = new Import("1");
            F10.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from " + TableName;

            this.InitTable(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1) {

            //    string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题
            //    string strrow = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();//获取焦点触发行的第一个值

            //    string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

            //   ff.ShowInfoTip(strcolumn + "" + strrow);

            //}


        }

        private void search(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            s1.Remove(s1.Length - 1, 1);
            // ff.ShowInfoTip(s1.ToString());
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
                    string sql = "select * from " + TableName;

                    this.InitTable(sql);
                }

            }
            else
            {
                ff.ShowInfoTip("当前没有选择");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string question = this.comboBox2.Text.Trim();
            string answer = this.comboBox1.Text.Trim();
            string oa = this.textBox3.Text.Trim();
            string ob = this.textBox4.Text.Trim();
            string oc = this.textBox5.Text.Trim();
            string od = this.textBox6.Text.Trim();

            if (question.Length == 0 || answer.Length == 0 || oa.Length == 0 || ob.Length == 0 ||
                oc.Length == 0 || od.Length == 0
                )
            {
                ff.ShowInfoTip("字段不能为空");
                return;
            }
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into " + TableName + "([image], [answer],[optionA], [optionB], [optionC], [optionD]) VALUES(" +
                "'" + question.ToString() + "'" + "," +
               "'" + answer.ToString() + "'" + "," +
                "'" + oa.ToString() + "'" + "," +
                 "'" + ob.ToString() + "'" + "," +
                  "'" + oc.ToString() + "'" + "," +
                  "'" + od.ToString() + "'" + ")"
              ;
            //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')
            // ff.ShowInfoTip(strcomm);
            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
            string sql = "select * from " + TableName;

            this.InitTable(sql);
            ff.ShowInfoTip("已更新");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            mf f = new mf();
            f.Show();
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        FileSystemInfo[] imgs;
        List<string> urls = new List<string>();

        private void button5_Click_2(object sender, EventArgs e)
        {
            //   string sPath1 = Application.StartupPath + "\\Images\\题库照片\\";
            string sPath1 = loc + "\\题库照片\\";
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            //openFileDialog.SelectedPath = sPath1;

            DirectoryInfo dir = new DirectoryInfo(sPath1);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                imgs = dir.GetFiles();
                foreach (FileSystemInfo item in imgs)
                {
                    urls.Add(item.FullName);
                }     //MessageBox.Show(imgs.Length+"");
                comboBox2.DataSource = urls;


                // this.txtUsername.Text = System.IO.Path.GetFullPath(openFileDialog.FileName);
                //var url = this.txtUsername.Text.ToString();

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


        private void StudentSet_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
        string loc = "";
        private void LPSB_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
            this.panel1.Hide();
            loc = ConfigurationManager.AppSettings["loc"];

            this.label6.Text += ":图片必须放在共享路" + loc;
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {


                string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题

                if (strcolumn == "选取")
                {

                    return;
                }
                ff.ShowInfoTip("点击率");
                string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

                this.pictureBox1.LoadAsync(value);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox2.ImageLocation = this.urls[this.comboBox2.SelectedIndex];

        }
    }
}

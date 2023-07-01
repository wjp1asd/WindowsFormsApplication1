using OpenCvSharp;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Questions.mifengmianyanmo;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.YanMO
{
    public partial class XHSB : Form
    {

        int row;
        String TableName = "Aquanfa";

        Boolean all = false;
        StringBuilder s1;


        public XHSB()
        {
            InitializeComponent();
            string sql = "select * from " + TableName;
            this.panel1.Hide();
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
            }
        }
        private Fuc ff = new Fuc();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sub = this.txtUsername.Text.ToString();

            if (sub.Length == 0)
            {
               ff.ShowInfoTip("字段不能为空");
                return;
            }
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into " + TableName + "([subname]) VALUES(" +
                "'" + sub.ToString() + "'"
             + ")"
              ;
            //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')

            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
           ff.ShowInfoTip("已更新");


            string sql = "select * from " + TableName;

            this.InitTable(sql);
            this.panel1.Hide();
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            mf f = new mf();
            f.Show();
            this.Close();
        }

        private void lblUsername_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string sql = "select * from " + TableName + " where  subname  like '%" + this.textBox1.Text + "%'";

            this.InitTable(sql);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void XHSB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }


    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int a = e.RowIndex;
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    //这里可以编写你需要的任意关于按钮事件的操作~
                     string id = dataGridView1.Rows[a].Cells[1].Value.ToString();//获取焦点触发行的第一个值
                    string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题
                                                                                            //  ff.ShowInfoTip("按钮被点击" + strcolumn);
                   
                    if (strcolumn == "选取")
                    {

                        return;
                    }


                    if (strcolumn == "cz")
                    {
                       
                      
                        XHSBAdmin x = new XHSBAdmin(id);
                        x.Show();
                    }

                }
            }
            else
            {

                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // ff.ShowInfoTip(e.RowIndex.ToString());
    }

}


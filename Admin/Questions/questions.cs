using OpenCvSharp.MachineLearning;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Questions.jiaoyangongyi;
using WindowsFormsApplication1.Admin.Questions.mifengmianyanmo;
using WindowsFormsApplication1.Admin.Questions.zaixian;

namespace WindowsFormsApplication1.Questions
{
    public partial class questions : Form
    {
        int row;
        String TableName = "question";
        String Subtype = "1";
        Boolean all = false;
        StringBuilder s1;
        public questions(String subtype)
        {
            InitializeComponent();
            this.uiComboBox1.SelectedIndex = 0;
            switch (subtype) { 
            case "1":
                    this.Text = "离线校验题库";
                    break;
                case "2":
                    this.Text = "在线校验题库";
                    break;
                case "3":
                    this.Text = "校验工艺题库";
                    break;

                case "4":
                    this.Text = "密封面研磨题库";
                    break;
            }
            Subtype = subtype;
            string sql = "select * from " + TableName + " where subid=" + Subtype;
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

                if (strcolumn == "选择")
                {

                    return;
                }
                string strrow = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();//获取焦点触发行的第一个值
                string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//获取焦点触发行的第一个值
                string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

                string strcomm = "update " + TableName + " set " + strcolumn + "='" + value + "'where id = " + id;
                //   MessageBox.Show("已更新");

                con.Open();
                SqlCommand comm = new SqlCommand(strcomm, con);
                comm.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("已更新");
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (Subtype)
            {
                case "1":
                    Offline a = new Offline();
                    a.Show();
                    break;
                case "2":
                    Online a1 = new Online();
                    a1.Show();
                    break;
                case "3":
                    JiaoYan a2 = new JiaoYan();
                    a2.Show();
                    break;

                case "4":
                    mf a3 = new mf();
                    a3.Show();
                    break;
            }


            this.Close();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Import F10 = new Import(Subtype);
            F10.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from " + TableName + " where subId=" + Subtype + " and concat(id,question,answer) like '%" + this.textBox1.Text + "%'";

            this.InitTable(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1) {

            //    string strcolumn = dataGridView1.Columns[e.ColumnIndex].Name.ToString();//获取列标题
            //    string strrow = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();//获取焦点触发行的第一个值

            //    string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值

            //    MessageBox.Show(strcolumn + "" + strrow);

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
               // MessageBox.Show(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                     s1.Append(this.dataGridView1.Rows[i].Cells[1].Value+ "," );
               // }
            }
            if (s1.Length > 0) {

                s1.Remove(s1.Length - 1, 1);
            }
           
          //  MessageBox.Show(s1.ToString());
            if (s1.Length != 0)
            {
                if (MessageBox.Show("确定删除id"+ s1.ToString()+" ? " , "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)

                {

                    string connectionString = ConfigurationManager.AppSettings["sqlc"];
                    SqlConnection con = new SqlConnection(connectionString);



                    string strcomm = "delete from " + TableName + " where id in (" + s1+")";
                    //update FilTer set 列名 = value where id = 3
                    //MessageBox.Show(strcomm);

                    con.Open();
                    SqlCommand comm = new SqlCommand(strcomm, con);
                    comm.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("已删除");
                    string sql = "select * from " + TableName + " where subId=" + Subtype + " and concat(id,question,answer) like '%" + this.textBox1.Text + "%'";

                    this.InitTable(sql);
                }

            }
            else
            {
                MessageBox.Show("当前没有选择");
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
            string question = this.textBox12.Text;
            string answer = this.textBox11.Text;
            string oa = this.textBox10.Text;
            string ob = this.textBox9.Text;
            string oc = this.textBox8.Text;
            string od = this.textBox7.Text;

            if (question.Length == 0 || answer.Length == 0 
                )
            {
                MessageBox.Show("题目或答案不能为空");
                return;
            }
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into " + TableName + "([question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(" +
                "'" + question.ToString() + "'" + ","+
               "'" + answer.ToString() + "'" + "," +
               "'" + Subtype + "'" + "," +
                "'" + oa.ToString() + "'" + "," +
                 "'" +ob.ToString() + "'" + "," +
                  "'" + oc.ToString() + "'" + "," +
                  "'" +  od.ToString() + "'" + ")"
              ;
            //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')
            // MessageBox.Show(strcomm);
            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("已更新");
            this.panel1.Hide();
            string sql = "select * from " + TableName + " where subId=" + Subtype + " and concat(id,question,answer) like '%" + this.textBox1.Text + "%'";

            this.InitTable(sql);
        }

        private void Online_Questions_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.uiComboBox1.SelectedIndex == 1)
            {
                // 判断题

                this.textBox10.Hide();
                this.textBox9.Hide();
                this.textBox8.Hide();
                this.textBox7.Hide();


            }
            else {
                this.textBox10.Show();
                this.textBox9.Show();
                this.textBox8.Show();
                this.textBox7.Show();
            }
        }
    }
}

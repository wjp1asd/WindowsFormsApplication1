using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1
{
    public partial class Record : Form
    {




        string Id = "1";
        public Record(string id)
        {
            InitializeComponent();
            Id = id;
            Initc();

            //this.printDocument1.OriginAtMargins = true;//启用页边距

        }



        public void Initc()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from lxjl where id=" + Id;
            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {




                //this.label1.Text = "编号：" + reader["bianhao"].ToString().Trim();
                this.label40.Text = reader["shiyongdanwei"].ToString().Trim();
                this.label41.Text = reader["shebeidaima"].ToString().Trim();

                justcheck(this.checkBoxw1, reader["w1"].ToString().Trim());
                justcheck(this.checkBoxw2, reader["w2"].ToString().Trim());
                justcheck(this.checkBow3, reader["w3"].ToString().Trim());
                justcheck(this.checkBow4, reader["w4"].ToString().Trim());
                justcheck(this.checkBow5, reader["w5"].ToString().Trim());
                justcheck(this.checkBow6, reader["w6"].ToString().Trim());
                justcheck(this.checkBow7, reader["c1"].ToString().Trim());
                justcheck(this.checkBow8, reader["c2"].ToString().Trim());
                justcheck(this.checkBow9, reader["c3"].ToString().Trim());
                justcheck(this.result, reader["result"].ToString().Trim());
                //     this.checkBoxw1.Checked = reader["shebeidaima"].ToString();

            }

            reader.Close();
            con.Close();

        }

        private void justcheck(CheckBox c, string m)
        {
            if (m == "1")
            {
                c.Checked = true;
            }
            else
            {

                c.Checked = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // rr r = new rr();
            // r.Show();
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }



        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string edly = this.edyl.Text.ToString().Trim();

            string aqf = this.aqfxh.Text.ToString().Trim();
            string zj = this.zj.Text.ToString().Trim(); ;
            string f1 = this.y1.Text.ToString().Trim();
            string f2 = this.y2.Text.ToString().Trim();
            string fs = this.fs.Text.ToString().Trim();
            string jz = this.jz.Text.ToString().Trim();
            string s1 = this.yi1.Text.ToString().Trim();
            string s2 = this.yi2.Text.ToString().Trim();
            string s3 = this.yi3.Text.ToString().Trim();
            string mf = this.mf.Text.ToString().Trim();
            // check box


            //         if (sub.Length == 0 || f0.Length == 0 || f1.Length == 0 ||
            //             f2.Length == 0 || f3.Length == 0 || f4.Length == 0)
            //         {
            //            ff.ShowInfoTip("字段不能为空");
            //             return;
            //         }
            //         string connectionString = ConfigurationManager.AppSettings["sqlc"];
            //         SqlConnection con = new SqlConnection(connectionString);
            //         string strcomm = "insert into " + TableName + "(power,name,bumen,loginid,password,phone,status,confirm) VALUES(2," +
            //             "'" + sub.ToString() + "'" + "," +
            //            "'" + f0.ToString() + "'" + "," +
            //               "'" + f1.ToString() + "'" + "," +
            //                  "'" + f4.ToString() + "'" + "," +
            //"'" + f2.ToString() + "'" + "," +
            //   "'" + status.ToString() + "'" + "," +
            //           "'" + f3.ToString() + "'" + ")"
            //           ;
            //         //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')
            //        ff.ShowInfoTip(strcomm);
            //         con.Open();
            //         SqlCommand comm = new SqlCommand(strcomm, con);
            //         comm.ExecuteNonQuery();

            //         con.Close();
            //        ff.ShowInfoTip("已更新");

        }

        private void checkBoxw1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Offline r = new Offline();
            r.Show();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //打印内容 为 整个Form
            Image myFormImage;
            myFormImage = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(myFormImage);
            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            e.Graphics.DrawImage(myFormImage, 0, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("保存成功");
        }
    }
}

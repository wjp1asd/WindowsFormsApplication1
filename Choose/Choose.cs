using AutoWindowsSize;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class Choose : Form
    {
        private Student st;
        private Fuc fc;
        private QuestionA qa;
        private TestRecord ts;
        String lxques, zxques, gyques, xhques, lpjques, ymgques;
        String qrcode;
        string idcard = "";
        public Choose(string id = "321084199510025536")
        {
            // 身份证ID
            st = new Student(id);
            fc = new Fuc();
            qa = new QuestionA();
            ts = new TestRecord();
            InitializeComponent();
            this.change();
            ff.same(this);
            idcard = id;
            this.uiLabel2.Text = st.Name;

        }
        private Fuc ff = new Fuc();
        public void change()
        {


            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);

            this.button3.Left -= 100;
            this.button7.Left -= 100;
            this.label2.Left -= 100;


        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }



        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  fc.showloading("抽题中");

            // this.Show();
            // 执行抽题

            // 生成考试记录
            this.FormRecord();

        }

        private void FormRecord()
        {
            // 当前日期
            String que = ts.Queuex().ToString();
            String ksdate = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            String ksname = st.Name;
            String ksid = st.ID1;
            String a = fc.Md5(ksdate + ksname + ksid);
            String lxyl = "";
            String zxyl = "";
            //获取最后一个信息和压力数组
            List<decimal> yali = new List<decimal>();
            List<decimal> yali2 = new List<decimal>();
            yali = ts.Yali();
            yali2 = ts.Yali();
            TestRecord t = new TestRecord();
            t = ts.LastRecord();
            decimal max, min;
#pragma warning disable CS0219 // 变量“last”已被赋值，但从未使用过它的值
            decimal last = 0;
#pragma warning restore CS0219 // 变量“last”已被赋值，但从未使用过它的值
#pragma warning disable CS0219 // 变量“last1”已被赋值，但从未使用过它的值
            decimal last1 = 0;
#pragma warning restore CS0219 // 变量“last1”已被赋值，但从未使用过它的值
            decimal cur = 0;
            decimal cur1 = 0;

            max = yali.Max();
            min = yali.Min();

            if (decimal.Parse(t.Lxyl) >= (min + (decimal)0.2))
            {
                cur = decimal.Parse(t.Lxyl) - (decimal)0.2;


            }
            else
            {
                cur = decimal.Parse(t.Lxyl) + (decimal)0.2;

            }


            if (que == "1")
            {
                // 当天第一个
                yali2 = ts.Yali();
                Random random = new Random();
                int start2 = random.Next(0, yali2.Count);
                lxyl = yali2[start2].ToString();

            }
            else
            {
                //不是第一个
                // max 1.3 min 1 上一个 1.2 cur 1.0 那就在 1.0 1.1里选
                if (decimal.Parse(t.Lxyl) > cur)
                {
                    // 删除大于等上次
                    yali2 = ts.Yali();
                    yali2.RemoveAll(x => x >= decimal.Parse(t.Lxyl));
                    Random random = new Random();
                    int start2 = random.Next(0, yali2.Count);
                    lxyl = yali2[start2].ToString();


                }
                else if (decimal.Parse(t.Lxyl) < cur)
                {

                    yali2 = ts.Yali();
                    yali2.RemoveAll(x => x <= decimal.Parse(t.Lxyl));
                    Random random = new Random();
                    int start2 = random.Next(0, yali2.Count);
                    lxyl = yali2[start2].ToString();
                }
            }
            // 在线直接1.0

            string connectionString2 = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con2 = new SqlConnection(connectionString2);
            string sql2 = "select * from settings where id=1 ";

            SqlCommand com1 = new SqlCommand(sql2, con2);
            con2.Open();
            SqlDataReader reader1 = com1.ExecuteReader();
            while (reader1.Read())
            {
                zxyl = reader1["edyl"].ToString();
            }


            //MessageBox.Show("压力大：" + yali.Max());
            //MessageBox.Show("压力小：" + yali.Min());

            //MessageBox.Show("上一个离线压力：" + t.Lxyl);
            //MessageBox.Show("上一个在线压力：" + t.Zxyl);
            //MessageBox.Show("实际1：" + cur);
            //MessageBox.Show("实际2：" + cur1);

            //MessageBox.Show("离线压力：" + lxyl);
            //  MessageBox.Show("在线压力：" + zxyl);





            //MessageBox.Show("排队号：" + que);
            //MessageBox.Show("考试日期：" + ksdate);
            //MessageBox.Show("考试姓名：" + ksname);
            //MessageBox.Show("身份证：" + ksid);
            //MessageBox.Show("二维码：" + a);
            //MessageBox.Show("压力大：" + yali.Max());
            //MessageBox.Show("压力小：" + yali.Min());
            //MessageBox.Show("上一个离线压力：" + t.Lxyl);
            //MessageBox.Show("上一个在线压力：" + t.Zxyl);
            //MessageBox.Show("离线压力：" + lxyl);
            //MessageBox.Show("在线压力：" + zxyl);

            //MessageBox.Show("在线题：" + zxques);
            //MessageBox.Show("离线题：" + lxques);

            String lxlx = ts.Wucha();
            String zxlx = ts.Wucha();
            String aqfxh = ts.Aqf();
            String aqfxhid = "-1";
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top 1  * from Aquanfa order by newid()";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                aqfxh = reader["subname"].ToString();
                aqfxhid = reader["id"].ToString();
            }

            con.Close();

            lxques = qa.ChooseLixian();
            zxques = qa.ChooseZaixian();
            xhques = qa.ChooseXH(aqfxhid);
            gyques = qa.ChooseJiaoYan();
            lpjques = qa.ChooseLPJ();
            ymgques = qa.ChooseYMG();
            //MessageBox.Show("在线题：" + zxques);
            //MessageBox.Show("离线题：" + lxques);
            //MessageBox.Show("型号题：" + xhques);
            //MessageBox.Show("工艺题：" + gyques);
            //MessageBox.Show("零配件题：" + lpjques);
            //MessageBox.Show("研磨题：" + ymgques);

            string strcomm = "insert into TestRecord([queue], [ksname], [ksid],[ksdate], [lxyl], [lxlx], [zxyl], [zxlx],[aqfxh],[qrcode],[lxquestions],[zxquestions],[gyquestions],[xhquestions],[lpjquestions],[ymgquestions]) VALUES(" +
               "'" + que.ToString() + "'" + "," +
              "'" + ksname.ToString() + "'" + "," +
              "'" + ksid.ToString() + "'" + "," +
                "'" + ksdate.ToString() + "'" + "," +
                "'" + lxyl.ToString() + "'" + "," +
                "'" + lxlx.Trim().ToString() + "'" + "," +
                  "'" + 1.0 + "'" + "," +
                    "'" + zxlx.Trim().ToString() + "'" + "," +
                      "'" + aqfxh.Trim().ToString() + "'" + "," +
                "'" + a.ToString() + "'" + "," +
                 "'" + lxques.ToString() + "'" + "," +
                  "'" + zxques.ToString() + "'" + "," +
                  "'" + gyques.ToString() + "'" + "," +
                  "'" + xhques.ToString() + "'" + "," +
                  "'" + lpjques.ToString() + "'" + "," +
                  "'" + ymgques.ToString() + "'" +
                  ")"
              ;
            //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')
            // ff.ShowInfoTip(strcomm);
            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
            ff.ShowInfoTip("已创建考试信息，排队号0" + que);
            qrcode = a;
            //生成考试清单
            ff.formGrade(qrcode, ksname, ksid);
            Print p = new Print(qrcode);
            p.Show();

            // String sql1 = "select * from Grade where testid like  '%" + this.textBox1.Text.Trim().Substring(0, 20) + "%'";
            this.Close();

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print p = new Print(qrcode);
            p.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form1 f = new form1();
            f.Show();
            this.Close();
        }
    }
}

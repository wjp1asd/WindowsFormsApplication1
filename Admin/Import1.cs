using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Admin
{
    public partial class Import1 : Form
    {
        public Import1()
        {
            InitializeComponent();

            this.uiButton3.Enabled = false;
        }
        List<batch> bb = new List<batch>();
        List<batch1> bb1 = new List<batch1>();
        Api api = new Api();

        private void uiButton2_Click(object sender, EventArgs e)
        {

            xmLprase(api.queryNjScpc(data));
        }

        private void xmLprase(string a)
        {
            XmlDocument doc = new XmlDocument();
            MessageBox.Show(a);
            try
            {
                //返回信息节点
                doc.LoadXml(a);

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

                nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
                nsmgr.AddNamespace("ns1", "http://webservice.jerry.com");
                nsmgr.AddNamespace("resultList", "http://webservice.jerry.com");
                nsmgr.AddNamespace("ns1", "http://webservice.jerry.com");
                XmlNode result = doc.SelectSingleNode("//soap:Envelope//soap:Body//ns1:queryNjScpcResponse//ns1:out", nsmgr);

                // 1是返回文本 2 是考生信息 3批量数量
                string message = result.ChildNodes[1].InnerText;


                MessageBox.Show(message + "" + result.ChildNodes[3].InnerText + "条");

                XmlNode res = result.ChildNodes[2];
                batch b = new batch();
                foreach (XmlNode node in res.ChildNodes)
                {
                    string bzr = node.ChildNodes[0].InnerText;
                    string kssj = node.ChildNodes[2].InnerText;
                    string pcid = node.ChildNodes[3].InnerText;
                    string pclx = node.ChildNodes[4].InnerText;
                    string pcmc = node.ChildNodes[5].InnerText;

                    b.kssj = kssj;
                    b.pcid = pcid;
                    b.pclx = pclx;
                    b.pcmc = pcmc;
                    b.bzr = bzr;
                    bb.Add(b);

                }
                this.RefreshCom();
                this.uiButton3.Enabled = true;

            }
            catch (Exception e)
            {
                //显示错误信息
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }


        }

        private void RefreshCom()
        {
            List<string> ports = new List<string>();
            foreach (var item in bb)
            {
                ports.Add(item.pcid.ToString().Trim());
            }
            this.uiComboBox1.DataSource = ports;
            // this.uiComboBox1.DataSource = null;
        }

        private void xmLprase1(string a)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(a);
            XmlNamespaceManager nsmgr1 = new XmlNamespaceManager(doc.NameTable);

            nsmgr1.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            nsmgr1.AddNamespace("ns1", "http://webservice.jerry.com");
            nsmgr1.AddNamespace("resultList", "http://webservice.jerry.com");
            nsmgr1.AddNamespace("ns1", "http://webservice.jerry.com");
            try
            {
                //返回信息节点

                XmlNode result = doc.SelectSingleNode("//soap:Envelope//soap:Body//ns1:queryNjScpcInfoResponse//ns1:out", nsmgr1);

                // 1是返回文本 2 是考生信息 3批量数量
                string message = result.ChildNodes[1].InnerText;




                XmlNode res = result.ChildNodes[2];
                MessageBox.Show(message + "" + res.ChildNodes.Count + "条");
                foreach (XmlNode node in res.ChildNodes)
                {
                    batch1 b1 = new batch1();

                    string bmsqid = node.ChildNodes[0].InnerText;


                    string mc = node.ChildNodes[1].InnerText;
                    string pcmc = node.ChildNodes[2].InnerText;
                    string scpc = node.ChildNodes[3].InnerText;
                    string sfz = node.ChildNodes[4].InnerText;
                    string zkzh = node.ChildNodes[5].InnerText;
                    string zyxm = node.ChildNodes[6].InnerText;
                    b1.scpc = scpc;
                    b1.pcmc = pcmc;
                    b1.sfz = sfz;
                    b1.zkzh = zkzh;
                    b1.bmsqid = bmsqid;
                    b1.zyxm = zyxm;

                    b1.mc = mc;
                    bb1.Add(b1);

                }
                this.RefreshTable();

            }
            catch (Exception e)
            {
                //显示错误信息
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }

        }

        private void RefreshTable()
        {
            // var list = this.bb1 ;
            // MessageBox.Show(""+bb1.Count);
            for (int i = 0; i < bb1.Count; i++)
            {
                this.dataGridView1.RowCount++;
                this.dataGridView1.Rows[i].Cells[1].Value = bb1[i].bmsqid;
                this.dataGridView1.Rows[i].Cells[2].Value = bb1[i].scpc;
                this.dataGridView1.Rows[i].Cells[3].Value = bb1[i].pcmc;
                this.dataGridView1.Rows[i].Cells[4].Value = bb1[i].mc;
                this.dataGridView1.Rows[i].Cells[5].Value = bb1[i].sfz;
                this.dataGridView1.Rows[i].Cells[6].Value = bb1[i].zkzh;
                this.dataGridView1.Rows[i].Cells[7].Value = bb1[i].zyxm;

            }

            row = this.bb1.Count;
        }
        TestRecord ts = new TestRecord();
        private void FormRecord(string ksname ,string ksid,string a)
        {
            // 当前日期
            String que = ts.Queuex().ToString();
            String ksdate = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            
           
           
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
            QuestionA qa = new QuestionA();
            con.Close();
          string  lxques = "已禁用";
          string  zxques = "已禁用";
          string  gyques = "已禁用";
            //  lxques = qa.ChooseLixian();
            // zxques = qa.ChooseZaixian();
          string  xhques = qa.ChooseXH(aqfxhid);
            // gyques = qa.ChooseJiaoYan();
            string lpjques = qa.ChooseLPJ();
            string ymgques = qa.ChooseYMG();
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
           ff.ShowInfoTip(strcomm);
            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
            ff.ShowInfoTip("已创建考试信息，排队号0" + que);
          
            //生成考试清单
            ff.formGrade(a, ksname, ksid);
         

        }
        private void uiButton3_Click(object sender, EventArgs e)
        {
            xmLprase1(api.queryNjScpcInfo(this.uiComboBox1.Text.Trim()));
        }

        private void Import1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-mmmm-dddd";
        }
        int row;
        Boolean all = false;
        private List<int> s1;

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

        private void uiButton1_Click(object sender, EventArgs e)
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


                    for (int i = 0; i < s1.Count; i++)
                    {
                        var x = s1[i];
                        var sub = this.dataGridView1.Rows[x].Cells[4].Value;
                        var f0 = "上海特检院";
                        var f1 = this.dataGridView1.Rows[x].Cells[5].Value;
                        var f6 = this.dataGridView1.Rows[x].Cells[6].Value;
                        var f4 = "-1";
                        var f2 = "-1";
                        var f3 = this.dateTimePicker1.Value;
                        var bmsqid = this.dataGridView1.Rows[x].Cells[1].Value;
                        var scpc = this.dataGridView1.Rows[x].Cells[2].Value;
                        var status = 1;
                        if (ff.RC1("select * from student where idcard =" + f1).Length>1)
                        {
                            ff.ShowInfoTip("已存在");
                            if (ff.RC1("select * from testrecord where [qrcode] = '" + f6+"'").Length == 0)
                            {

                                FormRecord(sub.ToString(), f1.ToString(), f6.ToString());
                            }
                          
                         //   FormRecord(sub.ToString(), f1.ToString(), f6.ToString());
                        }
                        else
                        {

                            string strcomm = "insert into " + "Student" + "(loginid,password,power,name,bumen,idcard,sex,phone,status,date) VALUES("+
                                 "'" + bmsqid.ToString() + "'" + "," +
                                   "'" + scpc.ToString() + "'" + "," +
                                "1," +
                             "'" + sub.ToString() + "'" + "," +
                            "'" + f0.ToString() + "'" + "," +
                               "'" + f1.ToString() + "'" + "," +
                                  "'" + f4.ToString() + "'" + "," +
                           "'" + f2.ToString() + "'" + "," +
                   "'" + status.ToString() + "'" + "," +
                           "'" + f3.ToString() + "'" + ")";
                            con.Open();
                            // ff.ShowInfoTip(strcomm);
                            SqlCommand comm = new SqlCommand(strcomm, con);
                            comm.ExecuteNonQuery();
                            ff.ShowInfoTip("已更新");
                            con.Close();
                            if (ff.RC1("select * from testrecord where [qrcode] = '" + f6 + "'").Length == 0)
                            {

                                FormRecord(sub.ToString(), f1.ToString(), f6.ToString());
                            }

                        }


                    }
                }
            }
        }
        Fuc ff = new Fuc();
        string data = "2023-09-04";
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dateTimePicker1.Value.Year+"-"+ this.dateTimePicker1.Value.Month
            //    +"-"+ this.dateTimePicker1.Value.Day);
            data = this.dateTimePicker1.Value.Year + "-" + this.dateTimePicker1.Value.Month
                + "-" + this.dateTimePicker1.Value.Day;
        }
    }
}
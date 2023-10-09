using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
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
                        var f4 = "-1";
                        var f2 = "-1";
                        var f3 = this.dateTimePicker1.Value;
                        var status = 1;
                        if (ff.RC1("select * from student where idcard =" + f1).Length>1)
                        {
                            ff.ShowInfoTip("已存在");
                        }
                        else
                        {

                            string strcomm = "insert into " + "Student" + "(loginid,password,power,name,bumen,idcard,sex,phone,status,date) VALUES(-1,-1,1," +
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
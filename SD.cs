using System;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class SD : Form
    {
        private XmlNamespaceManager nsmgr;

        public SD()
        {
            InitializeComponent();
        }
        Api api = new Api();
        private void button1_Click(object sender, EventArgs e)
        {

            //this.richTextBox1.Text= api.queryNjScpc();
            // 解析
            xmLprase(api.queryNjScpc());
        }

        private void xmLprase(string a)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(a);
            nsmgr =new XmlNamespaceManager(doc.NameTable);

            nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            nsmgr.AddNamespace("ns1", "http://webservice.jerry.com");
            nsmgr.AddNamespace("resultList", "http://webservice.jerry.com");
            nsmgr.AddNamespace("ns1", "http://webservice.jerry.com");
            try
            {
                //返回信息节点

                XmlNode result = doc.SelectSingleNode("//soap:Envelope//soap:Body//ns1:queryNjScpcResponse//ns1:out", nsmgr);

                // 1是返回文本 2 是考生信息 3批量数量
                string message = result.ChildNodes[1].InnerText;


                MessageBox.Show(message+""+ result.ChildNodes[3].InnerText + "条");

                XmlNode res = result.ChildNodes[2];

                foreach (XmlNode node in res.ChildNodes)
                {


                    //< bzr > zhouyp </ bzr >
                    //   < kcdz > test </ kcdz >
                    //   < kssj > 2023 - 09 - 04T00: 00:00 + 08:00 </ kssj >
                    //   < pcid > 26256 </ pcid >
                    //   < pclx > 实操考试 </ pclx >
                    //   < pcmc > K04F2309041 </ pcmc >
                    string bzr = node.ChildNodes[0].InnerText;


                    string kssj = node.ChildNodes[2].InnerText;
                    string pcid = node.ChildNodes[3].InnerText;
                    string pclx = node.ChildNodes[4].InnerText;
                    string pcmc = node.ChildNodes[5].InnerText;
                    this.richTextBox1.Text += "批次号："+pcid+"考试时间："+kssj;
                    this.richTextBox1.Text += "批次类型：" + pclx + "批次名称：" + pcmc;
                    this.richTextBox1.Text += "\r\n";
                }


            }
            catch (Exception e)
            {
                //显示错误信息
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
            // MessageBox.Show(doc.OuterXml);
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


                MessageBox.Show(message + "" + result.ChildNodes[3].InnerText + "条");

                XmlNode res = result.ChildNodes[2];

                foreach (XmlNode node in res.ChildNodes)
                {


                    string bmsqid = node.ChildNodes[0].InnerText;


                    string mc = node.ChildNodes[1].InnerText;
                    string pcmc = node.ChildNodes[2].InnerText;
                    string scpc = node.ChildNodes[3].InnerText;
                    string sfz = node.ChildNodes[4].InnerText;
                    string zkzh = node.ChildNodes[5].InnerText;
                    string zyxm = node.ChildNodes[6].InnerText;

                    this.richTextBox2.Text += "考生内部号：" + bmsqid + "姓名：" + mc;
                    this.richTextBox2.Text += "批次类型：" + scpc + "批次名称：" + pcmc;

                    this.richTextBox2.Text += "身份证：" + sfz + "准考证：" + zkzh;
                    //    this.richTextBox2.Text += "批次类型：" + scpc + "批次名称：" + pcmc;
                    this.richTextBox2.Text += "\r\n";
                }


            }
            catch (Exception e)
            {
                //显示错误信息
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
            // MessageBox.Show(doc.OuterXml);
        }
        private void SD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            xmLprase1(api.queryNjScpcInfo(this.textBox1.Text.Trim()));
        }
    }
}

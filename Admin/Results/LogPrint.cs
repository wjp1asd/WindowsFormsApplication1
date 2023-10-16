using AutoWindowsSize;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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

   

            


       
           // row=1;
            for(int i=0;i<row;i++)
            {
                Kfitems ks = new Kfitems();
                ks.itemname=this.dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
                ks.kfdm=this.dataGridView1.Rows[i].Cells[2].Value.ToString().Trim(); 
                ks.kffz=this.dataGridView1.Rows[i].Cells[3].Value.ToString().Trim(); 
               ks.kfsj=this.dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
             //   ks.kfsj="2023-09-09";
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
        private void xmLprase(string a)
        {
            XmlDocument doc = new XmlDocument();
          //  MessageBox.Show(a);
            try
            {
                //返回信息节点
                doc.LoadXml(a);

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

                nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
                nsmgr.AddNamespace("ns1", "http://webservice.jerry.com");
                nsmgr.AddNamespace("resultList", "http://webservice.jerry.com");
                nsmgr.AddNamespace("ns1", "http://webservice.jerry.com");
                XmlNode result = doc.SelectSingleNode("//soap:Envelope//soap:Body//ns1:uploadSccjAndKfIetmsInfoResponse//ns1:out", nsmgr);

                // 1是返回文本 2 是考生信息 3批量数量
                string message1 = result.ChildNodes[1].InnerText;
               // string message2 = result.ChildNodes[2].InnerText;
               // string message3 = result.ChildNodes[3].InnerText;
                MessageBox.Show(message1);
             //   MessageBox.Show(message2);
              //  MessageBox.Show(message3);

            }
            catch (Exception e)
            {
                //显示错误信息
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
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
            Student sc=new Student(t.KsId); 
            
            fz= g.getGrade("path", uid);
            string listarry = "";
            
            foreach (var item in bb)
            {
                string bean = "<bean:KfItems><bean:itemname>"+item.itemname.Trim()+"</bean:itemname>";
                string a1 = "<bean:kfdm>"+item.kfdm.Trim()+"</bean:kfdm>";
                string a2= "<bean:kffz>"+item.kffz.Trim()+"</bean:kffz>";
                string a3 = "<bean:kfsj>"+item.kfsj.Trim()+"</bean:kfsj>";
                string end = "</bean:KfItems>";
                listarry +=bean+a1+a2+a3+end;
            }
            //  MessageBox.Show(sc.Name+sc.password+ sc.loginid);
            DateTime d = DateTime.Now;
            string now =d.Year.ToString()+"-"+d.Month.ToString()+"-"+d.Day;
            if (sc.Bumen1=="上海特检院") {
                xmLprase(a.uploadgrade(fz, now, sc.password, sc.loginid, listarry));
            }
          
          
        }
    }
}

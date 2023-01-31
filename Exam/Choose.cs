using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Exam
{
    public partial class Choose : Form
    {
        private Student st;
        private Fuc fc;
        private QuestionA qa;
        private TestRecord ts;
        public Choose(String ID= "123123123")
        {
            // 身份证ID
            st=new Student(ID);
            fc=new Fuc();
            qa=new QuestionA();
            ts=new TestRecord
            InitializeComponent();
            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {
            this.uiLabel2.Text = st.Name;
            this.uiLabel3.Text = st.ID1;
            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);
        }
        private void Choose_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fc.showloading("抽题中");
            // 执行抽题
            qa.ChooseLixian();
            qa.ChooseZaixian();
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
            ////            [Id] INT NOT NULL,
            ////[queue] NCHAR(50) NULL,
            ////[ksname] NCHAR(50) NULL,
            ////[ksdate] NCHAR(50) NULL,
            ////[ksId] NCHAR(50) NULL,
            ////[lxyl] NCHAR(50) NULL,
            ////[lxlx] NCHAR(50) NULL,
            ////[zxyl] NCHAR(50) NULL,
            ////[zxlx] NCHAR(50) NULL,
            ////[aqfxh] NCHAR(50) NULL,
            ////[qrcode] NCHAR(50) NULL,
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into TestRecord([queue], [ksname], [ksid],[ksdate], [lxyl], [lxlx], [zxyl], [zxlx],[aqfxh],[qrcode],[lxquestions],[zxquestions]) VALUES(" +
                "'" + que.ToString() + "'" + "," +
               "'" + ksname.ToString() + "'" + "," +
               "'" + ksid.ToString() + "'" + "," +
                "'" + ksdate.ToString() + "'" + "," +
                 "'" + ob.ToString() + "'" + "," +
                  "'" + oc.ToString() + "'" + "," +
                  "'" + od.ToString() + "'" + ")"
              ;
            //  INSERT INTO[dbo].[question] ([id], [question], [answer], [subId], [optionA], [optionB], [optionC], [optionD]) VALUES(2, N'在SQL Server 2000的安全模型中，提供了“服务器”和（）两种类型的角色。', N'B', 2, N'客户端', N'数据库', N'操作系统', N'数据对象')
            // MessageBox.Show(strcomm);
            con.Open();
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("已更新");
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ID id = new ID();
            id.Show();
            this.Close();
        }
    }
}

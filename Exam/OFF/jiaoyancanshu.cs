using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class jiaoyancanshu : Form
    {
        string index ="";
        public jiaoyancanshu()
        {
            InitializeComponent();
          


        }

        private void wucha(string type)
        {
           Wucha w= new Wucha();
            List<Wucha> wucha = w.GetAll(type);
            List<string> ports =new List<string>();
            foreach (var item in wucha)
            {
                ports.Add(item.Area1.ToString().Trim()) ;
            }
            comboBox1.DataSource=ports;
            comboBox1.SelectedIndex=0;
            index = wucha[comboBox1.SelectedIndex].Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            JiaoYan j = new JiaoYan(index);
            j.Show();
           
        }

        private void jiaoyancanshu_Load(object sender, EventArgs e)
        {
            TestRecord t = new TestRecord();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode='" + datahelp.QId + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                t.Queque = reader["queue"].ToString();

                t.Ksdate = reader["ksdate"].ToString();

                t.Ksname = reader["ksname"].ToString();

                t.KsId = reader["ksId"].ToString();

                t.Lxyl = reader["lxyl"].ToString();

                t.Lxlx = reader["lxlx"].ToString();
                t.Zxyl = reader["zxyl"].ToString();

                t.Zxlx = reader["zxlx"].ToString();



                t.Adfxh = reader["aqfxh"].ToString();

                t.Qrcode = reader["qrcode"].ToString();
            }
            con.Close();
            this.label3.Text = "考生："+t.Ksname;
            this.label4.Text = "身份证：" + t.KsId;
            this.label6.Text = "要求整定压力：" + t.Lxyl+"Mpa";
            this.label5.Text = "使用设备类型：" + t.Lxlx ;
            wucha(t.Lxlx);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

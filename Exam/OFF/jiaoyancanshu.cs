﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class jiaoyancanshu : Form
    {

        public jiaoyancanshu()
        {
            InitializeComponent();



        }
        List<Wucha> wuchas = new List<Wucha>();
        private double yali = 0;
        Grade g = new Grade();

        private void wucha(string type)
        {
            Wucha w = new Wucha();
            wuchas = w.GetAll(type);
            List<string> ports = new List<string>();
            foreach (var item in wuchas)
            {
                ports.Add(item.Value1.ToString().Trim());
            }
            comboBox1.DataSource = ports;
            // MessageBox.Show(type + wuchas.Count);
            //  comboBox1.SelectedIndex=0;
            // index = wuchas[0].Id;
        }
        Fuc ff = new Fuc();
        float score = 0;
        JiaoYan j;
        private void button1_Click(object sender, EventArgs e)
        {
            // 判读选择情况
            //yali


            string a1 = wuchas[comboBox1.SelectedIndex].Min.Trim();
            string b2 = wuchas[comboBox1.SelectedIndex].Max.Trim();

            double a = double.Parse(a1);
            double b = double.Parse(b2);
            yali = double.Parse(this.label1.Text.Trim());


            if (yali < a || yali > b)
            {
                // 其所选不在范围之内 不得分
                score = 0;
                log1.updatelog("离线=误差选择错误，不得分", "lx-wxxz", 0, datahelp.QId);

                if (debug == 1)
                {
                    ff.ShowErrorTip("离线=误差选择错误，不得分");
                }
            }
            else
            {
                if (debug == 1)
                {
                    ff.ShowSuccessTip("选择正确，得分" + score);
                }

                log1.updatelog("离线=误差选择正确得分", "lx-wxxz", score, datahelp.QId);
                int i = g.updateGrade(score, "wxxz", datahelp.QId.Trim());
            }


            //MessageBox.Show(""+ff.RC1(url).Length);

            Action x = () =>
            {
                this.Close();

                // ff.showloading();
                j = new JiaoYan(wuchas[comboBox1.SelectedIndex].Id);
                j.Show();
            };
            this.Invoke(x);

        }
        int debug = 0;
        Log log1 = new Log();
        private void jiaoyancanshu_Load(object sender, EventArgs e)
        {
            TestRecord t = new TestRecord();
            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x) == 1)
            {
                debug = 1;
            }


            g.updateGrade(0, "wxxz", datahelp.QId);
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode='" + datahelp.QId + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                t.Queque = reader["queue"].ToString().Trim();

                t.Ksdate = reader["ksdate"].ToString().Trim();

                t.Ksname = reader["ksname"].ToString().Trim();

                t.KsId = reader["ksId"].ToString().Trim();

                t.Lxyl = reader["lxyl"].ToString().Trim();

                t.Lxlx = reader["lxlx"].ToString().Trim();
                t.Zxyl = reader["zxyl"].ToString().Trim();

                t.Zxlx = reader["zxlx"].ToString().Trim();



                t.Adfxh = reader["aqfxh"].ToString();

                t.Qrcode = reader["qrcode"].ToString();
            }
            con.Close();
            this.label3.Text = "考生：" + t.Ksname;
            this.label4.Text = "身份证：" + t.KsId;
            this.label1.Text = t.Lxyl.Trim();
            ;
            //  yali = int.Parse(t.Lxyl);
            this.label5.Text = "使用设备类型：" + t.Lxlx;
            wucha(t.Lxlx.Trim());
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            Score c = new Score();
            score = c.getScore("lx-wxxz");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button1.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

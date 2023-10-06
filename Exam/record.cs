﻿using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class record : Form
    {


        public record()
        {
            InitializeComponent();
        }
        string tper = "";

        string Id = "1";
        public record(string id, string type = "离线")
        {
            InitializeComponent();
            Id = id;
            tper = type;
            Initc();
            this.label2.Text = type + this.label2.Text;
            this.printDocument1.OriginAtMargins = true;//启用页边距
                                                       // 初始化成绩
            InitScore();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        Score sc = new Score();
        //要求整定压力 公称直径 压力等级范围 第一次 第二次 第三次 密封压力
        float yqzdyl = 0;
        float gctj = 0;
        float yldj = 0;
        float dycyl, decyl, dscyl, mfsyyl = 0;
        float jyjg,jyjg1 = 0;
        //  Grade g = new Grade();
        private void InitScore()
        {
            yqzdyl = sc.getScore("lx-yqzdyl");
            gctj = sc.getScore("lx-gctj");
            yldj = sc.getScore("lx-yldjfw");
            dycyl = sc.getScore("lx-dyiyl");
            decyl = sc.getScore("lx-deryl");
            dscyl = sc.getScore("lx-dsanyl");
            mfsyyl = sc.getScore("lx-mfyl");
            jyjg = sc.getScore("lx-jielun");
            jyjg1 = sc.getScore("zx-jielun");
        //  this.label11.Text = "编号：" + datahelp.QId;
            g.updateGrade(0, "yqzdyl", datahelp.QId);
            g.updateGrade(0, "gctj", datahelp.QId);
            g.updateGrade(0, "dycyl", datahelp.QId);
            g.updateGrade(0, "decyl", datahelp.QId);
            g.updateGrade(0, "dscyl", datahelp.QId);
            g.updateGrade(0, "mfsyyl", datahelp.QId);
            g.updateGrade(0, "jyjg1", datahelp.QId);
            g.updateGrade(0, "jyjg", datahelp.QId);

        }


        public void Initc()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from lxjl where id= 1";
            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {




           //   this.label1.Text = "编号：" + reader["bianhao"].ToString().Trim();
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
                //  justcheck(this.result, reader["result"].ToString().Trim());
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

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            datahelp.CurrentStep1 = 4;

            this.Close();
            if (tper == "离线")
            {
                OFF off = new OFF(datahelp.QId);
                off.Show();

            }
            if (tper == "在线")
            {
                zaixianjiaoyan z = new zaixianjiaoyan();
                z.Show();

            }


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
        Grade g = new Grade();

        private void result_CheckedChanged(object sender, EventArgs e)
        {
            if (this.result.Checked == true)
            {
             
                if (tper == "离线")
                {
                    g.updateGrade(jyjg, "lx-jielun", datahelp.QId);
                    string x = "lx-jielun";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("离线=填写记录-结论得分", x, sc.getScore(x), datahelp.QId);

                }
                if (tper == "在线")
                {
                    g.updateGrade(jyjg1, "zx-jielun", datahelp.QId);
                    string x = "zx-jielun";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-结论得分", x, sc.getScore(x), datahelp.QId);
                }
              
            }

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
        Fuc ff = new Fuc();
        int debug = 0;
        private void record_Load(object sender, EventArgs e)
        {
            //g.getOne(datahelp.QId);
            //this.label1.Text = "编号：" + datahelp.QId;

            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x) == 1)
            {
                debug = 1;
            }
            if (tper == "离线")
            {
                if (g.getGrade("yqzdyl", datahelp.QId) > 100)
                {

                    ff.ShowErrorDialog("重复考试");


                    if (tper == "离线")
                    {
                        OFF off = new OFF(datahelp.QId);
                        off.Show();
                        datahelp.CurrentStep1 = 4;
                    }
                    if (tper == "在线")
                    {
                        zaixianjiaoyan z = new zaixianjiaoyan();
                        z.Show();
                        datahelp.CurrentStep1 = 4;
                    }

                    this.Close();

                }

                g.updateGrade(0, "yqzdyl", datahelp.QId);


            }
            else
            {


            }
            pp = p.getAll();
            //

            t = t.getRecord(datahelp.QId);

            foreach (var p in pp)
            {
                if (double.Parse(t.Lxyl) == p.f0)
                {
                    // 离线压力等于
                    ap = p;

                }

                if (double.Parse(t.Zxyl) == p.f0)
                {
                    // 在线压力等于

                    ap = p;
                }



            }
        }
        pressure p = new pressure();
        pressure ap = new pressure();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }


        Log Log1 = new Log();
        List<pressure> pp = new List<pressure>();
        TestRecord t = new TestRecord();
        private void button2_Click(object sender, EventArgs e)
        {
            if (tper == "离线")
            {
                double f1 = double.Parse(this.yi1.Text.Trim());
                double f2 = double.Parse(this.yi2.Text.Trim());
                double f3 = double.Parse(this.yi3.Text.Trim());
                double mf = double.Parse(this.mf.Text.Trim());
                 MessageBox.Show(f1 + "-" + f2 + "-" + f3 + "-" + mf + "a" + ap.f1 + "a" + ap.f2 + "a" + ap.f3 + "a" + ap.f0 * 0.9);
                if (f1 == ap.f1)
                {
                    g.updateGrade(dycyl, "dycyl", datahelp.QId);
                }
                if (f2 == ap.f2)
                {
                    g.updateGrade(decyl, "decyl", datahelp.QId);
                }
                if (f3 == ap.f3)
                {
                    g.updateGrade(dscyl, "dscyl", datahelp.QId);
                }
                if (mf == ap.f0 * 0.9)
                {
                    g.updateGrade(mfsyyl, "mfsyyl", datahelp.QId);
                }

            }
            else {
                // 在线记录 
                //public float zxzdyl, zxgczj, zxyldjfw, zxdyiyl, zxderyl, zxdsanyl, zxjielun;
                if (debug == 1)
                {
                    MessageBox.Show(edyl.Text.Trim() + "==" + t.Zxyl);
                    MessageBox.Show(zj.Text.Trim() + "==" + "50");
                    MessageBox.Show(datahelp.f1 + "==" + yi1.Text.Trim());
                    MessageBox.Show(datahelp.f2 + "==" + yi2.Text.Trim());
                    MessageBox.Show(datahelp.f3 + "==" + yi3.Text.Trim());
                    MessageBox.Show(y1.Text.Trim() + "==" + "1");
                    MessageBox.Show(y2.Text.Trim() + "==" + "1.3");

                }
             
                if (edyl.Text.Trim() ==t.Zxyl.Trim()|| edyl.Text.Trim()=="1.0")
                {
                 
                    string x = "zx-zdyl";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-整定压力得分", x,sc.getScore(x), datahelp.QId);
                }
                else {
                    string x = "zx-zdyl";
                    g.updateGrade(0, x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-整定压力错误不得分", x,0, datahelp.QId);
                }

                if (zj.Text.Trim() == "50")
                {
                    string x = "zx-gczj";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-公称通径得分", x, sc.getScore(x), datahelp.QId);
                }
                else {
                    string x = "zx-gczj";
                    g.updateGrade(0, x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-公称通径错误不得分", x, 0, datahelp.QId);

                           }

                if (datahelp.f1 == yi1.Text.Trim())
                {
                    string x = "zx-dyiyl";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-第一次压力得分", x, sc.getScore(x), datahelp.QId);
                }
                else
                {
                    string x = "zx-dyiyl";
                    g.updateGrade(0, x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-第一次压力错误不得分", x, 0, datahelp.QId);

                }
                if (datahelp.f2 == yi2.Text.Trim())
                {
                    string x = "zx-deryl";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-第二次压力得分", x, sc.getScore(x), datahelp.QId);
                }
                else
                {
                    string x = "zx-deryl";
                    g.updateGrade(0, x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-第二次压力错误不得分", x, 0, datahelp.QId);

                }

                if (datahelp.f3 == yi3.Text.Trim())
                {
                    string x = "zx-dsanyl";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-第三次压力得分", x, sc.getScore(x), datahelp.QId);
                }
                else
                {
                    string x = "zx-dsanyl";
                    g.updateGrade(0, x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-第三次压力错误不得分", x, 0, datahelp.QId);

                }

                if (
                    y1.Text.Trim()=="1.0"&&y2.Text.Trim()=="1.3"
                    )
                {
                    string x = "zx-yldjfw";
                    g.updateGrade(sc.getScore(x), x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-压力等级范围得分", x, sc.getScore(x), datahelp.QId);
                }
                else
                {
                    string x = "zx-yldjfw";
                    g.updateGrade(0, x, datahelp.QId);
                    Log1.updatelog("在线=填写记录-压力等级范围错误不得分", x, 0, datahelp.QId);

                }



            }


            this.ShowSuccessDialog("保存成功");

        }
    }
}


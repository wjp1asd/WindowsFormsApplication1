﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Scan;

namespace WindowsFormsApplication1
{
    public partial class ProjectInfo : Form
    {
        string set1 = "";
        public ProjectInfo(string set="")
        {
            set1 = set; 
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        Grade g = new Grade();
        private void Form7_Load(object sender, EventArgs e)
        {
            g.getOne(datahelp.QId);
            string x = ConfigurationManager.AppSettings["machine"];
            switch (int.Parse(x))
            {
                case 2:
                    //离线得分
                    if (set1.Length > 0)
                    {
                        this.label2.Text = "离线得分:" + set1;
                    }
                    else {
                        this.label2.Text = "离线得分:" + g.lxtotal;
                    }
                  
                    break;
                case 3:
                    //在线得分
                    //this.label2.Text = "得分:" +(g.wxxz1 + g.azfm1 + g.mfzjcl+g.cxfm1+
                    //        g.zxderyl+g.zxdsanyl+g.zxjielun+g.gctj+g.zxzdyl+g.zxyldjfw+g.zxjielun);
                    if (set1.Length > 0)
                    {
                        this.label2.Text = "在线得分:" + set1;
                    }
                    else {
                        this.label2.Text = "在线得分:" + g.zxtotal;

                    }
                   
                    break;
                case 4:
                    // 密封总得分
                    // this.label2.Text = "得分:" + (g.score4 + g.score5 + g.score6+g.score8);
                    this.label2.Text = "密封得分:" +g.mftotal;

                    break;
                case -1:
                    //  datahelp.CurrentStep = 3;
                    this.label2.Text = "总得分:" +g.mftotal+g.lxtotal+g.zxtotal;
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            string x = ConfigurationManager.AppSettings["machine"];
            if (int.Parse(x) < 2)
            {
                form1 c = new form1();
                c.Show();
            }
            else
            {
                ScanLogin p = new ScanLogin();
                p.Show();
            }
           //开启新的实例  
System.Diagnostics.Process.Start(Application.ExecutablePath);
            //关闭当前实例    
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();//退出当前项目，如果是子项目，则不会停止主项目
            System.Environment.Exit(0);//停止所有项目

          //  Application.Restart();
           // Process.GetCurrentProcess()?.Kill();
        }
    }
}

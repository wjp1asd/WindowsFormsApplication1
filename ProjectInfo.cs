using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam.MF;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Scan;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class ProjectInfo : Form
    {
        public ProjectInfo()
        {
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
                    this.label2.Text = "离线得分:" +g.lxtotal;
                    break;
                case 3:
                    //在线得分
                //this.label2.Text = "得分:" +(g.wxxz1 + g.azfm1 + g.mfzjcl+g.cxfm1+
                //        g.zxderyl+g.zxdsanyl+g.zxjielun+g.gctj+g.zxzdyl+g.zxyldjfw+g.zxjielun);

                    this.label2.Text = "在线得分:" +g.zxtotal;
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
            this.Close();
            string x = ConfigurationManager.AppSettings["machine"];
            if (int.Parse(x) < 2)
            {
             form1 c =new form1();
                c.Show();
            }
            else
            {
                ScanLogin p = new ScanLogin();
                p.Show();
            }

             Application.Restart();
             Process.GetCurrentProcess()?.Kill();
        }
    }
}

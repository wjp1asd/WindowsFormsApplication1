using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Questions.jiaoyangongyi;
using WindowsFormsApplication1.Admin.Questions.mifengmianyanmo;
using WindowsFormsApplication1.Admin.Questions.zaixian;
using WindowsFormsApplication1.Questions;
using WindowsFormsApplication1.YanMO;

namespace WindowsFormsApplication1
{
    public partial class QuestionSet : Form
    {
        public QuestionSet()
        {
            InitializeComponent();
            InitUI();

        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button4.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);

         



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Offline f = new Offline();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Online f1 = new Online();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JiaoYan j = new JiaoYan();
            j.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          mf mf = new mf();

           mf.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminIndex a = new AdminIndex();
            a.Show();
            this.Close();

        }

        private void QuestionSet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Questions.jiaoyangongyi;
using WindowsFormsApplication1.Admin.Questions.mifengmianyanmo;
using WindowsFormsApplication1.Admin.Questions.zaixian;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Questions;

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



            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button4.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //   ff.ShowInfoTip(a.color1);


            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);

            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button4, this);

            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);
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

        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }

        private void QuestionSet_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }


    }
}

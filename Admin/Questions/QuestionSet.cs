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
            ff.same(this);
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


            ff.button(this.button1);
          
            ff.button(this.button3);
            ff.button(this.button4);

            ff.button(this.button7);
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
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        private void QuestionSet_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }


    }
}

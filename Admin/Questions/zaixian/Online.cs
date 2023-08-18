using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Questions.jiaoyangongyi;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Admin.Questions.zaixian
{
    public partial class Online : Form
    {
        public Online()
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
            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //   ff.ShowInfoTip(a.color1);



            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.button2, this);
            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuestionSet s = new QuestionSet();
            s.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questions q = new questions("2");
            q.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Online_JiaoYan a = new Online_JiaoYan();
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
        private void Online_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.SizeChanged += groupBox1_Resize;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JiaoYan a = new JiaoYan();
            a.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            JiaoYan a = new JiaoYan();
            a.Show();
            this.Close();
        }
    }
}

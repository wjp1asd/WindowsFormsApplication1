using AutoWindowsSize;
using System;
using System.Configuration;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam.MF
{
    public partial class MF1 : Form
    {
        public MF1()
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

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button4.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button5.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);



            //this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen1(this.button1, this);
            ff.fullsreen1(this.button2, this);
            ff.fullsreen1(this.button3, this);
            ff.fullsreen1(this.button4, this);
            ff.fullsreen1(this.button5, this);
            ff.fullsreen1(this.label2, this);
        }
        Grade g = new Grade();
        private void button3_Click(object sender, EventArgs e)
        {
            // 型号识别
            float a = g.getGrade("score4", datahelp.QId);
            if (a > -1&&debug!=1)
            {

                ff.ShowErrorDialog("重复考试");
                datahelp.CurrentStep = 2;
                datahelp.CurrentStep1 = 2;
                this.refreshButton();
                return;
            }
            datahelp.SubId = 5;
            XHForm x = new XHForm(datahelp.QId);
            x.Show();
            this.Close();
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {

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
        int debug = 0;
        private void ON_Load(object sender, EventArgs e)
        {
            // ff.ShowInfoTip(datahelp.CurrentStep+"+");
            refreshButton();
            // 测试模式
            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x)==1)
            {
                debug = 1;
            }


            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void refreshButton()
        {
            switch (datahelp.CurrentStep)
            {
                case 1:

                    this.button3.Enabled = true;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button4.Enabled = false;
                    this.button5.Enabled = false;
                    break;
                case 2:
                    this.button3.Enabled = false;
                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                    this.button4.Enabled = false;
                    this.button5.Enabled = false;
                    break;
                case 3:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = true;
                    this.button4.Enabled = false;
                    this.button5.Enabled = false;
                    break;
                case 5:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button4.Enabled = true;
                    this.button5.Enabled = false;
                    break;
                case 4:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button5.Enabled = true;
                    this.button4.Enabled = false;
                    break;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datahelp.SubId = 2;
            zaixianjiaoyan a = new zaixianjiaoyan();
            a.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 零配件识别
            float a = g.getGrade("score5", datahelp.QId);
            if (a > -1 && debug != 1)
            {

                ff.ShowErrorDialog("重复考试");
                datahelp.CurrentStep = 3;

                this.refreshButton();
                return;
            }
            datahelp.SubId = 6;

            LBJForm lBJ = new LBJForm(datahelp.QId);
            lBJ.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 研磨识别
            float a1 = g.getGrade("score5", datahelp.QId);
            if (a1 > -1 && debug != 1)
            {

                ff.ShowErrorDialog("重复考试");
                datahelp.CurrentStep = 4;

                this.refreshButton();
                return;
            }
            datahelp.SubId = 4;
            QuestionForm a = new QuestionForm(datahelp.QId, "4");
            a.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ProjectInfo projectInfo = new ProjectInfo();
            projectInfo.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            float a = g.getGrade("score8", datahelp.QId);
            if (a > -1 && debug != 1)
            {

                ff.ShowErrorDialog("重复考试");
                datahelp.CurrentStep = 5;

                this.refreshButton();
                return;
            }
            this.Close();
            MFYM mf = new MFYM(datahelp.QId);
            mf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ff.backlogin();
        }
    }
}

using AutoWindowsSize;
using System;
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


            this.label2.Text = "在线校验";



            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.button2, this);
            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button4, this);
            ff.fullsreen(this.button5, this);
            ff.fullsreen(this.label2, this);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 型号识别
            this.Close();
            datahelp.SubId = 5;
            XHForm x = new XHForm(datahelp.QId);
            x.Show();
            // QuestionForm a = new QuestionForm(datahelp.QId, "5");
            //  a.Show();
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {

        }



        private void ON_Load(object sender, EventArgs e)
        {
          // ff.ShowInfoTip(datahelp.CurrentStep+"+");
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

            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datahelp.SubId = 2;
            zaixianjiaoyan a = new zaixianjiaoyan();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 零配件识别
            this.Close();
            datahelp.SubId = 6;
            LBJForm lBJ = new LBJForm(datahelp.QId);
            lBJ.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 研磨识别
            datahelp.SubId = 4;
            QuestionForm a = new QuestionForm(datahelp.QId, "4");
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectInfo projectInfo = new ProjectInfo();
            projectInfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MFYM mf = new MFYM(datahelp.QId);
            mf.Show();  
        }
    }
}

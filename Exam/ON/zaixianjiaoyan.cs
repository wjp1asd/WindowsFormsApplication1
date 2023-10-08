using AutoWindowsSize;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class zaixianjiaoyan : Form
    {
        public zaixianjiaoyan()
        {
            InitializeComponent();
            InitUI();
            ff.same(this);
          
           
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
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.label2.Focus();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button4.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);



            this.label2.Text = "在线校验";

          

            // this.change();
         
        }
        zaixianjiaoyan2 z;
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.button2, this);
            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.button4, this);


            ff.fullsreen(this.label2, this);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 在线题 开始考试
            datahelp.SubId = 2;
            QuestionForm a = new QuestionForm(datahelp.QId, "2");
            a.Show();
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }

        private void refreshButton()
        {
            switch (datahelp.CurrentStep1)
            {
                case 1:

                    this.button3.Enabled = true;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button4.Enabled = false;

                    break;
                case 2:
                    this.button3.Enabled = false;
                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                    this.button4.Enabled = false;
                    break;
                case 3:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = true;
                    this.button4.Enabled = false;
                    break;
                case 4:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button4.Enabled = true;
                    break;

            }
        }

        private void zaixianjiaoyan_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.空白界面副本;
          
            switch (datahelp.CurrentStep1)
            {
                case 1:

                    this.button3.Enabled = true;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button4.Enabled = false;

                    break;
                case 2:
                    this.button3.Enabled = false;
                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                    this.button4.Enabled = false;
                    break;
                case 3:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = true;
                    this.button4.Enabled = false;
                    break;
                case 4:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button4.Enabled = true;
                    break;

            }
            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x) == 1)
            {
                debug = 1;
            }
        }
        int debug = 0;
        Grade g=new Grade();
        private void button1_Click(object sender, EventArgs e)
        {
            float a = g.getGrade("cxfm1", datahelp.QId);
            if (a > -1 && debug != 1)
            {

                ff.ShowErrorDialog("重复考试");
                //datahelp.CurrentStep = 2;
                datahelp.CurrentStep1 = 3;
                this.refreshButton();
                return;
            }

            this.Close();
            z = new zaixianjiaoyan2();
            z.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectInfo p = new ProjectInfo();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a1 = g.getGrade("zx-jielun", datahelp.QId);
            if (a1 > -1 && debug != 1)
            {

                ff.ShowErrorDialog("重复考试");
               
                datahelp.CurrentStep1 = 4;
                this.refreshButton();
                return;
            }

            this.Close();
            record a = new record("1", "在线");
            a.Show();
        }
    }
}

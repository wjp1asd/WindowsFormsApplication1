using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class OFF : Form
    {
        String qr;
        Grade g = new Grade();
        public OFF(String qrcode)
        {
            qr = qrcode;
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



            this.label2.Text = "离线校验";



            this.change();


        }
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
            datahelp.SubId = 1;

            this.Close();

            QuestionForm a = new QuestionForm(qr);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datahelp.CurrentStep1 = 3;

            this.Close();

            jiaoyancanshu j = new jiaoyancanshu();
            j.Show();
        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }



        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
        private void OFF_Load(object sender, EventArgs e)
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

                case -1:
                    this.button3.Enabled = true;
                    this.button1.Enabled = true;
                    this.button2.Enabled = true;
                    this.button4.Enabled = true;
                    break;

            }

            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            datahelp.CurrentStep = 4;
           this.Close();
            record r = new record(datahelp.QId);
            r.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            datahelp.status = 1;
            this.Close();
            ProjectInfo p = new ProjectInfo();
            p.Show();


        }
    }
}

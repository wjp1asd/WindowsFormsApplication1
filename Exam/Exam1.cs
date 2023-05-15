using AutoWindowsSize;
using System;
using System.Configuration;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class Exam1 : Form
    {

        String qr;
        public Exam1(String qrcode = "mXjjwVcvXizfGcnbOF9CKw==")
        {
            InitializeComponent();
            datahelp.QId=qrcode;
            InitUI();
            qr = qrcode;


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

            string x = ConfigurationManager.AppSettings["machine"];
         

            //    MessageBox.Show(a.color1);
            switch (int.Parse(x))
            {
                case 2:
                    this.button2.Enabled = false;
                    this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button3.Enabled = false;
                    break;
                case 3:
                    this.button1.Enabled = false;
                    this.button3.Enabled = false;
                    this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    break;
                case 4:
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                    this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    break;

            }
            this.label2.Text = a.link;
            // 最大化 
            this.change();

        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.button2, this);
            ff.fullsreen(this.button3, this);
            ff.fullsreen(this.label2, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MFYM mf = new MFYM(qr);
            mf.Show();
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

        private void Exam1_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void uiBreadcrumb1_ItemIndexChanged(object sender, int value)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OFF of = new OFF(qr);
            of.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ON on = new ON(qr);
            on.Show();
        }
    }
}

using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class ON : Form
    {
        public ON(String qrcode)
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



            this.label2.Text = "在线校验";



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
            // 工艺题'
           
            gongyijiaoyan gongyijiaoyan = new gongyijiaoyan();
            gongyijiaoyan.Show();
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



        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
        private void ON_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;

            switch (datahelp.CurrentStep)
            {
                case 1:

                    this.button3.Enabled = true;
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                   
                    break;
                case 2:
                    this.button3.Enabled = false;
                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                 
                    break;
                case 3:
                    this.button3.Enabled = false;
                    this.button1.Enabled = false;
                    this.button2.Enabled = true;
                    
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            ProjectInfo projectInfo = new ProjectInfo();    
            projectInfo.Show();
        }
    }
}

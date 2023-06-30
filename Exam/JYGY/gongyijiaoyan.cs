using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class gongyijiaoyan : Form
    {
        public gongyijiaoyan()
        {
            InitializeComponent();

            InitUI();

        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);

            ff.fullsreen(this.button3, this);

            ff.fullsreen(this.label2, this);
        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

          

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);





            this.change();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ON o =new ON(datahelp.QId.Trim());
            o.Show();   
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
        private void gongyijiaoyan_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datahelp.SubId = 3;
            QuestionForm a = new QuestionForm(datahelp.QId, "3");
            a.Show();
            this.Close();
        }
    }
}

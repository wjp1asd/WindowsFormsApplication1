using System;
using System.Windows.Forms;
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

        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);




            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.button2, this);

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Online_JiaoYan a = new Online_JiaoYan();
            a.Show();
            this.Close();
        }

        private void Online_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

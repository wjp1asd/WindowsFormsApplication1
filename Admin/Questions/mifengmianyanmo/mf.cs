using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Questions;
using WindowsFormsApplication1.YanMO;

namespace WindowsFormsApplication1.Admin.Questions.mifengmianyanmo
{
    public partial class mf : Form
    {
        public mf()
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

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);





        }

        private void button1_Click(object sender, EventArgs e)
        {
            XHSB x = new XHSB();
            x.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LPSB l = new LPSB();
            l.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuestionSet s = new QuestionSet();
            s.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            questions q = new questions("4");
            q.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LPSB y = new LPSB();
            y.Show();
            this.Close();
        }

        private void mf_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

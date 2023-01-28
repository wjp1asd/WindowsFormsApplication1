using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Exam
{
    public partial class OFF : Form
    {
        public OFF()
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

           

            this.label2.Text = "离线校验";



        }
        private void button3_Click(object sender, EventArgs e)
        {
            QuestionForm a=new QuestionForm();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jiaoyancanshu j = new jiaoyancanshu();
            j.Show();
        }
    }
}

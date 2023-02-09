using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Admin.Questions.jiaoyangongyi
{
    public partial class JiaoYan : Form
    {

        Fuc c=new Fuc();
        public JiaoYan()
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

        

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);

            c.fullsreen(this.label2,this);

            c.fullsreen(this.button1, this);
            c.fullsreen(this.button7, this);




        }


        private void button1_Click(object sender, EventArgs e)
        {
            questions a = new questions("3");
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuestionSet s = new QuestionSet();
            s.Show();
            this.Close();
        }

        private void JiaoYan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

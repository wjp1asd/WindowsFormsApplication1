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

namespace WindowsFormsApplication1.Exam
{
    public partial class Exam1 : Form
    {
        TestRecord t;
        public Exam1(String qrcode)
        {
            InitializeComponent();

            InitUI();
            t=new TestRecord(qrcode);

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



            //    MessageBox.Show(a.color1);
            switch (a.Status) {
                case 0:
                    this.button2.Enabled= false;
                   this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button3.Enabled = false;
                    break;
                case 1:
                    this.button1.Enabled = false;
                    this.button3.Enabled = false;
                    this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml("Gray");
                    break;
                case 2:
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

        }

        private void Exam1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void uiBreadcrumb1_ItemIndexChanged(object sender, int value)
        {
           
        }
    }
}

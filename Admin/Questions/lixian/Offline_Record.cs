using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Questions
{
    public partial class Offline_Record : Form
    {
        public Offline_Record()
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
           
            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

           

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);





        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Record a = new Record("1");
            a.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Offline c = new Offline();
            c.Show();
            this.Close();
        }
    }
}

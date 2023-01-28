using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Questions
{
    public partial class Offline_JiaoYan : Form
    {
     
        public Offline_JiaoYan()
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
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);


            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);





        }

        private void button7_Click(object sender, EventArgs e)
        {
            Offline a = new Offline();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wucha_Settings j = new Wucha_Settings("0");
            j.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pressure p = new Pressure("0");
            p.Show();
            this.Close();
        }

        private void Offline_JiaoYan_Load(object sender, EventArgs e)
        {

        }

        private void bb(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

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
            //   ff.ShowInfoTip(a.color1);





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
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void bb(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

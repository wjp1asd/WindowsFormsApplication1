using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

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
            //   ff.ShowInfoTip(a.color1);





            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {


            ff.fullsreen(this.button2, this);

            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);
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

        private void Offline_Record_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

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
            ff.same(this);
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


           
            ff.button(this.button2);
         
            ff.button(this.button7);
            
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
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        private void Offline_Record_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Scan;

namespace WindowsFormsApplication1
{
    public partial class ProjectInfo : Form
    {
        public ProjectInfo()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            string x = ConfigurationManager.AppSettings["machine"];
            if (int.Parse(x) < 2)
            {
             form1 c =new form1();
                c.Show();
            }
            else
            {
                ScanLogin p = new ScanLogin();
                p.Show();
            }

            //   Application.Restart();
            // Process.GetCurrentProcess()?.Kill();
        }
    }
}

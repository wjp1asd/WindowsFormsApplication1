using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Exam
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose();
            choose.Show();
        }
    }
}

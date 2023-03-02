using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ResultSet : Form
    {
        public ResultSet()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminIndex a = new AdminIndex();
            a.Show();
            this.Close();
        }

        private void ResultSet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

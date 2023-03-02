using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Exam
{
    public partial class linpeijianshibie : Form
    {
        public linpeijianshibie()
        {
            InitializeComponent();
        }

        private void linpeijianshibie_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

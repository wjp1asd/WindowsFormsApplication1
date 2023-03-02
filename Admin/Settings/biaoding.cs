using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Admin.Settings
{
    public partial class biaoding : Form
    {
        public biaoding()
        {
            InitializeComponent();
        }

        private void biaoding_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Exam
{
    public partial class zaixianjiaoyan2 : Form
    {
        public zaixianjiaoyan2()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void zaixianjiaoyan2_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "#KG";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

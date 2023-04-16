using AutoWindowsSize;
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
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }



        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }

        private void zaixianjiaoyan2_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "#KG";
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;

        }

    }
}

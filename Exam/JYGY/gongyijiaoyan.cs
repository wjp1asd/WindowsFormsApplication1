using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class gongyijiaoyan : Form
    {
        public gongyijiaoyan()
        {
            InitializeComponent();
            this.change();


        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);

            ff.fullsreen(this.button3, this);

            ff.fullsreen(this.label2, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void gongyijiaoyan_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void gongyijiaoyan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (datahelp.time > 0)
            {
                datahelp.time--;
            }
            else
            {
                this.timer1.Stop();
                this.Close();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (datahelp.stateTime == 1)
            {
                timer1.Start();
                datahelp.stateTime = 0;
            }
        }

       


      
    }
}

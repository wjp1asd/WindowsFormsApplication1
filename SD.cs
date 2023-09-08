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

namespace WindowsFormsApplication1
{
    public partial class SD : Form
    {
        public SD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Api api = new Api();
           this.richTextBox1.Text= api.xx();
        }

        private void SD_Load(object sender, EventArgs e)
        {

        }
    }
}

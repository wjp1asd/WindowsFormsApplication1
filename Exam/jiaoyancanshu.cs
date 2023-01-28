using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Exam
{
    public partial class jiaoyancanshu : Form
    {
        public jiaoyancanshu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JiaoYan j = new JiaoYan();
            j.Show();
        }
    }
}

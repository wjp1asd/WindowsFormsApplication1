using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Scan
{
    public partial class ScanLogin : Form
    {
        public ScanLogin()
        {
            InitializeComponent();
        }
        Fuc c = new Fuc();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 8)
            {
                // 
              
                this.textBox1.Enabled = false;
                this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml("Green");
                this.button7.Enabled = true;
                this.button7.Text = "查询结果";
                
            }
            else {
                c.ShowInfoTip("指令长度为8位");
               // this.textBox1.Text = "";
}
        }

        private void ScanLogin_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.button7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //查询数据 是否有选题记录
            if (c.RC("select * from TestRecord where qrcode=" + this.textBox1.Text.Trim()) > 0)
            {
                c.ShowSuccessTip("成功");
             
                this.button7.Text = "确认考试";

              Print p=new Print(this.textBox1.Text);
                p.Show();
                
            }
            else {

                c.ShowErrorDialog("未找到合适记录");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

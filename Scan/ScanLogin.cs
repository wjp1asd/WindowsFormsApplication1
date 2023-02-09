using System;
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
            this.change();

        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.textBox1, this);

            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // 


            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml("Green");
            this.button7.Enabled = true;
            this.button7.Text = "查询结果";


        }

        private void ScanLogin_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.button7.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //查询数据 是否有选题记录

            String sql = "select * from TestRecord where qrcode like  '%" + this.textBox1.Text.Trim().Substring(0, 20) + "%'";
            // MessageBox.Show(sql);
            if (ff.RC(sql).Length > 0)
            {
                ff.ShowSuccessTip("成功" + ff.RC(sql));

                this.button7.Text = "确认考试";

                // Print p=new Print(this.textBox1.Text);
                //  p.Show();

            }
            else
            {

                ff.ShowErrorDialog("未找到合适记录");
            }
            if (this.button7.Text == "确认考试")
            {
                // 开始进入考试
                Exam1 ex = new Exam1(ff.RC(sql));
                ex.Show();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ff.backlogin();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

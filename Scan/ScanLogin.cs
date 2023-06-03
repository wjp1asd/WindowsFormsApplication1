using System;
using System.Configuration;
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
            this.ControlBox = false;
           // this.FormBorderStyle = FormBorderStyle.None;
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

            // 自动登录
            if (this.textBox1.Text.ToString().Length > 19) {

                xuanti();
            
            
            }

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
            xuanti();
        



        }

        private void xuanti()
        {
            if (this.textBox1.Text.ToString().Length <19)
            {

                ff.ShowErrorDialog("考试码格式有误");

                return;
            }
                String sql = "select * from TestRecord where qrcode like  '%" + this.textBox1.Text.Trim().Substring(0, 20) + "%'";
                String sql1 = "select * from Grade where testid like  '%" + this.textBox1.Text.Trim().Substring(0, 20) + "%'";
            // MessageBox.Show(sql);
            if (ff.RC(sql).Length > 0)
            {
                //ff.ShowSuccessTip("成功" + ff.RC(sql));
                string qrcode = ff.RC(sql);
                if (ff.RC1(sql1).Length == 0) {
                    //生成空白成绩单
                    ff.formGrade(qrcode);
                
                }
                string x = ConfigurationManager.AppSettings["machine"];
                switch (x) {
                    case "2":
                        this.button7.Text = "离线考试";
                        break;
                    case "3":
                        this.button7.Text = "在线考试";
                        break;
                    case "4":
                        this.button7.Text = "研磨考试";
                        break;

                }
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
                // 开始进入考试 读取不同设备参数 进行定向跳转    < !--1是管理员  0是考生抽题 2是离线考试 3 在线考试 4 研磨 - 1是上帝模式-- >
               
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

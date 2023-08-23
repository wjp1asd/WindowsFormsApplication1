using System;
using System.Configuration;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Exam.MF;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Scan
{
    public partial class ScanLogin : Form
    {
        public ScanLogin()
        {
            InitializeComponent();
            // this.change();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.groupBox1.Hide();
            //this.Close();
            string x = ConfigurationManager.AppSettings["machine"];


            //   ff.ShowInfoTip(a.color1);
            switch (int.Parse(x))
            {
                case 2:
                    this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.离线校验界面副本;
                    break;
                case 3:
                    this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.在线校验界面副本;
                    break;
                case 4:
                    this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.密封面研磨界面副本;
                    break;
                case -1:
                    //  datahelp.CurrentStep = 3;
                    this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.空白界面副本;
                    break;

            }
        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.textBox1, this);


            //  ff.fullsreen(this.label2, this);


        }
        bool read = true;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // 自动登录

            this.button1.Visible = false;
            if (this.textBox1.Text.ToString().Length > 20 && read == true)
            {


                this.textBox1.Enabled = false;
                xuanti();
            }




        }

        private void ScanLogin_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();


            //this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");



        }

        private void button7_Click(object sender, EventArgs e)
        {
            //查询数据 是否有选题记录
            if (read)
            {
                xuanti();
            }



        }
        bool a = false;
        string qrcode = "";
        private void xuanti()
        {
            if (this.textBox1.Text.ToString().Length < 19)
            {

                ff.ShowErrorDialog("考试码格式有误");

                return;
            }
            string sql = "select * from TestRecord where qrcode like  '%" + this.textBox1.Text.Trim().Substring(0, 20) + "%'";

            if (ff.RC(sql).Length > 0)
            {


                qrcode = ff.RC(sql);

                t = t.getRecord(qrcode);
                datahelp.QId = qrcode;
                this.groupBox1.Show();
                this.button4.Focus();
                Student s = new Student(t.KsId);
                this.button1.Visible = false;
                this.label10.Text += t.Ksname;
                this.label3.Text += s.Sex;
                this.label8.Text += t.KsId;
                this.pictureBox2.ImageLocation = s.ava;
                // this.textBox1.Enabled = true;
                this.textBox1.Clear();
                this.textBox1.Focus();
                read = false;
            }
            else
            {

                ff.ShowErrorDialog("未找到合适记录");
                this.textBox1.Enabled = true;
                this.textBox1.Clear();
                this.textBox1.Focus();
                this.button1.Visible = true;
                read = true;

            }
            // 开始进入考试 读取不同设备参数 进行定向跳转    < !--1是管理员  0是考生抽题 2是离线考试 3 在线考试 4 研磨 - 1是上帝模式-- >


        }
        TestRecord t = new TestRecord();
        private void button1_Click(object sender, EventArgs e)
        {
            // this.Close();
            // ff.backlogin();

            Application.Exit();
            //   Process.GetCurrentProcess()?.Kill();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Visible = true;
            this.groupBox1.Hide();
            this.textBox1.Enabled = true;
            this.textBox1.Clear();
            this.textBox1.Focus();
            read = true;

        }
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox1.Hide();
            ff.showloading();
            string x = ConfigurationManager.AppSettings["machine"];


            //   ff.ShowInfoTip(a.color1);
            switch (int.Parse(x))
            {
                case 2:
                    datahelp.CurrentStep = 2;
                    OFF of = new OFF(qrcode);
                    of.Show();
                    break;
                case 3:
                    datahelp.CurrentStep = 2;
                    zaixianjiaoyan on = new zaixianjiaoyan();
                    on.Show();
                    break;
                case 4:
                    datahelp.CurrentStep = 3;
                    MF1 mf = new MF1();
                    mf.Show();
                    break;
                case -1:
                    //  datahelp.CurrentStep = 3;
                    Exam1 ex = new Exam1();
                    ex.Show();
                    break;

            }

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (read == true)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (read == true)
            {
                Application.Exit();
            }

        }
    }
}

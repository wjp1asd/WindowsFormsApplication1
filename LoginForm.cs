using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Scan;
using WindowsFormsApplication1.YanMO;
using WindowsFormsApplication1.Settings;
using WindowsFormsApplication1.Admin.Results;
using WindowsFormsApplication1.Exam.MF;

namespace WindowsFormsApplication1
{
    public partial class form1 : Form


    {
        Fuc ft = new Fuc();

        public form1()
        {
            InitializeComponent();
            this.flowLayoutPanel1.Hide();

            InitUI();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();


            string x = ConfigurationManager.AppSettings["machine"];
            this.label2.Text = a.link;
            if (x == "1")
            {
                // 管理员权限

                this.button1.Left += 150;
                this.button3.Left = this.button1.Left;

                this.button2.Hide();
                this.uiButton1.Hide();
                this.button4.Hide();
                this.button5.Hide();
                this.button6.Hide();
              
                this.button8.Hide();
                
                this.button10.Hide();
                this.button11.Hide();
                this.button12.Hide();
            }
            else if (x == "0")
            {
                // 考生登录

                this.button2.Left += 150;
                this.button2.Top= 160;
                this.button3.Left = this.button2.Left;
                this.button1.Hide();
                this.pictureBox1.Hide();
                this.uiButton1.Hide();

                this.button4.Hide();
                this.button5.Hide();
                this.button6.Hide();
              
                this.button8.Hide();
              
                this.button10.Hide();
                this.button11.Hide();
                this.button12.Hide();
            }
            else if (x == "2")
            {
                //考试机登录
             
                this.button1.Hide();
                this.button1.Enabled = false;
                this.pictureBox1.Hide();
                this.button2.Hide();
                this.button2.Enabled = false;

                this.button3.Left -= 200;
                this.uiButton1.Left -= 200;
                this.button4.Hide();
                this.button5.Hide();
                this.button6.Hide();
               
                this.button8.Hide();
               
                this.button10.Hide();
                this.button11.Hide();
                this.button12.Hide();
            }
            else if (x == "2"|| x == "3"|| x == "4")
            {
                //考试机登录

                this.button1.Hide();
                this.button1.Enabled = false;
                this.pictureBox1.Hide();
                this.button2.Hide();
                this.button2.Enabled = false;

                this.button3.Left -= 200;
                this.uiButton1.Left -= 200;
                this.button4.Hide();
                this.button5.Hide();
                this.button6.Hide();
                
                this.button8.Hide();
                
                this.button10.Hide();
                this.button11.Hide();
                this.button12.Hide();
            }
            else if (x == "-1")
            {
                // 上帝模式

            }
            else
            {

                this.button4.Hide();
                this.button5.Hide();
                this.button6.Hide();
               
                this.button1.Hide();
                this.button2.Hide();
                this.button3.Hide();
                this.button4.Hide();
                this.uiButton1.Hide();
                this.button11.Hide();
                this.button12.Hide();


            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {

                ft.ShowErrorTip("请输入用户名");
                this.txtUsername.Focus();
                return;
            }
            else if (this.txtPassword.Text == "")
            {
                ft.ShowErrorTip("请输入密码");
                this.txtPassword.Focus();
                return;
            }
            else
            {


                int power = 2;
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);
                string sql = string.Format("select count(*) from dbo.student  where loginId='{0}' and password='{1}'and Power={2}", this.txtUsername.Text, this.txtPassword.Text, power);
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                int count = int.Parse(com.ExecuteScalar().ToString());
                con.Close();
                ;
                if (count > 0)
                {

                    GetStudentId(this.txtUsername.Text.Trim());
                    AdminIndex a = new AdminIndex();

                    a.Show();
                    this.Hide();
                }
                else
                {
                    ft.ShowErrorDialog("登录失败");
                }

            }
        }
        private void GetStudentId(string loginId)
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select id from student where loginId='" + loginId.ToString() + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            datahelp.StudentId = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Hide();
        }

        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void form1_Load(object sender, EventArgs e)
        {
            // ft.showloading();

            initsetp();
           
        }

        private void initsetp()
        {
            datahelp.CurrentStep = 1;
            datahelp.CurrentStep1 = 1;
            datahelp.QuestionIds = null;
            datahelp.CurrentQuestion = 0;
            datahelp.UserAnswer = null;
            datahelp.curAnswer = null;
            datahelp.Correct = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID f1 = new ID();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings1 s1 = new Settings1();
            s1.Show();
            this.Hide();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ScanLogin s = new ScanLogin();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choose c = new Choose("321084199510025535");
            c.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ScanLogin sc = new ScanLogin();
            sc.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //jiaoyancanshu  jy = new jiaoyancanshu();    
            //jy.Show();
            OFF off = new OFF(datahelp.QId);
            off.Show(); 
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            plc c = new plc();
            c.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            MF1 mf = new MF1();
            mf.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LBJForm lbg = new LBJForm("EmcaBvClo9bJ6NkgbLWqRg==");
            lbg.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jiaoyancanshu  jy = new jiaoyancanshu();    
            jy.Show();

           // XHSB xh =new XHSB();
            //xh.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //zaixianjiaoyan2 zaixianjiaoyan = new zaixianjiaoyan2();
            //zaixianjiaoyan.Show();
            ON on = new ON(datahelp.QId);
            on.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GradePrint gradePrint = new GradePrint("w3gF7LblbhEknmqSQNtubw==");
            gradePrint.Show();
        }
    }
}

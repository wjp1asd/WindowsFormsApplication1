using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using WindowsFormsApplication1.Settings;
using Sunny.UI;
using System.Security.Cryptography;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Scan;
using WindowsFormsApplication1.Exam;

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

                this.button2.Hide();
                this.button2.Enabled = false;
                this.button1.Top = this.button1.Top + 20;
                this.button3.Top = this.button3.Top - 70;
                this.uiButton1.Hide(); 
            }
            else if (x == "0")
            {
                // 考生登录
                this.button1.Hide();
                this.pictureBox1.Hide();
                this.uiButton1.Hide();
                this.button2.Top = this.button2.Top - 80;
                this.button3.Top = this.button3.Top - 80;
            }
            else if (x == "2") {
                this.button1.Hide();
                this.button1.Enabled = false ;

                this.button2.Hide();
                this.button2.Enabled = false;

                this.uiButton1.Top = this.uiButton1.Top + 20;
                this.button3.Top = this.button3.Top - 70;
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
      
                   
                int  power = 2;
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
            string sql = "select id from student where loginId='" + loginId .ToString()+"'";
            SqlCommand com = new SqlCommand(sql,con);
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
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID f1 = new ID();
            f1.Show();
          
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
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ScanLogin s = new ScanLogin();
            s.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choose c = new Choose();
            c.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ScanLogin sc=new  ScanLogin();
            sc.Show();
           this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Opencv cv= new Opencv();
            cv.Show();
        }
    }
}

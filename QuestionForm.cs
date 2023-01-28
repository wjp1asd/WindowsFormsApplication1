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
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class QuestionForm : Form


    {
        Fuc f =new Fuc();
        
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            InitbtnUp();
            InitbtnNext();
            ShowInfo();
            LoadQuestion();
        }
        private void InitbtnUp()
        {
            if (datahelp.CurrentQuestion <2)
            {
                this.btnUp.Enabled  = false;
                this.btnUp.Text = "已是第一题";


            }
            else
            {

                this.btnUp.Enabled = true;
                this.btnUp.Text = "上一题";
            }
           

        }
        private void InitbtnNext()
        {
            if (datahelp.CurrentQuestion >19)
            {
                this.btnNext.Text  = "答题卡";
            }
           
        }
        private void LoadQuestion()
        {
            int questionId = datahelp.QuestionIds[datahelp.CurrentQuestion-1 ];
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from question where Id=" + questionId.ToString();

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                this.txtQuestionContent.Text = reader["question"].ToString();
                this.rdbA.Text = "A: " + reader["optionA"].ToString();
                this.rdbB.Text = "B: " + reader["optionB"].ToString();
                this.rbdC.Text = "C: " + reader["optionC"].ToString();
                this.rdbD.Text = "D: " + reader["optionD"].ToString();
            }

            reader.Close();
            con.Close();


        }

        private void ShowInfo()
        {
            this.lblCurrent.Text = datahelp.CurrentQuestion.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (datahelp.CurrentQuestion < 20)
            {
                datahelp.CurrentQuestion++;
                CheckNextButtonText();
                ShowInfo();
                LoadQuestion();
                SelectOption();
            }
            else
            {
                this.btnNext.Text = "提交";
                btnAnswer_Click(sender, e);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (datahelp.RemainTime > 0)
            {
                datahelp.RemainTime--;
                int min = datahelp.RemainTime / 60;
                int sec = datahelp.RemainTime % 60;
                this.lbltime.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("时间到了，请交卷");
                AnswerForm frm = new AnswerForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }


        }

        private void CheckNextButtonText()
        {
            if (datahelp.CurrentQuestion < 20)
            {
                this.btnNext.Text = "下一题";
                btnUp.Enabled = true;
                btnUp.Text = "上一题";
            }
            else
            {
                this.btnNext.Text = "答题卡";
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            AnswerForm frm = new AnswerForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }
        private void SelectOption()
        {
            switch (datahelp.UserAnswer[datahelp.CurrentQuestion - 1])
            {
                case "A": this.rdbA.Checked = true; break;
                case "B": this.rdbB.Checked = true; break;
                case "C": this.rbdC.Checked = true; break;
                case "D": this.rdbD.Checked = true; break;
                default:
                    this.rdbA.Checked = false;
                    this.rdbB.Checked = false;
                    this.rbdC.Checked = false;
                    this.rdbD.Checked = false;
                    break;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (datahelp.CurrentQuestion > 1)
            {
                datahelp.CurrentQuestion--;
                CheckUpButtonText();
                ShowInfo();
                LoadQuestion();
                SelectOption();
            
            }

        }
        private void CheckUpButtonText()
        {
            if (datahelp.CurrentQuestion >0)
            {
                this.btnUp.Text = "上一题";
               
                
            }
            else
            {
                this.btnUp.Text = "已是第一题";
            btnUp.Enabled = false;
            }
        }



        private void rdbA_Click(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            string option = rdb.Tag.ToString();
            datahelp.UserAnswer[datahelp.CurrentQuestion - 1] = option;
            Console.WriteLine(datahelp.UserAnswer.ToString());
        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestionContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closing(object sender, FormClosedEventArgs e)
        {
           
            f.ShowWarningTip("中途退出，成绩将不合格请谨慎选择");
            Process.GetCurrentProcess().Kill();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

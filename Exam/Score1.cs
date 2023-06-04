using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class Score1 : Form
    {
        public Score1()
        {
            InitializeComponent();
           
        }
        int rate = 0;

        private void Form6_Load(object sender, EventArgs e)
        {

            ShowScore();
            AddStudentScore();
        }
        private void AddStudentScore()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into score ([studentid],[score],[subid],[tid]) VALUES(" +
               "'" + datahelp.StudentId.Trim() +"'" + "," +
              "'" + score + "'" + "," +
              "'" + datahelp.SubId + "'" + "," +
              "'" + datahelp.QId.Trim() + "'"
              + ")";
           // MessageBox.Show(strcomm);
            SqlCommand com = new SqlCommand(strcomm, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        private int score = 0;
        private void ShowScore()
        {
            int count = 0;
        string [] a=    datahelp.Correct;
            for (int i = 0; i < a.Length; i++)
            {
                // 答对题的数量
                if (a[i]=="1")
                {
                    count++;
                }
            }
          

            score = count * rate;
            if (score < 60)
            {

            
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);

            }
            else if (score < 70)
            {
                this.lblscore.BackColor = Color.YellowGreen;

             
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);
            }
            else if (score < 80)
            {
                this.lblscore.BackColor = Color.Yellow;

             
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);

            }
            else if (score < 90)
            {
                this.lblscore.BackColor = Color.Green;

          
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);

            }
            else if (score <= 100)
            {
                this.lblscore.BackColor = Color.Green;

              
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picFace_Click(object sender, EventArgs e)
        {

        }

        private void lblscore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblAllscore_Click(object sender, EventArgs e)
        {

        }

        private void lblAllResult_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAllscore_Click_1(object sender, EventArgs e)
        {

        }

        private void Score1_Load(object sender, EventArgs e)
        {
            Score sc = new Score();
            switch (datahelp.SubId)
            {
                case 1:
                    this.Text = "离线校验得分";
                    rate = sc.getScore("lxt");
                    break;
                case 2:
                    this.Text = "在线校验得分";
                    rate = sc.getScore("zxt");
                    break;
                case 3:
                    this.Text = "校验工艺得分";
                    rate = sc.getScore("gyt");
                    break;

                case 4:
                    this.Text = "型号识别得分";
                    rate = sc.getScore("xhsb");
                    break;
                case 5:
                    this.Text = "零配件识别得分";
                    rate = sc.getScore("lpjsb");
                    break;
                case 6:
                    this.Text = "密封面研磨得分";
                    rate = sc.getScore("ymgsb");
                    break;
            }


            ShowScore();
            AddStudentScore();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateGrades();

            datahelp.CurrentStep = 2;
            OFF of =new OFF(datahelp.QId);
            of.Show();
            this.Close();
        }

        private void UpdateGrades()
        {
    //        [Id] INT IDENTITY(1, 1) NOT NULL,
    //[name]            NCHAR(10) NULL,
    //[idcard] NCHAR(10) NULL,
    //[testid] NCHAR(50) NULL,
    //[zxquestions] NCHAR(10) NULL,
    //[zxanswer] NCHAR(10) NULL,
    //[zxcorrect] NCHAR(10) NULL,
    //[score1] INT NULL DEFAULT 0,
    //[lxquestions] NCHAR(10) NULL,
    //[lxanswer] NCHAR(10) NULL,
    //[lxcorrect] NCHAR(10) NULL,
    //[score2] INT NULL DEFAULT 0,
    //[jyquestions] NCHAR(10) NULL,
    //[jyanswer] NCHAR(10) NULL,
    //[jycorrect] NCHAR(10) NULL,
    //[score3] INT NULL DEFAULT 0,
    //[xhquestions] NCHAR(10) NULL,
    //[xhanswer] NCHAR(10) NULL,
    //[xhcorrect] NCHAR(10) NULL,
    //[score4] INT NULL DEFAULT 0,
    //[lpjquestions] NCHAR(10) NULL,
    //[lpjanswer] NCHAR(10) NULL,
    //[lpjcorrect] NCHAR(10) NULL,
    //[score5] INT NULL DEFAULT 0,
    //[gyquestions] NCHAR(10) NULL,
    //[gyanswer] NCHAR(10) NULL,
    //[gycorrect] NCHAR(10) NULL,
    //[score6] INT NULL DEFAULT 0,
    //[ymgquestions] NCHAR(10) NULL,
    //[ymganswer] NCHAR(10) NULL,
    //[ymgcorrect] NCHAR(10) NULL,
    //[score7] NCHAR(10) NULL,
    //[path] NCHAR(10) NULL,
    //[score8] INT NULL DEFAULT 0,
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string a = string.Join(",", datahelp.QuestionIds);
            string b = string.Join(",",datahelp.UserAnswer);
            string c = string.Join(",", datahelp.Correct);
            int d = score;
            string str1 = "";
            switch (datahelp.SubId)
            {
                case 1:
                  
                    str1 = "Update Grade set lxquestions='" + a + "',lxanswer='" + b + "',lxcorrect='" + c + "',score2='" + d
              
                + "' where testid="+datahelp.QId.Trim();
                    break;
                case 2:
                    str1 = "Update Grade set zxquestions='" + a + "',zxanswer='" + b + "',zxcorrect='" + c + "',score1='" + d

              + "' where testid=" + datahelp.QId.Trim();
                    break;
                case 3:
                    str1 = "Update Grade set jyquestions='" + a + "',jyanswer='" + b + "',jycorrect='" + c + "',score3='" + d

              + "' where testid=" + datahelp.QId.Trim();
                    break;

                case 4:
                    str1 = "Update Grade set xhquestions='" + a + "',xhanswer='" + b + "',xhcorrect='" + c + "',score4='" + d

            + "' where testid=" + datahelp.QId.Trim();

                    break;

                case 5:
                    str1 = "Update Grade set lpjquestions='" + a + "',lpjanswer='" + b + "',lpjcorrect='" + c + "',score5='" + d

            + "' where testid=" + datahelp.QId.Trim();

                    break;

                case 6:
                    str1 = "Update Grade set ymgquestions='" + a + "',ymganswer='" + b + "',ymgcorrect='" + c + "',score7='" + d

            + "' where testid=" + datahelp.QId.Trim();

                    break;


            }
        

            MessageBox.Show(str1);
            SqlCommand com = new SqlCommand(str1, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }

}




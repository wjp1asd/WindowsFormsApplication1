using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApplication1.Exam.MF;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class Score1 : Form
    {
        public Score1()
        {
            InitializeComponent();
           
        }
        float rate = 0;

        private void Form6_Load(object sender, EventArgs e)
        {

           
           // AddStudentScore();
        }
        private void AddStudentScore()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into score ([studentid],[score],[subid],[tid]) VALUES(" +
               "'" + datahelp.StudentId.Trim() +"'" + "," +
              "'" + score.ToString() + "'" + "," +
              "'" + datahelp.SubId + "'" + "," +
              "'" + datahelp.QId.Trim() + "'"
              + ")";
         // ff.ShowInfoTip(strcomm);
            SqlCommand com = new SqlCommand(strcomm, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        private float score = 0;
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
             MessageBox.Show(count+""+rate+""+score);
            this.label2.Show();
            this.label2.Text = "得分:" + score.ToString();
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
                    rate = float.Parse(sc.getScore("lxt").ToString());
                   
                    break;
                case 2:
                    this.Text = "在线校验得分";
                    rate = float.Parse(sc.getScore("zxt").ToString());
                    break;
                case 3:
                    this.Text = "校验工艺得分";
                    rate = float.Parse(sc.getScore("gyt").ToString());
                    break;

                case 5:
                    this.Text = "型号识别得分";
                    rate = float.Parse(sc.getScore("xhsb").ToString());
                    break;
                case 6:
                    this.Text = "零配件识别得分";
                    rate = float.Parse(sc.getScore("lpjsb").ToString());
                    break;
                case 4:
                    this.Text = "密封面研磨得分";
                    rate = float.Parse(sc.getScore("ymgsb").ToString());
                    break;
            }
         
          //  MessageBox.Show(rate+"");
                 ShowScore();
           // AddStudentScore();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateGrades();
            switch (datahelp.SubId)
            {
                case 1:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 =2;
                    OFF of = new OFF(datahelp.QId);
                    of.Show();
                    this.Close();

                    break;
                case 2:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;
                    //ON on = new ON(datahelp.QId);
                    //on.Show();
                    zaixianjiaoyan x = new zaixianjiaoyan();
                    x.Show();
                    this.Close();
                    break;
                case 3:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;
                    ON on1 = new ON(datahelp.QId);
                    on1.Show();
                    this.Close();
                    break;

                case 5:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;
                   
                    MF1 mf = new MF1();
                    mf.Show();
                    this.Close();
                    break;
                case 6:
                    datahelp.CurrentStep = 3;
                    MF1 mf1 = new MF1();
                    mf1.Show();
                    this.Close();
                    break;
                case 4:
                    datahelp.CurrentStep = 4;
                    MF1 mf2 = new MF1();
                    mf2.Show();
                    this.Close();
                    break;
            }

          
        }
        private Fuc ff = new Fuc();
        private void UpdateGrades()
        {
   
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string a = string.Join(",", datahelp.QuestionIds);
            string b = string.Join(",",datahelp.UserAnswer);
            string c = string.Join(",", datahelp.Correct);
            double d = score;
            string str1 = "";
            switch (datahelp.SubId)
            {
                case 1:
                  
                    str1 = "Update Grade set lxquestions='" + a + "',lxanswer='" + b + "',lxcorrect='" + c + "',score2='" + d
              
                + "' where testid= '" + datahelp.QId.Trim() + "'";
                    break;
                case 2:
                    str1 = "Update Grade set zxquestions='" + a + "',zxanswer='" + b + "',zxcorrect='" + c + "',score1='" + d

              + "' where testid= '" + datahelp.QId.Trim() + "'";
                    break;
                case 3:
                    str1 = "Update Grade set jyquestions='" + a + "',jyanswer='" + b + "',jycorrect='" + c + "',score3='" + d

              + "' where testid= '" + datahelp.QId.Trim() + "'";
                    break;

                case 5:
                    str1 = "Update Grade set xhquestions='" + a + "',xhanswer='" + b + "',xhcorrect='" + c + "',score4='" + d

            + "' where testid= '" + datahelp.QId.Trim() + "'";

                    break;

                case 6:
                    str1 = "Update Grade set lpjquestions='" + a + "',lpjanswer='" + b + "',lpjcorrect='" + c + "',score5='" + d

            + "' where testid= '" + datahelp.QId.Trim() + "'";

                    break;

                case 4:
                    str1 = "Update Grade set ymgquestions='" + a + "',ymganswer='" + b + "',ymgcorrect='" + c + "',score7='" + d

            + "' where testid= '" + datahelp.QId.Trim()+"'";

                    break;


            }
            //this.label2.Text =str1;

        //   ff.ShowInfoTip(str1);
            SqlCommand com = new SqlCommand(str1, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }

}




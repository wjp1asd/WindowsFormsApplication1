using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class Score1 : Form
    {
        public Score1()
        {
            InitializeComponent();
           
        }


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
            MessageBox.Show(strcomm);
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
            Score sc=new Score();
            score = count * sc.getScore(datahelp.SubId);
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
            ShowScore();
            AddStudentScore();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            datahelp.CurrentStep = 2;
            OFF of =new OFF(datahelp.QId);
            of.Show();
            this.Close();
        }
    }

}




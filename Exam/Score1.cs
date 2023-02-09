using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Exam
{
    public partial class Score1 : Form
    {
        public Score1()
        {
            InitializeComponent();
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

            string sql = string.Format("insert into score values({0},{1},{2})", datahelp.StudentId, score, datahelp.SubId);
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        private int score = 0;
        private void ShowScore()
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (datahelp.UserAnswer[i] == datahelp.Answer[i])
                {
                    count++;
                }
            }

            score = count * 5;
            if (score < 60)
            {

                this.label2.Text = "考得太差，好好复习吧";
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);

            }
            else if (score < 70)
            {
                this.lblscore.BackColor = Color.YellowGreen;

                this.label2.Text = "成绩不理想，继续努力";
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);
            }
            else if (score < 80)
            {
                this.lblscore.BackColor = Color.Yellow;

                this.label2.Text = "成绩不理想，继续加油";
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);

            }
            else if (score < 90)
            {
                this.lblscore.BackColor = Color.Green;

                this.label2.Text = "成绩很好，GOOD!";
                this.label3.Text = score.ToString() + "分";
                this.lblscore.Size = new Size((this.lblAllscore.Width * score) / 100, this.lblscore.Height);

            }
            else if (score <= 100)
            {
                this.lblscore.BackColor = Color.Green;

                this.label2.Text = "你太棒了，Perfect!";
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
    }

}




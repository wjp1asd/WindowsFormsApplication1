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

namespace WindowsFormsApplication1
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }
      

        private void Form6_Load(object sender, EventArgs e)
        {
            
           ShowScore();
            AddStudentScore();
        }
        private void  AddStudentScore()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
     
          string sql=string .Format ("insert into score values({0},{1},{2})",datahelp .StudentId,score ,datahelp.SubId );
          SqlCommand com = new SqlCommand(sql ,con );
          con.Open();
          com.ExecuteNonQuery();
          con.Close();
        }
        private int score = 0;
        private void ShowScore()
        {
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                if (datahelp .UserAnswer[i] ==datahelp .Answer [i])
                {
                count++;
                }
            }           
       
        score = count * 5;
        if(score<60)
       {
        this.picFace.Image=this.imageList1 .Images [0];
            this.lblSpeak.Text ="考得太差，好好复习吧";
        this.lblResult.Text =score .ToString ()+"分" ;
        this.lblscore .Size =new Size ((this.lblAllscore .Width * score )/100,this .lblscore .Height );

      }
       else if (score <70)
        {
            this.lblscore.BackColor = Color.YellowGreen;
        this.picFace.Image=this.imageList1 .Images [1];
            this.lblSpeak.Text ="成绩不理想，继续努力";
        this.lblResult.Text =score .ToString ()+"分" ;
        this.lblscore .Size =new Size ((this.lblAllscore .Width * score )/100,this .lblscore .Height );
         }
      else if (score <80)
        {
            this.lblscore.BackColor = Color.Yellow;
          this.picFace.Image=this.imageList1 .Images [2];
            this.lblSpeak.Text ="成绩不理想，继续加油";
        this.lblResult.Text =score .ToString ()+"分" ;
        this.lblscore .Size =new Size ((this.lblAllscore .Width * score )/100,this .lblscore .Height );

        }
      else if (score <90)
        {
            this.lblscore.BackColor = Color.Green;
         this.picFace.Image=this.imageList1 .Images [3];
            this.lblSpeak.Text ="成绩很好，GOOD!";
        this.lblResult.Text =score .ToString ()+"分" ;
        this.lblscore .Size =new Size ((this.lblAllscore .Width * score )/100,this .lblscore .Height );

        }
      else if (score <=100)
        {
            this.lblscore.BackColor = Color.Green;
          this.picFace.Image=this.imageList1 .Images [4];
            this.lblSpeak.Text ="你太棒了，Perfect!";
        this.lblResult.Text =score .ToString ()+"分" ;
        this.lblscore .Size =new Size ((this.lblAllscore .Width * score )/100,this .lblscore .Height);
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picFace_Click(object sender, EventArgs e)
        {

        }
    }
     
    }



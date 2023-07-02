using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Models
{
   public class Grade
    {
        public string name;
        public string idcard;
        public string testid;
        // 离线题目
        public string lxquestions;
        // 离线回答
        public string lxanswer;
        // 离线正确性
        public string lxcorrect;
        public string score1;
        // 在线题
        public string zxquestions;
        public string zxanswer;
        public string zxcorrect;
        public string score2;
        //校验题
        public string jyquestions;
        public string jyanswer;
        public string jycorrect;
        public string score3;
        //型号题
        public string xhquestions;
        public string xhanswer;
        public string xhcorrect;
        public string score4;
        //public   //零配件
        public string lpjquestions;
        public string lpjanswer;
        public string lpjcorrect;
        public string score5;
        //研磨膏
              public string ymganswer;
        public string ymgquestions;
        public string ymgcorrect;
        public string score6;
        //密封面
        public string path;
        public string score7;
        // 步骤分题

        public string csfm;

        public int updateGrade(int score,string mode,string tid) {
            int i = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "update Grade set "+mode+" = " + score + " where testid = '" + tid + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                i++;
            }

         //   MessageBox.Show(sql+""+i);
            con.Close();
                return i;
        }
        public void getOne(string tid) {
       
     

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from Grade where  testid='" + tid + "'";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
             name = reader["name"].ToString().Trim();
             idcard = reader["idcard"].ToString().Trim();
             testid = reader["testid"].ToString().Trim();  
             lxcorrect = reader["lxcorrect"].ToString().Trim();
             score1 = reader["score1"].ToString().Trim();
             zxcorrect = reader["zxcorrect"].ToString().Trim();
             score2 = reader["score2"].ToString().Trim();
             jycorrect = reader["jycorrect"].ToString().Trim();
             score3 = reader["score3"].ToString().Trim();
             xhcorrect = reader["xhcorrect"].ToString().Trim();
             score4 = reader["score4"].ToString().Trim();
             lpjcorrect = reader["lpjcorrect"].ToString().Trim();
             score5 = reader["score5"].ToString().Trim(); 
             ymgcorrect = reader["ymgcorrect"].ToString().Trim();
             score6 = reader["score6"].ToString().Trim();

            }

            con.Close();

             
        }
    
}
}

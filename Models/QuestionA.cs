using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public class QuestionA
    {

        String question1;
        String answer1;
        String optionA1;
        String optionB1;
        String optionC1;
        String optionD1;
        String type;
        String subtype;
       

        public string question { get => question1; set => question1 = value; }
        public string answer { get => answer1; set => answer1 = value; }
        public string optionA { get => optionA1; set => optionA1 = value; }
        public string optionB { get => optionB1; set => optionB1 = value; }
        public string optionC { get => optionC1; set => optionC1 = value; }
        public string optionD { get => optionD1; set => optionD1 = value; }
        public string Type { get => type; set => type = value; }
        public string Subtype { get => subtype; set => subtype = value; }

        //switch (subtype) { 
        //  case "1":
        //          this.Text = "离线校验题库";
        //          break;
        //      case "2":
        //          this.Text = "在线校验题库";
        //          break;
        //      case "3":
        //          this.Text = "校验工艺题库";
        //          break;

        //      case "4":
        //          this.Text = "密封面研磨题库";
        //          break;
        //  }

        public string Answer(string xx)
        {
            //返回抽题数据

            if (xx.Length > 0)
            {
                String answer;
                List<String> answerList = new List<string>();
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);
                string sql = "select answer from question  where id in (" + xx.Trim() + ")";

                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
               // MessageBox.Show(sql);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    answerList.Add(reader["answer"].ToString());

                }

                answer = string.Join(",", answerList);
                if (answer.Length == 0)
                {

                    MessageBox.Show("题目已不存在于当前题库，请重新抽题");


                }
                else { answer = ""; } 
               

            }
            else {

                answer = "错误";
            }
            return answer;
        }
        public String ChooseLixian()
        {
            //返回抽题数据select * from AppleStoreorder by rand()limit 100;
            String answer;
            datahelp d = new datahelp();
            d.Initc();
            List<String> answerList = new List<string>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top " + d.lxnum + " id from question  where subid = 1 order by newid() ";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                answerList.Add(reader["id"].ToString());

            }

            answer = string.Join(",", answerList); ;

            return answer;

        }

        public String ChooseZaixian()
        {
            //返回抽题数据
            String answer;
            datahelp d = new datahelp();
            d.Initc();
            List<String> answerList = new List<string>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top " + d.zxnum + " id from question  where subid = 2 order by newid() ";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                answerList.Add(reader["id"].ToString());

            }

            answer = string.Join(",", answerList); ;
            Console.WriteLine(answer);
            //MessageBox.Show(answer);
            return answer;
        }
        public String ChooseJiaoYan()
        {
            //返回抽题数据
            String answer;
            datahelp d = new datahelp();
            d.Initc();
            List<String> answerList = new List<string>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top " + d.gynum + " id from question  where subid = 2 order by newid() ";


            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                answerList.Add(reader["id"].ToString());

            }

            answer = string.Join(",", answerList); ;
            Console.WriteLine(answer);
            //MessageBox.Show(answer);
            return answer;
        }
        public String ChooseXH(string aid)
        {
            //返回抽题数据
            String answer;
            datahelp d = new datahelp();
            d.Initc();
            List<String> answerList = new List<string>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top " + d.xhnum + " id from aqfadmin  where aid =" + aid + " order by newid() ";
            // MessageBox.Show(sql);

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                answerList.Add(reader["id"].ToString());

            }

            answer = string.Join(",", answerList); ;
            Console.WriteLine(answer);
            //MessageBox.Show(answer);
            return answer;
        }
        public String ChooseLPJ()
        {
            //返回抽题数据
            String answer;
            datahelp d = new datahelp();
            d.Initc();
            List<String> answerList = new List<string>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top " + d.lpjnum + " id from ymg order by newid() ";


            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                answerList.Add(reader["id"].ToString());

            }

            answer = string.Join(",", answerList); ;
            Console.WriteLine(answer);
            //MessageBox.Show(answer);
            return answer;
        }
        public String ChooseYMG()
        {
            //返回抽题数据
            String answer;
            datahelp d = new datahelp();
            d.Initc();
            List<String> answerList = new List<string>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top " + d.yngnum + " id from question where subid = 4 order by newid() ";


            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                answerList.Add(reader["id"].ToString());

            }

            answer = string.Join(",", answerList); ;
            Console.WriteLine(answer);
            //MessageBox.Show(answer);
            return answer;
        }


    }
}

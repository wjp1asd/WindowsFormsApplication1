using System;
using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApplication1.Exam;

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
        public float score1;
        // 在线题
        public string zxquestions;
        public string zxanswer;
        public string zxcorrect;
        public float score2;
        //校验题
        public string jyquestions;
        public string jyanswer;
        public string jycorrect;
        public float score3;
        //型号题
        public string xhquestions;
        public string xhanswer;
        public string xhcorrect;
        public float score4;
        //public   //零配件
        public string lpjquestions;
        public string lpjanswer;
        public string lpjcorrect;
        public float score5;
        //研磨膏
        public string ymganswer;
        public string ymgquestions;
        public string ymgcorrect;
        public float score6;
        //密封面
        public string path;
        public float score7;
        // 步骤分题

        // 离线校验考试次数判断，在线考试，
       

        public string mxpic;
        public string lxpic,lxpic1,zxpic,zxpic1;
        public float  csfm,ylxz,xygb,wxxz,zdyltz,sjlmsj,azfm,dkxyf,gbylbqh,yqzdyl,gctj,yldj,dycyl,decyl,dscyl;
        public float mfsyyl, jyjl, mfzjcl, cxfm1, wxxz1,jyjg1, azfm1, bycs,score8;
       
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        //[] INT DEFAULT((-1)) NULL,
        public int updateGrade(float score, string mode, string tid)
        {
            int i = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "update grade set " + mode + " = " + score + "where testid = '" + tid + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                i++;
            }

            return i;
        }
        public int updatepath(string path, string pathname, string tid)
        {
            int i = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "update grade set " + pathname + " = '" + path + "'  where testid = '" + tid + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                i++;
            }

            return i;
        }
        public int getGrade(string can, string qid)
        {
            int score1 = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();


            string sql = "select " + can + " from Grade where testid like  '%" + qid + "%'";


            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                score1 = int.Parse(reader[can].ToString().Trim());

            }


            return score1;
        }
        public void getOne(string tid)
        {



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
                score1 = float.Parse(reader["score1"].ToString().Trim());
                zxcorrect = reader["zxcorrect"].ToString().Trim();
                score2 = float.Parse(reader["score2"].ToString().Trim());
                jycorrect = reader["jycorrect"].ToString().Trim();
                score3 = float.Parse(reader["score3"].ToString().Trim());
                xhcorrect = reader["xhcorrect"].ToString().Trim();
                score4 = float.Parse(reader["score4"].ToString().Trim());
                lpjcorrect = reader["lpjcorrect"].ToString().Trim();
                score5 = float.Parse(reader["score5"].ToString().Trim());
                ymgcorrect = reader["ymgcorrect"].ToString().Trim();
                score6 = float.Parse(reader["score6"].ToString().Trim());
                //在线


                azfm1 = float.Parse(reader["azfm1"].ToString().Trim());
                cxfm1 = float.Parse(reader["cxfm1"].ToString().Trim());
                wxxz1 = float.Parse(reader["wxxz1"].ToString().Trim());
                jyjg1 = float.Parse(reader["jyjg1"].ToString().Trim());
                mfzjcl = float.Parse(reader["mfzjcl"].ToString().Trim());


                //离线
                sjlmsj = float.Parse(reader["sjlmsj"].ToString().Trim());
                zdyltz = float.Parse(reader["zdyltz"].ToString().Trim());
                xygb = float.Parse(reader["xygb"].ToString().Trim());
                ylxz = float.Parse(reader["ylxz"].ToString().Trim());
                csfm = float.Parse(reader["csfm"].ToString().Trim());
                gbylbqh = float.Parse(reader["gbylbqh"].ToString().Trim());
                dkxyf = float.Parse(reader["dkxyf"].ToString().Trim());
                azfm = float.Parse(reader["azfm"].ToString().Trim());
                mfsyyl = float.Parse(reader["mfsyyl"].ToString().Trim());
                yldj = float.Parse(reader["yldj"].ToString().Trim());
                gctj = float.Parse(reader["gctj"].ToString().Trim());

                dycyl = float.Parse(reader["dycyl"].ToString().Trim());
                decyl = float.Parse(reader["decyl"].ToString().Trim());
                dscyl = float.Parse(reader["dscyl"].ToString().Trim());
                wxxz = float.Parse(reader["wxxz"].ToString().Trim());
                bycs = float.Parse(reader["bycs"].ToString().Trim());


                score8 = float.Parse(reader["score8"].ToString().Trim());
               
                //图片
                zxpic = reader["zxpic"].ToString().Trim();
                lxpic = reader["lxpic"].ToString().Trim();
                zxpic1 = reader["zxpic1"].ToString().Trim();
                lxpic1 = reader["lxpic1"].ToString().Trim();
                mxpic = reader["mfpic"].ToString().Trim();

            }

            con.Close();


        }

    }
}

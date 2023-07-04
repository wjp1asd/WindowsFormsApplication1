using System.Configuration;
using System.Data.SqlClient;

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

        // 离线校验考试次数判断，在线考试，
        public int wxxz;
        public int wxxz1;
        public int yqzdyl;

        //    [csfm] INT DEFAULT((-1)) NULL,
        //[ylxz] INT DEFAULT((-1)) NULL,
        //[xygb] INT DEFAULT((-1)) NULL,
        //[wxxz] INT DEFAULT((-1)) NULL,
        //[zdyltz] INT DEFAULT((-1)) NULL,
        //[sjlmsj] INT DEFAULT((-1)) NULL,
        //[azfm] INT DEFAULT((-1)) NULL,
        //[dkxyf] INT DEFAULT((-1)) NULL,
        //[gbylbqh] INT DEFAULT((-1)) NULL,
        //[yqzdyl] INT DEFAULT((-1)) NULL,
        //[gctj] INT DEFAULT((-1)) NULL,
        //[yldj] INT DEFAULT((-1)) NULL,
        //[dycyl] INT DEFAULT((-1)) NULL,
        //[decyl] INT DEFAULT((-1)) NULL,
        //[dscyl] INT DEFAULT((-1)) NULL,
        //[mfsyyl] INT DEFAULT((-1)) NULL,
        //[jyjl] INT DEFAULT((-1)) NULL,
        //[mfzjcl] INT DEFAULT((-1)) NULL,
        //[cxfm1] INT DEFAULT((-1)) NULL,
        //[wxxz1] INT DEFAULT((-1)) NULL,
        //[jyjg1] INT DEFAULT((-1)) NULL,
        //[azfm1] INT DEFAULT((-1)) NULL,
        //[bycs] INT DEFAULT((-1)) NULL,
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
        public int updatepath(string path,string pathname,string tid)
        {
            int i = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "update grade set"+ pathname +" = '" + path+"'  where testid = '" + tid + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                i++;
            }

            return i;
        }
        public int getGrade(string can,string qid)
        {
            int score1 = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();


            string sql = "select "+can+" from Grade where testid like  '%" + qid + "%'";


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
                wxxz = int.Parse(reader["wxxz"].ToString().Trim());
              
            }

            con.Close();


        }

    }
}

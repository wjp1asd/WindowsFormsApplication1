using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        public string lxpic, lxpic1, zxpic, zxpic1;
        public float csfm, ylxz, xygb, xygb1, xygb2, xygb3, xygb4, wxxz, zdyltz, sjlmsj, azfm, dkxyf,dkxyf1,dkxyf2,dkxyf3,dkxyf4, gbylbqh, yqzdyl, gctj, yldj, dycyl, decyl, dscyl;
        private float lxyqzdyl;
        public float mfsyyl, jyjl, mfzjcl, cxfm1, wxxz1, jyjg1, azfm1, bycs, score8;
        private float lxjielun;

        //在线填写记录
        public float zxzdyl,zxgczj,zxyldjfw,zxdyiyl,zxderyl,zxdsanyl,zxjielun;
    
        public int updateGrade(float score, string mode, string tid)
        {
            int i = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "update grade set [" + mode + "] = " + score + " where testid = '" + tid + "'";
            //MessageBox.Show(sql);
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


            string sql = "select [" + can + "] from Grade where testid like  '%" + qid + "%'";


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
        public float lxtotal, zxtotal, mftotal = 0;
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
                //在线 11个判分点


                azfm1 = float.Parse(reader["azfm1"].ToString().Trim());
                cxfm1 = float.Parse(reader["cxfm1"].ToString().Trim());
                wxxz1 = float.Parse(reader["wxxz1"].ToString().Trim());
                mfzjcl = float.Parse(reader["mfzjcl"].ToString().Trim());
                //在线填写记录
                //public float zxzdyl, zxgczj, zxyldjfw, zxdyiyl, zxderyl, zxdsanyl, zxjielun;
                zxzdyl = float.Parse(reader["zx-zdyl"].ToString().Trim());
                zxgczj = float.Parse(reader["zx-gczj"].ToString().Trim());
                zxyldjfw = float.Parse(reader["zx-yldjfw"].ToString().Trim());
                zxdsanyl = float.Parse(reader["zx-dsanyl"].ToString().Trim());
                zxderyl = float.Parse(reader["zx-deryl"].ToString().Trim());
                zxjielun = float.Parse(reader["zx-jielun"].ToString().Trim());
                zxtotal = wxxz1 + azfm1 + mfzjcl + cxfm1 +zxdyiyl+
                        zxderyl + zxdsanyl + zxgczj + zxzdyl + zxyldjfw + zxjielun;
                //离线25个判分点
                sjlmsj = float.Parse(reader["sjlmsj"].ToString().Trim());
                zdyltz = float.Parse(reader["zdyltz"].ToString().Trim());
               
                xygb = float.Parse(reader["gbxyf"].ToString().Trim());
                xygb1 = float.Parse(reader["gbxyf1"].ToString().Trim());
                xygb2 = float.Parse(reader["gbxyf2"].ToString().Trim());
                xygb3 = float.Parse(reader["gbxyf3"].ToString().Trim());
                xygb4 = float.Parse(reader["gbxyf4"].ToString().Trim());

                ylxz = float.Parse(reader["ylxz"].ToString().Trim());
                csfm = float.Parse(reader["csfm"].ToString().Trim());
                wxxz = float.Parse(reader["wxxz"].ToString().Trim());

                dkxyf = float.Parse(reader["dkxyf"].ToString().Trim());
                dkxyf1 = float.Parse(reader["dkxyf1"].ToString().Trim());
                dkxyf2 = float.Parse(reader["dkxyf2"].ToString().Trim());
                dkxyf3 = float.Parse(reader["dkxyf3"].ToString().Trim());
                dkxyf4 = float.Parse(reader["dkxyf4"].ToString().Trim());
                azfm = float.Parse(reader["azfm"].ToString().Trim());
                mfsyyl = float.Parse(reader["lx-mfsyyl"].ToString().Trim());
                yldj = float.Parse(reader["lx-yldj"].ToString().Trim());
                gctj = float.Parse(reader["lx-gctj"].ToString().Trim());
                dycyl = float.Parse(reader["lx-dycyl"].ToString().Trim());
                decyl = float.Parse(reader["lx-decyl"].ToString().Trim());
                dscyl = float.Parse(reader["lx-dscyl"].ToString().Trim());
                lxyqzdyl = float.Parse(reader["lx-yqzdyl"].ToString().Trim());
                // bycs ==复位得分
                bycs = float.Parse(reader["bycs"].ToString().Trim());

                lxjielun= float.Parse(reader["lx-jielun"].ToString().Trim());

                lxtotal =lxjielun+bycs+wxxz+dscyl+decyl+dycyl+gctj+yldj+mfsyyl+azfm+dkxyf+dkxyf1+dkxyf2+dkxyf3+dkxyf4+xygb+xygb1+xygb2+xygb3+xygb4
                +csfm+ ylxz+zdyltz+sjlmsj+lxyqzdyl;
                score8 = float.Parse(reader["score8"].ToString().Trim());
                mftotal = score4 + score5 + score6 + score8;
                //图片
                zxpic = reader["zxpic"].ToString().Trim();
                lxpic = reader["lxpic"].ToString().Trim();
                zxpic1 = reader["zxpic1"].ToString().Trim();
                lxpic1 = reader["lxpic1"].ToString().Trim();
                mxpic = reader["mfpic"].ToString().Trim();
                // MessageBox.Show(lxpic1);gbylbqh弃用
                gbylbqh = float.Parse(reader["gbylbqh"].ToString().Trim());
                updateGrade(lxtotal+zxtotal+mftotal, "path", tid);
            }

            con.Close();


        }

    }
}

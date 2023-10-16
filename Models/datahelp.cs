using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class datahelp
    {
        // 题库编号
        public static string[] QuestionIds;
        public static int CurrentQuestion = 1;
        public static int RemainTime = 600;
        public static int LxTime = 900;
        // 用户答案
        public static string[] UserAnswer;
        // 系统答案
        public static string[] Answer;
        // 批改
        public static string[] Correct;
        // 当前系统答案
        public static string curAnswer;
        public static string StudentId = "";
        public static string QId = "K04F2309041001";
        public string name;
        public string loginid;
        //1 离线 2在线 3工艺 4 研磨膏  5型号题 6 零配件 
        public static int SubId = 1;
        public static int time = 5;
        public static int stateTime = 1;
        // 考试状态
        public static int status = 0;
        //考试步走 
        public static int CurrentStep = 2;
        public static int CurrentStep1 = 2;
        // USB 接口定义
        public string id;
        public string print;
        public string scan;
        public string camera1;
        public string camera2;
        public string plc;
        public string plcbt, plcjy, plcst, plcsp, servo, DIxy, DIhw, DIB1, DIB2, DIB3, AIY1, AIy2, AIjy, MC;
        public string plc1;
        public string plcbt1, plcjy1, plcst1, plcsp1, servo1;
        public string link;
        public string mouse;
        public string color1, color2, color3, color4, color5;
        public string edyl = "1";
        public string mfzj = "1";

        public static string f1 = "0";
        public static string f2 = "0";
        public static string f3 = "0";
        // 题型数量
        public int lxnum, zxnum, gynum, xhnum, lpjnum, ymgnum;


        public void Initc()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from settings where Id=1";
            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {


                id = reader["idcard"].ToString();
                print = reader["print1"].ToString();
                scan = reader["scan"].ToString();
                camera2 = reader["camera2"].ToString();
                camera1 = reader["camera1"].ToString();
                mouse = reader["mouse"].ToString();
                link = reader["link"].ToString().Trim();

                color1 = reader["color1"].ToString();
                color2 = reader["color2"].ToString();
                color3 = reader["color3"].ToString();
                color4 = reader["color4"].ToString();
                color5 = reader["color5"].ToString();
                //离线端口配置
                plc = reader["plc"].ToString();
                plcbt = reader["plcbt"].ToString();
                plcjy = reader["plcjy"].ToString();
                plcst = reader["plcst"].ToString();
                plcsp = reader["plcsp"].ToString();
                servo = reader["servo"].ToString();
                //在线端口配置
                plc1 = reader["plc1"].ToString();
                plcbt1 = reader["plcbt1"].ToString();
                plcjy1 = reader["plcjy1"].ToString();
                plcst1 = reader["plcst1"].ToString();
                plcsp1 = reader["plcsp1"].ToString();
                servo1 = reader["servo1"].ToString();
                //数字量
                DIxy = reader["DIxy"].ToString();
                DIhw = reader["DIhw"].ToString();
                DIB1 = reader["DIB1"].ToString();
                DIB2 = reader["DIB2"].ToString();
                DIB3 = reader["DIB3"].ToString();
                //模拟量
                AIY1 = reader["AIY1"].ToString();
                AIy2 = reader["AIy2"].ToString();
                AIjy = reader["AIjy"].ToString();
                MC = reader["MC"].ToString();
                edyl = reader["edyl"].ToString();
                mfzj = reader["mfzj"].ToString();
                //题型数量
                lxnum = int.Parse(reader["lxnum"].ToString());
                zxnum = int.Parse(reader["zxnum"].ToString());
                gynum = int.Parse(reader["gynum"].ToString());
                xhnum = int.Parse(reader["xhnum"].ToString());
                lpjnum = int.Parse(reader["lpjnum"].ToString());
                ymgnum = int.Parse(reader["ymgnum"].ToString());
            }

            reader.Close();
            con.Close();

        }
    }
}

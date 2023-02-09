using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class datahelp
    {
        public static string[] QuestionIds = new string[10];
        public static int CurrentQuestion = 1;
        public static int RemainTime = 600;
        public static string[] UserAnswer = new string[10];
        public static string[] Answer = new string[10];
        public static string StudentId = "";
        public string name;
        public string loginid;
        //0 离线 1在线
        public static int SubId = 0;
        public static int time = 5;
        public static int stateTime = 1;
        // 考试状态
        private int status = 0;

        // USB 接口定义
        public string id;
        public string print;
        public string scan;
        public string camera1;
        public string camera2;
        public string plc;
        public string plcbt, plcjy, plcst, plcsp, DIxy, DIhw, DIB1, DIB2, DIB3, AIY1, AIy2, AIjy, MC;
        public string link;
        public string mouse;
        public string color1, color2, color3, color4, color5;
        public string edyl = "1";
        public string mfzj = "1";
        // 题型数量
        public int lxnum, zxnum, gynum, xhnum, lpjnum, yngnum;
        public int Status { get => status; set => status = value; }

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
                plc = reader["plc"].ToString();
                color1 = reader["color1"].ToString();
                color2 = reader["color2"].ToString();
                color3 = reader["color3"].ToString();
                color4 = reader["color4"].ToString();
                color5 = reader["color5"].ToString();

                plcbt = reader["plcbt"].ToString();
                plcjy = reader["plcjy"].ToString();
                plcst = reader["plcst"].ToString();
                plcsp = reader["plcsp"].ToString();
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
                yngnum = int.Parse(reader["ymgnum"].ToString());
            }

            reader.Close();
            con.Close();

        }
    }
}

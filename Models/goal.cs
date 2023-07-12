using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class goal
    {

        // USB 接口定义
        public string id;
        public string sub;
        public string name;
        public string des;
        public string state;
        public string score;



        public List<goal> getall(string sub = "离线校验")
        {
            List<goal> goals = new List<goal>();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from sct where sub ='" + sub + "'";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                goal a = new goal();

                a.id = reader["id"].ToString();
                a.des = reader["des"].ToString();
                a.name = reader["name"].ToString();
                a.state = reader["state"].ToString();
                a.score = reader["score"].ToString();
                a.sub = reader["sub"].ToString();
                goals.Add(a);
            }

            reader.Close();
            con.Close();
            return goals;
        }
    }
}

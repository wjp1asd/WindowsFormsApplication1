using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Models
{
    internal class Student
    {
        public String name;
        public String ID;
        public String Sex;
        public String Bumen;
        public string ava;
        public string loginid;
        public string password;

        
        public string Name { get => name; set => name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Sex1 { get => Sex; set => Sex = value; }
        public string Bumen1 { get => Bumen; set => Bumen = value; }
        public Student(string qrcode)
        {

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from student where idcard='" + qrcode + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                Name = reader["name"].ToString();
                ID = reader["idcard"].ToString();
                ava = reader["avatar"].ToString();
                Sex1 = reader["sex"].ToString();
                loginid = reader["loginid"].ToString();
                password = reader["password"].ToString();
                switch (Sex)
                {
                    case "1":
                        Sex = "女";
                        break;
                    case "0":
                        Sex = "男";
                        break;

                }
                Bumen1 = reader["bumen"].ToString();

            }

            con.Close();
        }


    }
}

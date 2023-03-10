using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Models
{
    internal class Student
    {
        String name;
        String ID;
        String Sex;
        String Bumen;

        //     [id] INT IDENTITY(1, 1) NOT NULL,

        //[name]     VARCHAR(50) NOT NULL,

        //[loginId]  VARCHAR(50) NOT NULL,

        //[password] VARCHAR(50) NOT NULL,

        //[sex]      VARCHAR(50) NULL,
        // [power]
        //     INT NULL,
        // [avatar]   IMAGE NULL,
        // [status]   INT NULL,
        // [bumen]    VARCHAR(50) NULL,
        // [phone] VARCHAR(50) NULL,
        // [confirm] VARCHAR(50) NULL,
        // [idcard] VARCHAR(50) NULL,
        // [date] VARCHAR(50) NULL,
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

                Sex1 = reader["sex"].ToString();
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

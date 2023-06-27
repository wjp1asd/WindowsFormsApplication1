using Emgu.CV.Aruco;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApplication1.Exam;

namespace WindowsFormsApplication1.Models
{
    public class pressure
    {
        public int  maz=0;
        public int  maz90= 0;
        public double f0, f1,f3, f2,f4;

        public List<pressure> getAll()
        {
            List<pressure> pp=new List<pressure>();
          

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from pressure ";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                pressure p = new pressure();
                p.f0 =double.Parse( reader["f0"].ToString().Trim());
                p.f1 = double.Parse(reader["f1"].ToString().Trim());
                p.f2 = double.Parse(reader["f2"].ToString().Trim());
                p.f3 = double.Parse(reader["f3"].ToString().Trim());
                p.f4 = double.Parse(reader["f4"].ToString().Trim());
                p.maz = int.Parse(reader["maz"].ToString().Trim());
                p.maz90 = int.Parse(reader["90maz"].ToString().Trim());
               
                pp.Add(p);  
            }

            con.Close();
return pp;

        }
    }
}

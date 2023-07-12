using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Models
{
    class Wucha
    {
        string id;
        string Type;
        string Area;
        string Value;
        string min;
        string max;

        public string Type1 { get => Type; set => Type = value; }
        public string Area1 { get => Area; set => Area = value; }
        public string Value1 { get => Value; set => Value = value; }
        public string Id { get => id; set => id = value; }
        public string Min { get => min; set => min = value; }
        public string Max { get => max; set => max = value; }

        public Wucha GetOne(string id)
        {
             Wucha w=new Wucha();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from wucha where id="+id.Trim();

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                w.Id = reader["id"].ToString();
                w.Type1 = reader["Type"].ToString();
                w.Value1 = reader["Value"].ToString();
                w.Area1 = reader["Area"].ToString();
                w.min = reader["min"].ToString().Trim();   
                w.max = reader["max"].ToString().Trim();   
            }

            con.Close();



            return w;
        }
        private Fuc ff = new Fuc();
        public List<Wucha> GetAll(string type)
        {

            List<Wucha> wucha = new List<Wucha>();

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
          //  string sql = "select * from wucha where Type = '" + type.Trim() + "'";
            string sql = "select * from wucha";
         //   ff.ShowInfoTip(sql);
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Wucha wu = new Wucha();
                wu.Id = reader["id"].ToString();
                wu.Type1 = reader["Type"].ToString();
                wu.Value1 = reader["Value"].ToString();
                wu.Area1 = reader["Area"].ToString();
                wu.Min = reader["min"].ToString();  
                wu.max = reader["max"].ToString() ; 
                wucha.Add(wu);
            }

            con.Close();
            return wucha;

        }


    }

  
}

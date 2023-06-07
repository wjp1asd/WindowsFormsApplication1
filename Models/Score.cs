using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Score
    {
        String score;
        String id;
        String state;
       

        public int getScore(string can) {
         int score1 = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();


            string sql = "select score from sct where can like  '%" + can + "%'";


            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                score1 = int.Parse(reader["score"].ToString().Trim());
            
            }


                return score1;
        }
    }
}

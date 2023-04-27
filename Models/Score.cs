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
       

        public int getScore(int type) {
         int score1 = 0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            string sql = "";
            switch (type) { 
            case 0:
                 sql = "select score from sct where id=1 and state=1";
                    break;

                case 1:
                  sql = "select score from sct where id=22 and state=1";
                    break;


                case 3:
                    break;

                case 4:
                    break;
            }
          
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

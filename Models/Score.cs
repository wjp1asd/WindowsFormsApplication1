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
    public class Score
    {
        String score;
        String id;
        String state;
       

        public float getScore(string can) {
            float score1 = 0;
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
               
                
                float.TryParse(reader["score"].ToString(),out score1);
                //MessageBox.Show(reader["score"].ToString()+score1);
            }


                return score1;
        }
    }
}

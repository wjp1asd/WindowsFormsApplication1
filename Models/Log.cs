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
    public class Log
    {
       public string qid;
        public string itemname;
        public string kfdm;
        public float kffz;
        public string kssj;
        Fuc ff=new Fuc();
        public int updatelog(string itemname, string kfdm, float kffz, string qid)
        {
            int i = 0;

            string kssj = string.Format("{0:G}",DateTime.Now);
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string strcomm = "insert into " + "Log" + "(itemname,kffz,kfdm,kssj,qid) VALUES(" +
                           "'" + itemname.Trim() + "'" + "," +kffz
                          + "," +
                             "'" + kfdm.Trim() + "'" + "," +
                               "'" + kssj.Trim() + "'" + "," +
                                "'" + qid.Trim() + "'" + ")";
            con.Open();
          //  MessageBox.Show(strcomm);
            SqlCommand comm = new SqlCommand(strcomm, con);
            comm.ExecuteNonQuery();
            ff.ShowInfoTip("已更新");
            con.Close();


            return i;
        }
    }
}

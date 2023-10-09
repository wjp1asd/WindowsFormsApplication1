using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Models
{
    public class Log
    {
        public string qid;
        public string itemname;
        public string kfdm;
        public float kffz;
        public string kssj;
        Fuc ff = new Fuc();
        public int updatelog(string itemname, string kfdm, float kffz, string qid)
        {
            int i = 0;
            // 确保只有一同类型
            string sql = "select * from log where kfdm ='" + kfdm + "'";
            string kssj = string.Format("{0:G}", DateTime.Now);

            if (ff.RC1(sql).Length > 0)
            {
                // 有记录更新
                string strcomm = "update Log set itemname =" +
                               "'" + itemname.Trim() + "'" + ","
                               +"kffz =" + kffz + ","+
                               " kssj ="
                               +"'" + kssj.Trim() + "'" + "," +"qid ="+
                                    "'" + qid.Trim() + "'" + "where kfdm = '"+kfdm+"'";
                //  MessageBox.Show(strcomm);
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();

                SqlCommand comm = new SqlCommand(strcomm, con);
                comm.ExecuteNonQuery();
                // ff.ShowInfoTip("已更新");
                con.Close();

            }
            else
            {
                // 无记录 创建
                string strcomm = "insert into " + "Log" + "(itemname,kffz,kfdm,kssj,qid) VALUES(" +
                              "'" + itemname.Trim() + "'" + "," + kffz
                             + "," +
                                "'" + kfdm.Trim() + "'" + "," +
                                  "'" + kssj.Trim() + "'" + "," +
                                   "'" + qid.Trim() + "'" + ")";
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                //  MessageBox.Show(strcomm);
                SqlCommand comm = new SqlCommand(strcomm, con);
                comm.ExecuteNonQuery();
                // ff.ShowInfoTip("已更新");
                con.Close();

            }



            return i;
        }
    }
}

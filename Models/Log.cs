﻿using System;
using System.Configuration;
using System.Data.SqlClient;
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
        Fuc ff = new Fuc();
        public string strcomm;
        public void clear(string qid,int i) {
           
            // 0 all 1 lx 2 zx 3 mf
            switch (i) {

                case 0:
                     strcomm = " delete from Log where [qid] = '"+qid.Trim()+"'";
                    break;
                case 1:
                 //   delete from log where kfdm like 'lx-%' and qid = '1ppXT82ZZDTmxb44zJ0jNg==  '
                     strcomm = " delete from Log where kfdm like 'lx-%' and qid = '"+qid.Trim()+"'";
                    break;
                case 2:
                    strcomm = " delete from Log where kfdm like 'zx-%' and qid = '"+qid.Trim()+"'";
                    break;
                case 3:
                    strcomm = " delete from Log where kfdm like 'mf-%' and qid = '"+qid.Trim()+"'";
                    break;
            }
                       
               
                              
               MessageBox.Show(strcomm);
                string connectionString = ConfigurationManager.AppSettings["sqlc"];
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();

                SqlCommand comm = new SqlCommand(strcomm, con);
                comm.ExecuteNonQuery();
             
                con.Close();


            }
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

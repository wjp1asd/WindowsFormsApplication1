using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Questions;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WindowsFormsApplication1.Models
{
    internal class TestRecord
    {
        String queque;
        String ksname;
        String ksId;
        String ksdate;
        String lxyl;
        String lxlx;
        String zxyl;
        String zxlx;
        String adfxh;
        String qrcode;
        String lxquestions;
        String zquestions;
        public string Queque { get => queque; set => queque = value; }
        public string Ksname { get => ksname; set => ksname = value; }
        public string KsId { get => ksId; set => ksId = value; }
        public string Ksdate { get => ksdate; set => ksdate = value; }
        public string Lxyl { get => lxyl; set => lxyl = value; }
        public string Lxlx { get => lxlx; set => lxlx = value; }
        public string Zxyl { get => zxyl; set => zxyl = value; }
        public string Zxlx { get => zxlx; set => zxlx = value; }
        public string Adfxh { get => adfxh; set => adfxh = value; }
        public string Qrcode { get => qrcode; set => qrcode = value; }
        public string Lxquestions { get => lxquestions; set => lxquestions = value; }
        public string Zquestions { get => zquestions; set => zquestions = value; }

        public TestRecord()
        {

            //            [Id] INT NOT NULL,
            //[queue] NCHAR(50) NULL,
            //[ksname] NCHAR(50) NULL,
            //[ksdate] NCHAR(50) NULL,
            //[ksId] NCHAR(50) NULL,
            //[lxyl] NCHAR(50) NULL,
            //[lxlx] NCHAR(50) NULL,
            //[zxyl] NCHAR(50) NULL,
            //[zxlx] NCHAR(50) NULL,
            //[aqfxh] NCHAR(50) NULL,
            //[qrcode] NCHAR(50) NULL,
        }
        public List<decimal> Yali()
        {
            List<decimal> yali = new List<decimal>();
           
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from Yali";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                yali.Add(decimal.Parse( reader["ztyli"].ToString()));
            }

            con.Close();



            return yali;
        }
        public String Wucha() {
            String wu="";
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top 1  type from wucha order by newid()";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                wu = reader["type"].ToString();
            }

            con.Close();

          

            return wu;
        }

        public String Aqf()
        {
            String wu = "";
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top 1  Subname from Aquanfa order by newid()";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                wu = reader["subname"].ToString();
            }

            con.Close();



            return wu;
        }


        public TestRecord LastRecord()
        {
            TestRecord t = new TestRecord();
            int a = 0;
            // Select* From dbo.S_ServiceDetailed Where Convert(varchar(10),[数据库添加时间字段], 120) = Convert(varchar(10), getDate(), 120)
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select Top 1 * from TestRecord order by id desc";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                t.lxyl = reader["lxyl"].ToString();
                t.zxyl = reader["zxyl"].ToString();
            }

            con.Close();

            return t;

        }
            public int  Queuex()
        {

            int a=0; 
           // Select* From dbo.S_ServiceDetailed Where Convert(varchar(10),[数据库添加时间字段], 120) = Convert(varchar(10), getDate(), 120)
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select count(*) as num  from TestRecord Where Convert(varchar(10),[ksdate], 120) = Convert(varchar(10), getDate(), 120)";
          
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                a = int.Parse(reader["num"].ToString())+1;
            }
  
            con.Close();

            return a;
        }

        public TestRecord getRecord(string qrcode)
        {
            TestRecord t = new TestRecord();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode='" + qrcode + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                t.queque = reader["queue"].ToString().Trim();
                t.ksdate = reader["ksdate"].ToString().Trim();
                t.ksname = reader["ksname"].ToString().Trim();
                t.ksId = reader["ksId"].ToString().Trim();
                t.lxyl = reader["lxyl"].ToString().Trim();
                t.zxyl = reader["zxyl"].ToString().Trim();
                t.lxlx = reader["lxlx"].ToString().Trim();
                t.zxlx = reader["zxlx"].ToString().Trim();
                t.adfxh = reader["aqfxh"].ToString().Trim();
                t.qrcode = reader["qrcode"].ToString().Trim();
                t.lxquestions = reader["lxquestions"].ToString();
                t.zquestions = reader["zxquestions"].ToString();
            }

            con.Close();
            return t;
        }
      
    }
}

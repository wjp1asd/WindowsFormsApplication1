using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

        public TestRecord(){

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
        public TestRecord(string qrcode) {

            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode='" + qrcode + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
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
                Queque = reader["queque"].ToString();
                Ksdate = reader["ksdate"].ToString();
                Ksname = reader["ksname"].ToString();
                KsId = reader["ksId"].ToString();
                Lxyl = reader["lxyl"].ToString();
                Zxyl = reader["zxyl"].ToString();
                Lxlx = reader["lxlx"].ToString();
                Zxlx = reader["zxlx"].ToString();
                Adfxh = reader["aqfxh"].ToString();
                Qrcode = reader["qrcode"].ToString();
            }

            con.Close();
        }
    }
}

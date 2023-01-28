using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Admin.Questions.zaixian
{
    public partial class Online_JiaoYan : Form
    {
        public Online_JiaoYan()
        {
            InitializeComponent();
            InitUI();

        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.textBox1.Text = a.edyl;
            this.textBox2.Text=a.mfzj;



          




        }

       


        private void button2_Click_1(object sender, EventArgs e)
        {
            Online a = new Online();
            a.Show();
            this.Close();
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = this.textBox1.Text.Trim();
            string b = this.textBox2.Text.Trim();

            if (a.Length==0||b.Length==0) {
                MessageBox.Show("参数不能为空");
                return;  

            }
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);

            String str1 = "Update settings set edyl='" + a + "',mfzj='" +b + "' where id=1";

            // String str1 = "INSERT INTO settings (color1,color2,color3,color4,color5) VALUES('" + a+ "','" + b + "','" + c+"','" + d + "','" + f + "')";
            MessageBox.Show(str1);
            SqlCommand com = new SqlCommand(str1, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            MessageBox.Show("保存成功！,退出程序后加载");
            con.Close();
        }
    }
}

using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Questions;

namespace WindowsFormsApplication1.Exam
{
    public partial class record : Form
    {

        
        public record()
        {
            InitializeComponent();
        }
        string tper = "";

        string Id = "1";
        public record(string id,string type="离线")
        {
            InitializeComponent();
            Id = id;
            tper = type;    
            Initc();
            this.label2.Text = type + this.label2.Text;
            this.printDocument1.OriginAtMargins = true;//启用页边距

        }
        Score sc = new Score();
        //要求整定压力 公称直径 压力等级范围 第一次 第二次 第三次 密封压力
        float yqzdyl = 0;
        float gctj = 0;
        float yldj = 0;
        float dycyl,decyl,dscyl,mfsyyl = 0;
        float azfm1 = 0;
      //  Grade g = new Grade();
        private void InitScore()
        {
            yqzdyl = sc.getScore("yqzdyl");
            gctj = sc.getScore("gctj");
            yldj = sc.getScore("yldj");
            dycyl = sc.getScore("dycyl");
            decyl = sc.getScore("decyl");
            dscyl = sc.getScore("dscyl");
            mfsyyl = sc.getScore("mfsyyl");
            this.label17.Text = "密封面直径测量得分：" + mfzjcl + "拆卸阀帽得分：" + cxfm1 + "误差选择得分：" + wxxz1 + "校验结果得分：" + jyjg1 + "安装阀帽得分：" + azfm1;
            g.updateGrade(0, "mfzjcl", datahelp.QId);
            g.updateGrade(0, "cxfm1", datahelp.QId);
            g.updateGrade(0, "wxxz1", datahelp.QId);
            g.updateGrade(0, "jyjg1", datahelp.QId);
            g.updateGrade(0, "azfm1", datahelp.QId);

        }


        public void Initc()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from lxjl where id= 1" ;
            datahelp a = new datahelp();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {




                this.label1.Text = "编号：" + reader["bianhao"].ToString().Trim();
                this.label40.Text = reader["shiyongdanwei"].ToString().Trim();
                this.label41.Text = reader["shebeidaima"].ToString().Trim();

                justcheck(this.checkBoxw1, reader["w1"].ToString().Trim());
                justcheck(this.checkBoxw2, reader["w2"].ToString().Trim());
                justcheck(this.checkBow3, reader["w3"].ToString().Trim());
                justcheck(this.checkBow4, reader["w4"].ToString().Trim());
                justcheck(this.checkBow5, reader["w5"].ToString().Trim());
                justcheck(this.checkBow6, reader["w6"].ToString().Trim());
                justcheck(this.checkBow7, reader["c1"].ToString().Trim());
                justcheck(this.checkBow8, reader["c2"].ToString().Trim());
                justcheck(this.checkBow9, reader["c3"].ToString().Trim());
                justcheck(this.result, reader["result"].ToString().Trim());
                //     this.checkBoxw1.Checked = reader["shebeidaima"].ToString();

            }

            reader.Close();
            con.Close();

        }

        private void justcheck(CheckBox c, string m)
        {
            if (m == "1")
            {
                c.Checked = true;
            }
            else
            {

                c.Checked = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
          
            if (tper == "离线") {
                OFF off = new OFF(datahelp.QId);
                off.Show();
                datahelp.CurrentStep1 = 4;
            }
            if (tper == "在线")
            {
                zaixianjiaoyan z=new zaixianjiaoyan();
                z.Show();
                datahelp.CurrentStep1 = 4;
            }

            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //打印内容 为 整个Form
            Image myFormImage;
            myFormImage = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(myFormImage);
            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            e.Graphics.DrawImage(myFormImage, 0, 0);
        }
        Grade g = new Grade();
        Fuc ff=new Fuc();
        private void record_Load(object sender, EventArgs e)
        {
            //g.getOne(datahelp.QId);

            if (tper == "离线")
            {
                if (g.getGrade("yqzdyl",datahelp.QId) > -1)
                {

                    ff.ShowErrorDialog("重复考试");

                    
                    if (tper == "离线")
                    {
                        OFF off = new OFF(datahelp.QId);
                        off.Show();
                        datahelp.CurrentStep1 = 4;
                    }
                    if (tper == "在线")
                    {
                        zaixianjiaoyan z = new zaixianjiaoyan();
                        z.Show();
                        datahelp.CurrentStep1 = 4;
                    }

                    this.Close();

                }

                g.updateGrade(0, "yqzdyl", datahelp.QId);


            }
            else {
               

            }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = ConfigurationManager.AppSettings["sqlc"];
            //SqlConnection con = new SqlConnection(connectionString);
            //string a = this.edyl.Text.Trim();
            //string b = this.zj.Text.Trim();
            //string c = string.Join(",", datahelp.Correct);
            //double d = score;
            //string str1 = "";
            //string  str1 = "Update Grade set lxquestions='" + a + "',lxanswer='" + b + "',lxcorrect='" + c + "',score2='" + d

            //  + "' where testid= '" + datahelp.QId.Trim() + "'";


            this.ShowSuccessDialog("保存成功");

        }
    }
}


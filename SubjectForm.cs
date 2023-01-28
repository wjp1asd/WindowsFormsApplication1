using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class SubjectForm : Form
    {
        int[] arr;
        public SubjectForm()
        {
            InitializeComponent();
            arr = Array();
    
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from subject";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                this.cboSubject.Items.Add(reader["subname"]);
            }
            reader.Close();
            con.Close();

        }

        private void btnCanle_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否关闭", "提示", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                this.Close();
            }

        }

        
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (this.cboSubject.SelectedIndex < 0)
            {
                MessageBox.Show("请选择科目");

            }
            else
            {
                string subName = this.cboSubject.SelectedItem.ToString();
                int subId = GetSubjectIdByName(subName);

                GetAllQuestionIdsBySubId(subId.ToString());
                datahelp.CurrentQuestion = 1;
                datahelp.RemainTime = 600;
                InitUserAnswer();
                InitAnswer();
               
                QuestionForm frm = new QuestionForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Hide();
                
            }
        }
        
        
        private void InitAnswer()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select top 20 Answer from question";
            SqlCommand com = new SqlCommand(sql,con);
            con.Open();      
            SqlDataReader reader = com.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
               
                datahelp.Answer[arr[i]] = reader["Answer"].ToString();
                i++;
                
            }
            reader.Close();
            con.Close();
           
        }

        private void InitUserAnswer()
        {
            for (int i = 0; i < 20; i++)
            {
                datahelp.UserAnswer[i] = "未回答";
            }
        }

           
            private int GetSubjectIdByName(string subName)
            {
                int subId =0;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
              string sql = string.Format("select id from subject where subName='{0}'",subName);
              SqlCommand com = new SqlCommand(sql,con);
                con.Open();
                subId = int.Parse(com.ExecuteScalar().ToString());
                con.Close();
                return subId;
            }
            private void GetAllQuestionIdsBySubId(string subId)
            {
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
                string sql = string.Format("select top 20 id from question where subId=" + subId.ToString());
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {

                    datahelp.QuestionIds[arr[i]] = int.Parse(reader["Id"].ToString());
                    i++;



                }
            }
        public int[]  Array()
        {
              int[] arr = new int[20];
                
                for (int i = 0; i < 20; i++)
                {
                    arr[i] = i;

                }
                Random rand = new Random();
                for (int j = 0; j < 20; j++)
                {
                    int t1 = rand.Next(0, 20);
                    int t2 = rand.Next(0, 20);
                    int temp = 0;
                    temp = arr[t1];
                    arr[t1] = arr[t2];
                    arr[t2] = temp;
                }
                return arr ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    




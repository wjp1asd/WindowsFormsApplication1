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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using WindowsFormsApplication1.Models;
using AutoWindowsSize;

namespace WindowsFormsApplication1.Admin.Students
{
   
    public partial class studentRecord : Form
    {

        int row;
        String TableName = "testRecord";
        private Fuc ff = new Fuc();
        Boolean all = false;
        StringBuilder s1;
        public studentRecord(string id)
        {
            if (id.Length==0) {
               
               ff.ShowInfoTip("当前学生信息有误");
                return;
            }
           // Select TestRecord. *from TestRecord where TestRecord.ksid = (select idcard from student where id = 9) 
            InitializeComponent();
            string sql = "select * from " + TableName + " where  ksid = (select idcard from student where id = " + id.Trim()+")"; 
            InitTable(sql);
        }
        private void InitTable(string sql)
        {
            this.dataGridView1.Visible = true;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);

            DataSet ds = new DataSet();
            sda.Fill(ds, "question");
            //   qs = ds.Tables[0];

            this.dataGridView1.DataSource = ds.Tables["question"];
            row = this.dataGridView1.RowCount;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        AutoAdaptWindowsSize awt;
        private void groupBox1_Resize(object sender, EventArgs e)
        {


            if (awt != null)
            {

                awt.FormSizeChanged();
            }
        }


        private void StudentSet_Load(object sender, EventArgs e)
        {
          
        }
        private void studentRecord_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
    }
}

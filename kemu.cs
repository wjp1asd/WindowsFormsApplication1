using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class kemu : Form
    {
        public kemu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Import frm = new Import("1");
                frm.GetData(this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), true);
                frm.Show();

            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("是否删除科目:" + this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    MessageBox.Show("删除成功");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select*from subject where subName like '%" + this.textBox1.Text + "%'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);

            DataSet ds = new DataSet();
            sda.Fill(ds, "sbujct");
            this.dataGridView1.DataSource = ds.Tables[0];

        }

        private void et()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Import frm = new Import("1");
            frm.GetData("", "", false);
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

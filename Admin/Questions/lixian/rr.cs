using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Admin.Questions.lixian
{
    public partial class rr : Form
    {
        public rr()
        {
            InitializeComponent();
        }

        private void rr_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“examonlineDataSet.lxjl”中。您可以根据需要移动或移除它。
            this.lxjlTableAdapter.Fill(this.examonlineDataSet.lxjl);
            // TODO: 这行代码将数据加载到表“examonlineDataSet.lxjl”中。您可以根据需要移动或移除它。
            this.lxjlTableAdapter.Fill(this.examonlineDataSet.lxjl);
            //sthis.reportViewer1.LocalReport.DataSources.Add("date");
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

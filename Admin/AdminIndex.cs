using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Settings;

namespace WindowsFormsApplication1
{
   

    public partial class AdminIndex : Form
    {
        private fullScreen ff;
        public AdminIndex()
        {
            InitializeComponent();
          //   ff = new fullScreen(this);

          
            
            InitUI();

        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();
            this.BackColor= System.Drawing.ColorTranslator.FromHtml(a.color4);
            this.label2.ForeColor= System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button4.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button5.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button6.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //    MessageBox.Show(a.color1);

            this.label2.Text = a.link;



        }
        private void button1_Click(object sender, EventArgs e)
        {
            QuestionSet q = new QuestionSet();
            q.Show();
            this.Close();
        }

        private void 管理员界面_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoalSet q = new GoalSet();
            q.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PeopleSet q = new PeopleSet();
            q.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentSet q = new StudentSet();
            q.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultSet q = new ResultSet();
            q.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings1 q = new Settings1();
            q.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void AdminIndex_Resize(object sender, EventArgs e)
        {
           
          //     ff.setTag(this);
          //      ff.setSize(this);
         
           // Trace.WriteLine("宽度：" + this.Width);
          //  Trace.WriteLine("高度：" + this.Height);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

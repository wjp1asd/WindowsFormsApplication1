using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ShowButtoAndLable();
            // this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
        }

        private void ShowButtoAndLable()
        {

            datahelp c = new datahelp();
            c.Initc();
            int num = c.lxnum;
            switch (datahelp.SubId)
            {
                case 1:
                    num = c.lxnum;
                    break;
                case 2:
                    num = c.zxnum;
                    break;
                case 3:
                    num = c.gynum;
                    break;
                case 4:
                    num = c.ymgnum;
                    break;
                case 5:
                    num = c.xhnum;
                    break;
                case 6:
                    num = c.lpjnum;
                    break;

            }

            int btnX = 20;
            int btnY = 60;
            int IblX = 120;
            int IblY = 80;
            for (int i = 0; i < num; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(btnX, btnY);
                btn.Text = string.Format("第{0}题", i + 1);
                btn.Tag = i;
                // btn.Click += new EventHandler(btn_Click);
                btn.Size = new Size(60, 40);
                Label Ibl = new Label();
                Ibl.Location = new Point(IblX, IblY);

                Ibl.BackColor = System.Drawing.Color.Transparent;
                Ibl.Text = datahelp.UserAnswer[i].Trim();
                Ibl.Size = new Size(61, 32);
                this.Controls.Add(Ibl);
                this.Controls.Add(btn);
                btnX += 240;
                IblX += 240;
                if ((i + 1) % 4 == 0)
                {
                    btnX = 20;
                    IblX = 120;
                    btnY += 70;
                    IblY += 70;

                }
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int qid = int.Parse(btn.Tag.ToString());
            datahelp.CurrentQuestion = qid + 1;
            LBJForm frm = new LBJForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            if (datahelp.RemainTime > 0)
            {
                datahelp.RemainTime--;
                int min = datahelp.RemainTime / 60;
                int sec = datahelp.RemainTime % 60;
                this.lbltime.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                this.timer1.Stop();
                ff.ShowInfoTip("时间到了，请交卷");
                Score1 s = new Score1();
                s.Show();
                this.Close();
            }


        }

        private Fuc ff = new Fuc();
        private void btnsend_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            Score1 s = new Score1();
            s.Show();
            this.Close();

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }
    }

}

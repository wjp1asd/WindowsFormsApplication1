using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam
{
    public partial class LBJForm : Form
    {
        Fuc f = new Fuc();
        TestRecord t;
        QuestionA qq = new QuestionA();
        public LBJForm()
        {
            InitializeComponent();
        }

        public LBJForm(String qrcode = "EmcaBvClo9bJ6NkgbLWqRg==")
        {


            InitializeComponent();
            t = new TestRecord();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode='" + qrcode + "'";
            // MessageBox.Show(sql);
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                t.Queque = reader["queue"].ToString();

                t.Ksdate = reader["ksdate"].ToString();

                t.Ksname = reader["ksname"].ToString();

                t.KsId = reader["ksId"].ToString();

                t.Lxyl = reader["lxyl"].ToString();

                t.Lxlx = reader["lxlx"].ToString();
                t.Zxyl = reader["zxyl"].ToString();

                t.Zxlx = reader["zxlx"].ToString();
                t.Lpjuestions = reader["lpjquestions"].ToString();



                t.Adfxh = reader["aqfxh"].ToString();

                t.Qrcode = reader["qrcode"].ToString();
            }
            con.Close();
            datahelp.StudentId = t.KsId;
            // MessageBox.Show(t.KsId);

            if (qrcode.Length == 0)
            {
                f.ShowErrorDialog("考试信息有误");


            }
            else
            {
                // 加载题库
                datahelp.CurrentQuestion = 1;

                datahelp.QuestionIds = t.Lpjuestions.Split(',');
                datahelp.Answer = qq.Answer(t.Lpjuestions).Split(',');
                LoadQuestion();
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            InitbtnUp();
            InitbtnNext();
            ShowInfo();

        }
        private void InitbtnUp()
        {
            if (datahelp.CurrentQuestion < 2)
            {
                this.btnUp.Enabled = false;
                this.btnUp.Text = "已是第一题";


            }
            else
            {

                this.btnUp.Enabled = true;
                this.btnUp.Text = "上一题";
            }


        }
        private void InitbtnNext()
        {
            if (datahelp.CurrentQuestion > 9)
            {
                this.btnNext.Text = "答题卡";
            }

        }
        private void LoadQuestion()
        {

            string questionId = datahelp.QuestionIds[datahelp.CurrentQuestion - 1];


            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from ymg where id =" + questionId.ToString().Trim();
            MessageBox.Show(sql);
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                // this.txtQuestionContent.Text = reader["question"].ToString();
                this.rdbA.Text = "A: " + reader["optionA"].ToString();
                this.rdbB.Text = "B: " + reader["optionB"].ToString();
                this.rbdC.Text = "C: " + reader["optionC"].ToString();
                this.rdbD.Text = "D: " + reader["optionD"].ToString();
                this.pictureBox1.ImageLocation = reader["image"].ToString();


            }

            reader.Close();
            con.Close();


        }

        private void ShowInfo()
        {
            this.label7.Text = datahelp.CurrentQuestion.ToString();
            this.label3.Text = "您的选择：" + string.Join(",", datahelp.UserAnswer);
            this.label6.Text = "系统答案：" + string.Join(",", datahelp.Answer);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (datahelp.CurrentQuestion < 10)
            {
                datahelp.CurrentQuestion++;
                CheckNextButtonText();

                LoadQuestion();
                SelectOption();
                ShowInfo();
            }
            else
            {
                this.btnNext.Text = "提交";
                btnAnswer_Click(sender, e);
            }
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
                MessageBox.Show("时间到了，请交卷");
                AnswerForm frm = new AnswerForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }


        }

        private void CheckNextButtonText()
        {
            if (datahelp.CurrentQuestion < 10)
            {
                this.btnNext.Text = "下一题";
                btnUp.Enabled = true;
                btnUp.Text = "上一题";
            }
            else
            {
                this.btnNext.Text = "答题卡";
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            AnswerForm frm = new AnswerForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }
        private void SelectOption()
        {
            switch (datahelp.UserAnswer[datahelp.CurrentQuestion - 1])
            {
                case "A": this.rdbA.Checked = true; break;
                case "B": this.rdbB.Checked = true; break;
                case "C": this.rbdC.Checked = true; break;
                case "D": this.rdbD.Checked = true; break;
                default:
                    this.rdbA.Checked = false;
                    this.rdbB.Checked = false;
                    this.rbdC.Checked = false;
                    this.rdbD.Checked = false;
                    break;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (datahelp.CurrentQuestion > 1)
            {
                datahelp.CurrentQuestion--;
                CheckUpButtonText();
                ShowInfo();
                LoadQuestion();
                SelectOption();

            }

        }
        private void CheckUpButtonText()
        {
            if (datahelp.CurrentQuestion > 0)
            {
                this.btnUp.Text = "上一题";


            }
            else
            {
                this.btnUp.Text = "已是第一题";
                btnUp.Enabled = false;
            }
        }



        private void rdbA_Click(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            string option = rdb.Tag.ToString();

            datahelp.UserAnswer[datahelp.CurrentQuestion - 1] = option;
            MessageBox.Show(string.Join("", datahelp.UserAnswer));


        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestionContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closing(object sender, FormClosedEventArgs e)
        {

            f.ShowWarningTip("中途退出，成绩将不合格请谨慎选择");
            Process.GetCurrentProcess().Kill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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



        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
        private void LBJForm_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
        }
    }
}

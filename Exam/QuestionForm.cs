using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Exam.MF;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class QuestionForm : Form


    {
        int num = 1;

        Fuc f = new Fuc();
        TestRecord t;
        QuestionA qq = new QuestionA();
        Grade g = new Grade();
        string[] correct;
        public QuestionForm()
        {
            InitializeComponent();
            this.label6.Hide();
            this.label7.Hide();
            this.label8.Hide();
            this.label9.Hide();

        }
        public QuestionForm(String qrcode, String subtype = "1")
        {
            InitializeComponent();

            t = new TestRecord();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode = '" + qrcode + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            g.getOne(qrcode);
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
                t.Lxquestions = reader["lxquestions"].ToString().Trim();
                t.Zquestions = reader["zxquestions"].ToString().Trim();
                t.Gyquestions = reader["gyquestions"].ToString().Trim();
                t.Ymgquestions = reader["ymgquestions"].ToString().Trim();

                t.Adfxh = reader["aqfxh"].ToString();

                t.Qrcode = reader["qrcode"].ToString();
            }
            con.Close();
            datahelp.StudentId = t.KsId;
            datahelp.CurrentQuestion = 1;
            switch (subtype)
            {
                case "1":
                    this.Text = "离线校验答题";
                    if (t.Lxquestions.Length > 0)
                    {
                        datahelp.QuestionIds = t.Lxquestions.Split(',');
                        datahelp.SubId = 1;

                        //if (int.Parse(g.score2) > -1) {

                        //    f.ShowErrorDialog("重复考试");

                        //    this.btnUp.Enabled = false;
                        //    this.btnNext.Enabled = false;   
                        //}
                        //g.updateGrade(0,"score2",datahelp.QId);

                    }
                    else
                    {

                        f.ShowErrorDialog("题目已不存在于当前题库，请重新抽题");
                    }

                    break;
                case "2":
                    this.Text = "在线校验答题";
                    if (t.Zquestions.Length > 0)
                    {
                        datahelp.QuestionIds = t.Zquestions.Split(',');
                        datahelp.SubId = 2;

                        //if (int.Parse(g.score1) > -1)
                        //{

                        //    f.ShowErrorDialog("重复考试");

                        //    this.btnUp.Enabled = false;
                        //    this.btnNext.Enabled = false;
                        //}

                        //g.updateGrade(0, "score1", datahelp.QId);
                    }
                    else
                    {
                        f.ShowErrorDialog("题目已不存在于当前题库，请重新抽题");

                    }
                    break;
                case "3":
                    this.Text = "工艺校验答题";
                    if (t.Gyquestions.Length > 0)
                    {
                        datahelp.QuestionIds = t.Gyquestions.Split(',');
                        datahelp.SubId = 3;

                        //if (int.Parse(g.score3) > -1)
                        //{

                        //    f.ShowErrorDialog("重复考试");

                        //    this.btnUp.Enabled = false;
                        //    this.btnNext.Enabled = false;
                        //}
                        //g.updateGrade(0, "score3", datahelp.QId);
                    }
                    else
                    {
                        f.ShowErrorDialog("题目已不存在于当前题库，请重新抽题");

                    }
                    break;

                case "4":
                    this.Text = "研磨膏答题";
                    if (t.Ymgquestions.Length > 0)
                    {
                        //   MessageBox.Show(t.Ymgquestions.Trim().Split(',') + ""+ t.Ymgquestions.Trim());

                        datahelp.QuestionIds = t.Ymgquestions.Trim().Split(',');


                        datahelp.SubId = 4;

                        //if (int.Parse(g.score7) > -1)
                        //{

                        //    f.ShowErrorDialog("重复考试");
                        //    this.btnUp.Enabled = false;
                        //    this.btnNext.Enabled = false;

                        //}
                        //g.updateGrade(0, "score7", datahelp.QId);
                    }
                    else
                    {
                        f.ShowErrorDialog("题目已不存在于当前题库，请重新抽题");

                    }
                    break;

            }
            if (qrcode.Length == 0)
            {
                f.ShowErrorDialog("考试信息有误");


            }
            else
            {
                // 加载题库

                LoadQuestion();
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            datahelp c = new datahelp();
            c.Initc();
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


            }

            this.label2.Text = "总题数：" + (num) + "，当前：";
            datahelp.Answer = new string[num];
            datahelp.UserAnswer = new string[num];
            datahelp.Correct = new string[num];
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;
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
            if (datahelp.CurrentQuestion == num)
            {
                this.btnNext.Text = "答题卡";
            }

        }
        private void LoadQuestion()
        {

            string questionId = datahelp.QuestionIds[datahelp.CurrentQuestion - 1];


            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from question where id =" + questionId.ToString().Trim();

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string a = reader["optionA"].ToString();
                string b = reader["optionB"].ToString();
                string c = reader["optionC"].ToString();
                string d = reader["optionD"].ToString();
                datahelp.curAnswer = reader["answer"].ToString();
                this.label7.Text = datahelp.curAnswer;
                this.label10.Text = "[" + reader["type"].ToString().Trim() + "]";
                if (reader["type"].ToString().Trim() == "判断题")
                {
                    this.txtQuestionContent.Text = reader["question"].ToString();
                    this.rdbA.Text = "对 ";
                    this.rdbA.Tag = "Y";
                    this.rdbB.Text = "错 ";
                    this.rdbB.Tag = "N";
                    this.rdbC.Hide();
                    this.rdbD.Hide();



                }
                else
                {
                    this.txtQuestionContent.Text = reader["question"].ToString();
                    this.rdbA.Show();
                    this.rdbA.Tag = "A";
                    this.rdbB.Show();
                    this.rdbB.Tag = "B";
                    this.rdbC.Show();
                    this.rdbC.Tag = "C";
                    this.rdbD.Show();
                    this.rdbD.Tag = "D";

                    if (a.Trim().Length > 0)
                    {
                        this.rdbA.Text = "A: " + a;
                    }
                    else
                    {
                        this.rdbA.Hide();
                    }
                    if (b.Trim().Length > 0)
                    {
                        this.rdbB.Text = "B: " + b;
                    }
                    else
                    {
                        this.rdbB.Hide();
                    }
                    if (c.Trim().Length > 0)
                    {
                        this.rdbC.Text = "C: " + c;
                    }
                    else
                    {
                        this.rdbC.Hide();
                    }
                    if (d.Trim().Length > 0)
                    {
                        this.rdbD.Text = "D: " + d;
                    }
                    else
                    {
                        this.rdbD.Hide();
                    }




                }

            }

            reader.Close();
            con.Close();


        }

        private void ShowInfo()
        {
            this.label3.Text = "" + (int.Parse(datahelp.CurrentQuestion.ToString()));
            this.label6.Text = "您的选择：" + string.Join(",", datahelp.UserAnswer);
            this.label9.Text = "判题：" + string.Join(",", datahelp.Correct);
            this.label8.Text = datahelp.UserAnswer[datahelp.CurrentQuestion - 1];

        }
        private Fuc ff = new Fuc();
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (datahelp.UserAnswer[datahelp.CurrentQuestion - 1] != null)
            {
                checkanswer();
            }
            else
            {

                ff.ShowInfoTip("当前没有选择");
                return;
            }

            option = datahelp.UserAnswer[datahelp.CurrentQuestion - 1];

            if (datahelp.CurrentQuestion < num)
            {

                datahelp.CurrentQuestion++;

                CheckNextButtonText();
                LoadQuestion();
                this.rdbA.Checked = false;
                this.rdbB.Checked = false;
                this.rdbC.Checked = false;
                this.rdbD.Checked = false;
                if (datahelp.UserAnswer[datahelp.CurrentQuestion - 1] != null)
                {

                    SelectOption();
                }
                else
                {
                    option = "";

                }


                ShowInfo();
            }
            else
            {
                this.btnNext.Text = "提交";

                btnAnswer_Click(sender, e);
            }
        }

        private void checkanswer()
        {
            // 用户答案 与系统答案
            string a = datahelp.UserAnswer[datahelp.CurrentQuestion - 1];
            string b = datahelp.curAnswer;
            if (a.Length == b.Length)
            {

                char[] a2 = a.ToCharArray();
                char[] b2 = b.ToCharArray();
                int cao = 0;
                foreach (char c in a2)
                {

                    foreach (char d in b2)
                    {
                        if (c == d)
                        {
                            cao++;
                        }
                    }
                }
                if (cao == a.Length)
                {
                    datahelp.Correct[datahelp.CurrentQuestion - 1] = "1";
                }
                else
                {
                    datahelp.Correct[datahelp.CurrentQuestion - 1] = "0";
                }

            }
            else
            {
                datahelp.Correct[datahelp.CurrentQuestion - 1] = "0";


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

                ff.ShowInfoTip("时间到了，请交卷");
                this.Close();
                AnswerForm frm = new AnswerForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();

            }


        }

        private void CheckNextButtonText()
        {
            if (datahelp.CurrentQuestion < num)
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
            this.Hide();
            AnswerForm frm = new AnswerForm();

            frm.Show();
            //this.Close();
        }
        private void SelectOption()
        {
            //需要修改
            option = datahelp.UserAnswer[datahelp.CurrentQuestion - 1];
            this.rdbA.Checked = false;
            this.rdbB.Checked = false;
            this.rdbC.Checked = false;
            this.rdbD.Checked = false;
            if (datahelp.UserAnswer[datahelp.CurrentQuestion - 1].Length == 1)
            {

                switch (datahelp.UserAnswer[datahelp.CurrentQuestion - 1])
                {
                    case "A": this.rdbA.Checked = true; break;
                    case "Y":
                        this.rdbA.Checked = true;
                        this.rdbA.Tag = "Y";
                        this.rdbC.Hide();
                        this.rdbD.Hide();
                        break;
                    case "B":
                        this.rdbB.Checked = true;

                        break;
                    case "N":
                        this.rdbB.Checked = true;
                        this.rdbB.Tag = "N";
                        this.rdbD.Hide();
                        this.rdbC.Hide();
                        break;
                    case "C": this.rdbC.Checked = true; break;
                    case "D": this.rdbD.Checked = true; break;
                    default:
                        this.rdbA.Checked = false;
                        this.rdbB.Checked = false;
                        this.rdbC.Checked = false;
                        this.rdbD.Checked = false;
                        break;
                }
            }
            else
            {

                string a = datahelp.UserAnswer[datahelp.CurrentQuestion - 1];
                char[] a2 = a.ToCharArray();
                foreach (char c in a2)
                {

                    switch ("" + c)
                    {
                        case "A":
                            this.rdbA.Checked = true; break;

                            break;
                        case "B":
                            this.rdbB.Checked = true;

                            break;


                        case "C": this.rdbC.Checked = true; break;
                        case "D": this.rdbD.Checked = true; break;
                        default:
                            this.rdbA.Checked = false;
                            this.rdbB.Checked = false;
                            this.rdbC.Checked = false;
                            this.rdbD.Checked = false;
                            break;
                    }

                }
            }


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (datahelp.CurrentQuestion > 1)
            {
                datahelp.CurrentQuestion--;
                CheckUpButtonText();
                this.rdbA.Show();
                this.rdbB.Show();
                this.rdbC.Show();
                this.rdbD.Show();
                ShowInfo();

                LoadQuestion();
                SelectOption();

            }

        }
        private void CheckUpButtonText()
        {
            if (datahelp.CurrentQuestion > 1)
            {
                this.btnUp.Text = "上一题";


            }
            else
            {
                this.btnUp.Text = "已是第一题";
                btnUp.Enabled = false;
            }
        }

        string option = "";

        private void rdbA_Click(object sender, EventArgs e)
        {
            CheckBox rdb = (CheckBox)sender;
            // option = "";
            if (option.Length > 2)
            {
                MessageBox.Show("只能单选");
                return;
            }
            if (rdb.Checked)
            {
                if (!option.Contains(rdb.Tag.ToString()) && option.Length < 4)
                {
                    option += rdb.Tag.ToString();
                }


            }
            else
            {
                option = option.Replace(rdb.Tag.ToString(), string.Empty);
            }


            datahelp.UserAnswer[datahelp.CurrentQuestion - 1] = option;


        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestionContent_TextChanged(object sender, EventArgs e)
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        private void closing(object sender, FormClosedEventArgs e)
        {

            f.ShowWarningTip("中途退出，成绩将不合格请谨慎选择");
            Process.GetCurrentProcess().Kill();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rdbA_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (datahelp.SubId)
            {
                case 1:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;
                    OFF of = new OFF(datahelp.QId);
                    of.Show();
                    // this.Close();

                    break;
                case 2:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;
                    //ON on = new ON(datahelp.QId);
                    //on.Show();
                    zaixianjiaoyan x = new zaixianjiaoyan();
                    x.Show();
                    // this.Close();
                    break;
                case 3:

                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;
                    ON on1 = new ON(datahelp.QId);
                    on1.Show();
                    //
                    break;

                case 5:
                    datahelp.CurrentStep = 2;
                    datahelp.CurrentStep1 = 2;

                    MF1 mf = new MF1();
                    mf.Show();
                    //  this.Close();
                    break;
                case 6:
                    datahelp.CurrentStep = 3;
                    MF1 mf1 = new MF1();
                    mf1.Show();
                    //   this.Close();
                    break;
                case 4:
                    datahelp.CurrentStep = 4;
                    MF1 mf2 = new MF1();
                    mf2.Show();
                    //  this.Close();
                    break;
            }

        }
    }
}

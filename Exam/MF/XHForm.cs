﻿using AutoWindowsSize;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Exam.MF
{
    public partial class XHForm : Form
    {
        public XHForm()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        int num = 1;

        Fuc f = new Fuc();
        TestRecord t;
        QuestionA qq = new QuestionA();
        string[] correct;
        Grade g = new Grade();

        public XHForm(string qrcode)
        {
            InitializeComponent();

            g.getOne(qrcode);
            t = new TestRecord();
            string connectionString = ConfigurationManager.AppSettings["sqlc"];
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from TestRecord where qrcode = '" + qrcode + "'";
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

                t.Xhquestions = reader["xhquestions"].ToString().Trim();

                t.Adfxh = reader["aqfxh"].ToString();

                t.Qrcode = reader["qrcode"].ToString();
            }
            con.Close();
            datahelp.StudentId = t.KsId;
            datahelp.CurrentQuestion = 1;

            this.Text = "型号答题";
            if (t.Xhquestions.Length > 0)
            {
                datahelp.QuestionIds = t.Xhquestions.Split(',');
                datahelp.SubId = 5;
                // if (int.Parse(g.score4) > -1)
                // {

                //     f.ShowErrorDialog("重复考试");

                //   this.Enabled = false;
                //  }
                // g.updateGrade(0, "score4", datahelp.QId);

            }
            else
            {
                f.ShowErrorDialog("题目已不存在于当前题库，请重新抽题");

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
            num = c.xhnum;
            this.label2.Text = "总题数：" + (num) + "，当前：";
            datahelp.Answer = new string[num];
            datahelp.UserAnswer = new string[num];
            datahelp.Correct = new string[num];
            // awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            // this.SizeChanged += groupBox1_Resize;
            string x = ConfigurationManager.AppSettings["debug"];
            if (int.Parse(x) != 1)
            {
                this.label10.Visible = false;
                this.label9.Visible = false;
                this.label8.Visible = false;
                this.label7.Visible = false;
                this.label6.Visible = false;
            }
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
            string sql = "select * from aqfadmin where id =" + questionId.ToString().Trim();

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
                //this.label10.Text = "[" + reader["type"].ToString().Trim() + "]";
                //if (reader["type"].ToString().Trim() == "判断题")
                //{
                //    this.txtQuestionContent.Text = reader["question"].ToString();
                //    this.rdbA.Text = "对 ";
                //    this.rdbA.Tag = "Y";
                //    this.rdbB.Text = "错 ";
                //    this.rdbB.Tag = "N";
                //    this.rdbC.Hide();
                //    this.rdbD.Hide();



                //}
                //else
                //{
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

            //}

            reader.Close();
            con.Close();


        }
        Score sc = new Score();
        private void ShowInfo()
        {
            this.label3.Text = "" + (int.Parse(datahelp.CurrentQuestion.ToString()));
            this.label6.Text = "您的选择：" + string.Join(",", datahelp.UserAnswer);
            this.label9.Text = "结果：" + string.Join(",", datahelp.Correct);
            this.label8.Text = "上一次回答："+  datahelp.UserAnswer[datahelp.CurrentQuestion - 1];
            this.label10.Text = "分值：" + sc.getScore("lp" + datahelp.CurrentQuestion);
        }

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
              //  label3.Text = datahelp.CurrentQuestion.ToString();
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
        private Fuc ff = new Fuc();
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
                this.timer2.Stop();
                ff.ShowInfoTip("时间到了，请交卷");
                AnswerForm frm = new AnswerForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
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
            AnswerForm frm = new AnswerForm();
            frm.Show();
            this.Close();

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

            if (rdb.Checked)
            {


                option = rdb.Tag.ToString();
                switch (rdb.Tag.ToString())
                {
                    case "A":
                        //  this.rdbA.Checked = false;
                        this.rdbB.Checked = false;
                        this.rdbC.Checked = false;
                        this.rdbD.Checked = false;
                        break;

                    case "B":
                        this.rdbA.Checked = false;
                        //   this.rdbB.Checked = false;
                        this.rdbC.Checked = false;
                        this.rdbD.Checked = false;
                        break;

                    case "C":
                        this.rdbA.Checked = false;
                        this.rdbB.Checked = false;
                        // this.rdbC.Checked = false;
                        this.rdbD.Checked = false;
                        break;

                    case "D":
                        this.rdbA.Checked = false;
                        this.rdbB.Checked = false;
                        this.rdbC.Checked = false;
                        //   this.rdbD.Checked = false;
                        break;
                }
            }


            datahelp.UserAnswer[datahelp.CurrentQuestion - 1] = option;


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

        protected override CreateParams CreateParams //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");
            this.SizeChanged += groupBox1_Resize;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdbD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbA_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick1(object sender, EventArgs e)
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
                this.timer2.Stop();
                ff.ShowInfoTip("时间到了，请交卷");
                AnswerForm frm = new AnswerForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }


        }

        private void rdbC_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rdbB_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (datahelp.RemainTime > 0)
            {
                datahelp.RemainTime--;
                int min = datahelp.RemainTime / 60;
                int sec = datahelp.RemainTime % 60;
                this.uiLedLabel1.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                this.timer2.Stop();

                ff.ShowInfoTip("时间到了，请交卷");
                this.Close();
                AnswerForm frm = new AnswerForm();
                frm.MdiParent = this.MdiParent;
                frm.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

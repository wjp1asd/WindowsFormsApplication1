﻿using AutoWindowsSize;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Admin.Goals;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Settings;

namespace WindowsFormsApplication1
{


    public partial class AdminIndex : Form
    {

        public AdminIndex()
        {
            InitializeComponent();
            //   ff = new fullScreen(this);



            InitUI();
            ff.same(this);
        }
        private void InitUI()
        {
            datahelp a = new datahelp();
            a.Initc();

            this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml(a.color5);
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button2.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button3.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button4.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button5.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);

            this.button6.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color1);
            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml(a.color2);
            //   ff.ShowInfoTip(a.color1);

            this.label2.Text = a.link;
            // 最大化 
            this.change();

        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.button(this.button1);
            ff.button(this.button2);
            ff.button(this.button3);
            ff.button(this.button4);

            ff.button(this.button5);
            ff.button(this.button6);
            ff.button(this.button7);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            QuestionSet q = new QuestionSet();
            q.Show();
            this.Close();
        }

        private void 管理员界面_Load(object sender, EventArgs e)
        {
            awt = new AutoAdaptWindowsSize(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoalSet1 goalSet1 = new GoalSet1();
            goalSet1.Show();
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
            // this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {


            form1 f = new form1();
            f.Show();
            this.Close();

        }

        private void AdminIndex_Resize(object sender, EventArgs e)
        {

            //this.change();

        }

        private void label2_Click(object sender, EventArgs e)
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
        private void groupBox1_Enter(object sender, EventArgs e)
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
    }
}

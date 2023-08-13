﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Exam;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Scan
{
    public partial class ScanLogin : Form
    {
        public ScanLogin()
        {
            InitializeComponent();
            this.change();
            this.groupBox1.Hide();
        }
        private Fuc ff = new Fuc();
        public void change()
        {

            ff.fullsreen(this.button1, this);
            ff.fullsreen(this.textBox1, this);

            ff.fullsreen(this.button7, this);
            ff.fullsreen(this.label2, this);


        }
        bool read = true;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // 自动登录
            if (this.textBox1.Text.ToString().Length > 20 && read == true)
            {
              
               
                this.textBox1.Enabled = false;
                xuanti();
            }

            this.button7.BackColor = System.Drawing.ColorTranslator.FromHtml("Green");
            this.button7.Enabled = true;
            this.button7.Text = "查询结果";


        }

        private void ScanLogin_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.button7.Enabled = false;
            //this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("white");

            SoundPlayer player = new SoundPlayer();

            // 设置音频文件的路径
            player.SoundLocation = @"C:\Path    o\audio.wav";

            // 播放音频
            player.Play();

            // 等待音频播放完毕
            player.PlaySync();

            // 释放资源
            player.Dispose();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //查询数据 是否有选题记录
            if (read) {
                xuanti();
            }
          
        

        }
        bool a=false;
        string qrcode = "";
        private void xuanti()
        {
            if (this.textBox1.Text.ToString().Length < 19)
            {

                ff.ShowErrorDialog("考试码格式有误");

                return;
            }
            string sql = "select * from TestRecord where qrcode like  '%" + this.textBox1.Text.Trim().Substring(0, 20) + "%'";

            if (ff.RC(sql).Length > 0)
            {
             
              
                 qrcode = ff.RC(sql);
                
                t = t.getRecord(qrcode);
                this.groupBox1.Show();
                this.groupBox1.Left = this.button1.Left - 100;
                this.groupBox1.Top = this.button1.Top +100;
                Student s = new Student(t.KsId);
              //  MessageBox.Show(s.ava);
                this.label10.Text += t.Ksname;
                this.label3.Text +=s.Sex;
                this.label8.Text += t.KsId;
                this.pictureBox2.ImageLocation = s.ava;
                read = false;
            }
            else
            {

                ff.ShowErrorDialog("未找到合适记录");
            }
                           // 开始进入考试 读取不同设备参数 进行定向跳转    < !--1是管理员  0是考生抽题 2是离线考试 3 在线考试 4 研磨 - 1是上帝模式-- >
              

        }
        TestRecord t=new TestRecord();
        private void button1_Click(object sender, EventArgs e)
        {
            // this.Close();
            // ff.backlogin();
            Application.Restart();
            Process.GetCurrentProcess()?.Kill();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupBox1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
             Exam1 ex = new Exam1(qrcode);
             ex.Show();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

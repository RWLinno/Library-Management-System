// 导航页面
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //点击用户登录按钮后跳转到登陆页面
        {
            LogInlinkLabel.LinkVisited = true;
            Form logIn = new SignIn(this);
            logIn.Show();
          //  Hide();
        }
        private void SignInlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //点击用户注册按钮后跳转到用户注册页面
        {
            SignInlinkLabel.LinkVisited = true;
            Form signIn = new SignUp(this);
            signIn.Show();
        //    Hide();
        }
        private void UnsubscribelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //点击用户注销按钮后跳转到用户注销页面
        {
            /*
            UnsubscribelinkLabel.LinkVisited = true;
            Form unsubscribe = new Unsubscribe(this);
            unsubscribe.Show();
            Hide();
            */
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form browser = new browser();
            browser.Show();
        }
    }
}

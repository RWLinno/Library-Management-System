using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class SignIn : Form
    {
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLinmit = @"^[a-zA-Z0-9]*$";
        private string name;
        private string password;
        Form form;
        public string CommonName { get { return name; } }
        public string Password { get { return password; } }
        public SignIn(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        private void CancelButton_Click(object sender, EventArgs e) //点击取消按钮返回主页面
        {
            this.Close();
            form.Show();
        }
        public void LoginInfo() //连接到数据库进行登陆确认
        {
            Admin admin = new Admin(this);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            if (nameTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty)
            {
                MessageBox.Show("用户名称或用户密码不能为空", "登陆提示");
                Clear();
                return;
            }
            if ((!Regex.IsMatch(nameTextBox.Text, nameLinmit)) || (!Regex.IsMatch(passwordTextBox.Text, passwordLinmit)))
            {
                MessageBox.Show("用户名称和用户密码只能由字母和数字组成", "登陆提示");
                Clear();
                return;
            }
            else
            {
                name = nameTextBox.Text;
                password = passwordTextBox.Text;
                bool IsAdmin;
                if (generalRadioButton.Checked)
                    IsAdmin = false;
                else
                    IsAdmin = true;
                CommonUI commonUI = new CommonUI(this, CommonName);
                if (dataBaseConnection.Login(CommonName, Password, IsAdmin))
                {
                    dataBaseConnection.LoginRecord(CommonName, DateTime.Now.ToString("F"));
                    if (IsUserClassManage())
                    {
                        MessageBox.Show("欢迎您登陆本系统", "消息提示");
                        admin.Show();
                        this.Hide();
                        commonUI.Close();
                    }
                    else
                    {
                        MessageBox.Show("欢迎您登陆本系统", "消息提示");
                        commonUI.Show();
                        this.Hide();
                        admin.Close();
                    }
                }
                else
                    MessageBox.Show("您的用户名或密码有误", "登陆失败");
                Clear();
            }
        }
        public void Clear() //清空输入的用户名和密码
        {
            nameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }
        private void passwordModificationButton_Click(object sender, EventArgs e) //点击修改密码按钮跳转到修改密码页面
        {
            Form passwordModification = new pwdModify(this);
            passwordModification.Show();
            //this.Hide();
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            LoginInfo();
        }
        public bool IsUserClassManage() //根据选项按钮返回用户类型(是否为管理员)
        {
            if (generalRadioButton.Checked == true)
                return false;
            else
                return true;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void nameTextBox_TextChanged(object sender, EventArgs e) { }
        private void SignIn_Load(object sender, EventArgs e) { }
    }
}

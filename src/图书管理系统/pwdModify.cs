using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class pwdModify : Form
    {
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLimit = @"^[a-zA-Z0-9]*$";
        private string name;
        private string password;
        private string newPassword;
        Form form;
        DataBaseConnection dataBaseConnection = new DataBaseConnection(); //修改密码需要连接到数据库中
        public pwdModify(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        public void PwdModificationInfo() //点击确认修改按钮，当新密码符合规范时对用户密码进行修改。
        {
            if (nameTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty)
            {
                hintLabel.Text = "用户名称或用户密码不能为空";
                Clear();
                return;
            }
            if (!Regex.IsMatch(nameTextBox.Text, nameLinmit) ||
                !Regex.IsMatch(passwordTextBox.Text, passwordLimit)) //密码要符合字母和数字组成的正则表达式
            {
                hintLabel.Text = "只能由字母和数字组成";
                Clear();
                return;
            }
            if (newPasswordTextBox.Text == String.Empty ||
                !Regex.IsMatch(newPasswordTextBox.Text, passwordLimit))
            {
                hintLabel.Text = "新密码不能为空";
                newPasswordTextBox.Clear();
                confirmNewPasswordTextBox.Clear();
                return;
            }
            if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text) //两个文本框内容应相同
            {
                hintLabel.Text = "新密码前后不同";
                newPasswordTextBox.Clear();
                confirmNewPasswordTextBox.Clear();
                return;
            }
            name = nameTextBox.Text;
            password = passwordTextBox.Text;
            newPassword = newPasswordTextBox.Text;
            if (dataBaseConnection.passwordChange(name, password, newPassword))
            {
                MessageBox.Show("密码更改成功，下次登陆系统请使用新密码", "更改成功");
            }
            else
            {
                MessageBox.Show("密码更改失败,可能是密码错误或者账户不存在", "更改终止");
            }
        }
        public void Clear() //清空
        {
            nameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.Focus();
            hintLabel.Text = "";
        }
        private void cancelButtom_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
        private void okButtom_Click(object sender, EventArgs e)
        {
            PwdModificationInfo();
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}

//账号注销页面
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Unsubscribe : Form
    {
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLinmit = @"^[a-zA-Z0-9]*$";
        private string name;
        private string password;
        Form form;
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        public Unsubscribe(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        public void infoConfirm() //按下确认按钮后检查输入的用户名和密码是否有误，随后在数据库中删除对应的用户记录。
        {
            if (nameTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty) // 输入信息为空
            {
                Clear();
            }
            else if (!Regex.IsMatch(nameTextBox.Text, nameLinmit) ||
                      !Regex.IsMatch(passwordTextBox.Text, passwordLinmit)) //  用户或者密码不符合规范
            {
                Clear();
            }
            else
            {
                name = nameTextBox.Text;
                password = passwordTextBox.Text;

                if (dataBaseConnection.userLogout(name, password))
                    MessageBox.Show("账户成功注销!", "注销成功");
                else
                    MessageBox.Show("账户信息有误.", "操作失败");
            }
        }
        public void Clear()
        {
            nameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }
        private void cancelButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            Close();
        }
        private void confirmButtom_Click(object sender, EventArgs e)
        {
            infoConfirm();
        }
        private void label5_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void hintLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

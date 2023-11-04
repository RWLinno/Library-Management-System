//注册页面
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class SignUp : Form
    {
        const string nameLimit = @"^[a-zA-Z0-9]*$";
        const string passwordLimit = @"^[a-zA-Z0-9]*$";
        const string phoneNumberLimit = @"^\d{11}$";
        private string name;
        private string Studentname;
        private string password;
        private string phoneNumber;
        private string sex;
        private string workUnit;
        private string userID;
        private string signinTime;
        Form form;
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        public string CommonName { get { return name; } }
        public string StudentName { get { return name; } }
        public string Password { get { return password; } }
        public string Sex { get { return sex; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string WorkUnit { get { return workUnit; } }
        public string UserId { get { return userID; } }
        public string SigninTime { get { return signinTime; } }
        public SignUp(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        public void SignInfo() //根据正则表达式确认输入的信息是否符合规范
        {
            if (nameTextBox.Text == String.Empty)
            {
                hintNameLabel.Text = "用户名不能为空";
            }
            if (!Regex.IsMatch(nameTextBox.Text, nameLimit))
            {
                hintNameLabel.Text = "用户名应由字母或数字组成";
                nameTextBox.Clear();
                nameTextBox.Focus();
                return;
            }
            if (nametextBox2.Text == String.Empty)
            {
                hintNameLabel.Text = "姓名不能为空";
            }
            if (workUnitTextBox.Text == String.Empty)
            {
                hintNameLabel.Text = "单位不能为空";
            }
            if (phoneNumberTextBox.Text == String.Empty)
            {
                hintNameLabel.Text = "联系手机不能为空";
            }
            if (!Regex.IsMatch(phoneNumberTextBox.Text, phoneNumberLimit))
            {
                hintNameLabel.Text = "请输入正确手机号码";
                phoneNumberTextBox.Clear();
                phoneNumberTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text == String.Empty)
            {
                hintNameLabel.Text = "用户密码不能为空";
            }
            if (!Regex.IsMatch(passwordTextBox.Text, passwordLimit))
            {
                hintNameLabel.Text = "用户密码只能由字母和数字组成";
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                hintNameLabel.Text = "前后密码不相同";
                passwordTextBox.Clear();
                confirmPasswordTextBox.Clear();
                passwordTextBox.Focus();
            }
            else
            {
                name = nameTextBox.Text;
                if (manRadioButton.Checked)
                    sex = manRadioButton.Text;
                else
                    sex = womanRadioButton.Text;
                Studentname = nametextBox2.Text;
                phoneNumber = phoneNumberTextBox.Text;
                password = passwordTextBox.Text;
                workUnit = workUnitTextBox.Text;
                userID = name;
                signinTime = DateTime.Today.ToString("F");
                if (dataBaseConnection.userAdd(CommonName, Studentname, Password, Sex,
                        WorkUnit, PhoneNumber, UserId, SigninTime))
                {
                    MessageBox.Show("感谢您的注册", "消息提示");
                }
                else
                    MessageBox.Show("用户已经存在", "注册终止");
                Clear();
            }
        }
        public void hintClear() //清空输入的内容
        {
            hintConfirmPasswordLabel.Text = "";
            hintPasswordLabel.Text = "";
            hintNameLabel.Text = "";
        }
        public void Clear() //清空输入的内容
        {
            nameTextBox.Clear();
            nametextBox2.Clear();
            workUnitTextBox.Clear();
            phoneNumberTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
            this.Close();
            form.Show();
        }
        private void CancelButton_Click(object sender, EventArgs e) //点击取消按钮返回上一给页面
        {
            this.Close();
            form.Show();
        }
        private void signInButtom_Click(object sender, EventArgs e) //点击注册按钮检验信息是否正确并登录到数据库中，并清空输入内容。
        {
            hintClear();
            SignInfo();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void workUnitTextBox_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


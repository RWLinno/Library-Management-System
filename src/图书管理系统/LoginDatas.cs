//登陆记录（没做）
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class 图书系统登录记录 : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        public 图书系统登录记录()
        {
            InitializeComponent();
        }
        private void signinDateTimePicker_ValueChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) //按下查询所有登陆记录后，在数据库中查询所有满足输入条件的登陆记录并返回给列表控件。
        {
            string userClass = "";
            string value = "";
            if (usersClassComboBox.SelectedItem.ToString() == "用户名")
            {
                userClass = "UserName";
                value = userNameTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "姓名")
            {
                userClass = "StudentName";
                value = nametextBox2.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "性别")
            {
                userClass = "Sex";
                value = sexTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "学院")
            {
                userClass = "WorkUnit";
                value = workUnitTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "注册日期")
            {
                userClass = "SigninTime";
                value = signinDateTimePicker.Value.ToString("yyyy年M月dd日 0:00:00");
            }
            dataGridView1.DataSource = dataBaseConnection.seekUser(userClass, value);
        }
    }
}

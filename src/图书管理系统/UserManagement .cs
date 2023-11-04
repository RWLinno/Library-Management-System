//用户管理页面
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class UserManagement : Form
    {
        Form form;
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        public UserManagement(Form form)
        {
            InitializeComponent();
            this.form = form;
            showUsers();
            usersClassComboBox.SelectedIndex = 0;
        }
        private void back_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
        public void showUsers() //将数据库中查询的用户记录返回到列表控件中显示
        {
            usersDGV.DataSource = dataBaseConnection.commonUser();
        }
        private void seekUserButtom_Click(object sender, EventArgs e) //按下查询按钮返回满足输入的查询条件的用户，并显示在列表控件中
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

            if (value == "") //如果所有参数都是空的，那么就相当于刷新页面
            {
                showUsers();
            }
            else
            {
                usersDGV.DataSource = dataBaseConnection.seekUser(userClass, value);
            }
        }
        private void userDelteButton_Click(object sender, EventArgs e) //按下删除按钮将选中用户从数据库中删除
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            dataBaseConnection.deleteUser(name);
            MessageBox.Show("用户删除成功", "操作成功");
            showUsers();
        }
        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) //按下权限授予和权限回收按钮将改变列表中选中的用户的权限。
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            string is_admin = usersDGV.CurrentRow.Cells[0].Value.ToString();
            if (is_admin != "管理员") // 根据用户的类型来操作
            {
                if (!dataBaseConnection.GRANT(name)) //修改用户的权限
                {
                    MessageBox.Show("授予用户" + usersDGV.CurrentRow.Cells[2].Value.ToString() + "管理权限，", "权限授予");
                }
            }
            else
            {
                if (!dataBaseConnection.rollGRANT(name))
                {
                    MessageBox.Show("收回用户" + usersDGV.CurrentRow.Cells[2].Value.ToString() + "管理权限，", "权限收回");
                }
            }
            showUsers();
        }
        private void button2_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}

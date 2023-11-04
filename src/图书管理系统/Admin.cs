// 管理员主页面
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Admin : Form
    {
        Form form;
        public Admin(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        private void exitButton_Click(object sender, EventArgs e) //关闭窗口
        {
            this.Close();
            form.Show();
        }
        private void UsersManageButton_Click(object sender, EventArgs e) //跳转到管理用户页面
        {
            UserManagement userManagement = new UserManagement(this);
            this.Hide();
            userManagement.Show();
        }
        private void BookManageButton_Click(object sender, EventArgs e) //跳转到管理书籍页面
        {
            BooksManage booksManage = new BooksManage(this);
            this.Hide();
            booksManage.Show();
        }

        private void Admin_Load(object sender, EventArgs e) { }
    }
}

//显示借书记录的窗口页面
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowRecord : Form
    {
        Form form;
        User User;
        public BorrowRecord(Form form, string name)
        {
            InitializeComponent();
            this.form = form;
            User = new User(name);
            showRecord();
        }
        public BorrowRecord(BooksManage booksManage)
        {
            this.booksManage = booksManage;
        }
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        private BooksManage booksManage;
        private void btnBack_Click(object sender, EventArgs e) //点击返回按钮返回主页面
        {
            form.Show();
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e) //刷新按钮更新显示借书记录的控件
        {
            showRecord();
        }
        public void showRecord() //连接数据库使得列表显示数据库中满足用户字段的记录
        {
            libraryRecordDGV.DataSource = dataBaseConnection.loanRecord(User.Name);
        }
        private void returnBookButtom_Click(object sender, EventArgs e) //点击还书按钮归还选中书籍并更新数据库。
        {
            if (libraryRecordDGV.Rows.Count != 0)
            {
                string returnTime = DateTime.Now.ToString();
                string borrowtime = libraryRecordDGV.CurrentRow.Cells[3].Value.ToString();
                string Username = User.Name;
                bool[] flag = new bool[2];
                flag = dataBaseConnection.returnBook(returnTime, borrowtime, Username);
                if (flag[0])
                    MessageBox.Show("本书已经归还不需要归还", "归还提示");
                else if (flag[1]) //手贱的还归还已经归还的书的措施！！！
                    MessageBox.Show("本书已归还！！", "归还提示");
                else
                    MessageBox.Show("您已经成功归还本书，谢谢使用", "归还提示");
                showRecord();
            }
            else
                MessageBox.Show("当前没有选中要还的书或者没有借书记录");
        }
    }
}

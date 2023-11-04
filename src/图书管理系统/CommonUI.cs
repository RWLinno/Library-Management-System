//普通用户的主页面(对书籍查询还有一点问题)
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class CommonUI : Form
    {
        Form form;
        User User;
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        public CommonUI(Form form, string name)
        {
            InitializeComponent();
            this.form = form;
            bookClassComboBox.SelectedIndex = 0;
            showBook();
            User = new User(name);
        }
        private void btnQuery_Click(object sender, EventArgs e) //点击查看借书记录按钮跳转到借书记录页面
        {
            BorrowRecord borrowRecord = new BorrowRecord(this, User.Name);
            borrowRecord.Show();
            //this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e) //点击退出按钮返回到登录页面
        {
            form.Show();
            this.Close();
        }
        private void searchBookButtom_Click(object sender, EventArgs e) //点击查找书名按钮在数据库中书籍表查找满足书名字段的记录
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConnection.seekBookByName(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    booksDVG.DataSource = dataBaseConnection.seekBookByName(bookName);
            }
        }
        private void searchByKindButtom_Click(object sender, EventArgs e) //点击查找类别按钮在数据库中书籍表查找满足类别字段的记录
        {
            string bookClass = bookClassComboBox.SelectedItem.ToString();
            booksDVG.DataSource = dataBaseConnection.seekBookByClass(bookClass);
        }
        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookName = booksDVG.CurrentRow.Cells[1].Value.ToString();
            bookDigestTextBox.Text = dataBaseConnection.bookinfos(bookName)[0];
        }
        private void borrowButtoom_Click(object sender, EventArgs e)  //标记借书
        {
            string bookName = booksDVG.CurrentRow.Cells[1].Value.ToString();
            string bookNumber = booksDVG.CurrentRow.Cells[0].Value.ToString();
            string name = User.Name;
            string borrowTime = DateTime.Now.ToString();
            if (dataBaseConnection.borrowAdd(bookName, name, borrowTime, bookNumber))
            {
                MessageBox.Show("您已成功借到此书，请在一个月内归还", "借书成功");
                showBook();
            }
            else
                MessageBox.Show("您已借过该书且未归还", "借书终止");
        }
        public void showBook() //使得控件实时显示数据库中满足条件的书目记录。
        {
            booksDVG.DataSource = dataBaseConnection.showBook();
        }
        private void bookClassComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { showBook(); }
        private void booksDVG_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

// 借阅清单页面
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowList : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        Form form;
        public BorrowList(Form form)
        {
            InitializeComponent();
            this.form = form;
            showborrow();
        }
        private void searchBookButtom_Click(object sender, EventArgs e) //点击查找书名按钮对该书名的借阅记录进行查询并更新显示列表
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConnection.seekBookByName_borrow(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConnection.seekBookByName_borrow(bookName);
                dataGridView1.BackgroundColor = Color.White;
            }
        }
        private void button1_Click(object sender, EventArgs e)//点击查找用户按钮对用户的借阅列表进行查询并更新显示列表
        {
            string bookName = textBox1.Text;
            if (textBox1.Text == String.Empty)
                MessageBox.Show("名字不能为空", "搜索终止");
            else
            {
                if (dataBaseConnection.seekBookByUserName_borrow(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConnection.seekBookByUserName_borrow(bookName);
                dataGridView1.BackgroundColor = Color.White;
            }
        }
        public void showborrow()//更新显示数据库中借阅记录的控件
        {
            dataGridView1.DataSource = dataBaseConnection.showborrow();
        }
        private void exitButtom_Click(object sender, EventArgs e) //点击退出按钮退出该页面
        {
            form.Show();
            this.Close();
        }
        private void BorrowList_Load(object sender, EventArgs e) { }
    }
}

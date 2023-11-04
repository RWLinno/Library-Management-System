// 管理书目页面
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BooksManage : Form
    {
        Form form;
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        private string bookID;
        public string BookID { get { return bookID; } }
        public BooksManage(Form form)
        {
            InitializeComponent();
            this.form = form;
            bookClassComboBox.SelectedIndex = 0;
            showBook();
        }
        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
        private void bookAddButtom_Click(object sender, EventArgs e)
        {
            AddBooks newBookAdd = new AddBooks(this); //跳转到新增书籍页面
            newBookAdd.Show();
           // this.Hide();
        }
        private void borrowRwcordButtom_Click(object sender, EventArgs e)
        {
            BorrowList borrowRecord = new BorrowList(this); //跳转到借阅记录页面
            borrowRecord.Show();
          //  this.Hide();
        }
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConnection.seekBookByName(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else  //如果满足查询条件，那么将在数据库中的结果返回到列表控件
                    booksDVG.DataSource = dataBaseConnection.seekBookByName(bookName);
                booksDVG.BackgroundColor = Color.White;
            }
        }
        private void btnAlter_Click(object sender, EventArgs e)
        {  //修改书目时，检查所有文本框是否为空，满足条件后进入数据库对相应项进行修改
            if (bookDigestTextBox.Text == String.Empty || bookNameText.Text == String.Empty || bookKindText.Text == String.Empty
                || pressText.Text == String.Empty || authorText.Text == String.Empty || publishTimeText.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                dataBaseConnection.bookInfoChange(BookID, bookNameText.Text, bookKindText.Text,
                   pressText.Text, authorText.Text, publishTimeText.Text);
                showBook();
                MessageBox.Show("修改成功", "修改结果");

            }
        }
        private void searchByKindButtom_Click(object sender, EventArgs e)
        { //搜索一个种类的书籍
            string bookClass = bookClassComboBox.SelectedItem.ToString();
            booksDVG.DataSource = dataBaseConnection.seekBookByClass(bookClass);
        }
        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        }
        private void deleteBook_Click(object sender, EventArgs e)
        {
            string bookName = booksDVG.CurrentRow.Cells[1].Value.ToString();
            dataBaseConnection.bookDelete(bookName);
            showBook();
            MessageBox.Show("书籍删除成功", "消息提示");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInfo();
            showBook();
        }
        public void updateInfo() //更新文本框中选中书目的信息
        {
            string bookName = booksDVG.CurrentRow.Cells[1].Value.ToString();
            string[] bookinfos = dataBaseConnection.bookinfos(bookName);
            bookDigestTextBox.Text = bookinfos[0];
            bookNameText.Text = bookinfos[1];
            bookKindText.Text = bookinfos[2];
            pressText.Text = bookinfos[3];
            authorText.Text = bookinfos[4];
            publishTimeText.Text = bookinfos[5];
            bookID = bookinfos[6];
        }
        public void showBook()
        {
            booksDVG.DataSource = dataBaseConnection.showBook();
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblBookKind_Click(object sender, EventArgs e) { }
        private void bookNameText_TextChanged(object sender, EventArgs e) { }
    }
}

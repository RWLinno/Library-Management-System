// 增加书目页面
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class AddBooks : Form
    {
        private string bookName;
        private string bookClass;
        private string language;
        private string oldName;
        private string bookNumber;
        private string callNumber;
        private string author;
        private string iSBN;
        private string translator;
        private string publish;
        private string press;
        private string content;
        public string BookName { get { return bookName; } }
        public string BookClass { get { return bookClass; } }
        public string Language { get { return language; } }
        public string OldName { get { return oldName; } }
        public string BookNumber { get { return bookNumber; } }
        public string CallNumber { get { return callNumber; } }
        public string Author { get { return author; } }
        public string ISBN { get { return iSBN; } }
        public string Translator { get { return translator; } }
        public string Publish { get { return publish; } }
        public string Press { get { return press; } }
        public string Content { get { return content; } }
        Form form;
        DataBaseConnection dataBaseConnection = new DataBaseConnection(); //登记书籍需要连接到数据库中
        public AddBooks(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        private void backButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
        private void addBookButtom_Click(object sender, EventArgs e)
        {
            getInfos();
            if (bookNameTextBox.Text == String.Empty || bookClassComboBox.Text == String.Empty
                || languageTextBox.Text == String.Empty || oldNameTextBox.Text == String.Empty ||
                bookNumberTextBox.Text == String.Empty || callNumberTextBox.Text == String.Empty ||
                authorTextBox.Text == String.Empty || ISBNTextBox.Text == String.Empty ||
                translatorTextBox.Text == String.Empty || publishDateTimePicker.Text == String.Empty ||
                pressTextBox.Text == String.Empty || contentTextBox.Text == String.Empty)
                MessageBox.Show("所有资料不能留空", "提示");  //检查所有信息是否都已经填写
            else
            {
                if (dataBaseConnection.addNewBook(BookName, BookClass, Language, OldName,
                   BookNumber, CallNumber, Author, ISBN, Translator, Publish, Press, Content))
                    MessageBox.Show("你已经成功添加这本书", "添加成功"); //调用dataBaseConnection对数据库进行插入
                else
                    MessageBox.Show("这本书已经存在，无需添加", "添加失败");
            }
        }
        public void getInfos() //获取文本框控件中的内容
        {
            bookName = bookNameTextBox.Text;
            bookClass = bookClassComboBox.Text;
            language = languageTextBox.Text;
            oldName = oldNameTextBox.Text;
            bookNumber = bookNumberTextBox.Text;
            callNumber = callNumberTextBox.Text;
            author = authorTextBox.Text;
            iSBN = ISBNTextBox.Text;
            translator = translatorTextBox.Text;
            publish = publishDateTimePicker.Text;
            press = pressTextBox.Text;
            content = contentTextBox.Text;
        }
        private void bookClassComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}

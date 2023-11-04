using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }
        private void browser_Load(object sender, EventArgs e)
        {
            string url = "https://lib.jnu.edu.cn/"; //暨大官网http链接
            var request = (HttpWebRequest)WebRequest.Create(url); //Create:创建WebRequest对象获取和操作HTTP请求
            var response = (HttpWebResponse)request.GetResponse(); //GetResponse:获取和操作HTTP应答
            //构造数据流对象实例
            Stream stream = response.GetResponseStream();//GetResponseStream:获取应答流
            StreamReader sr = new StreamReader(stream);  //从字节流中读取字符

            //从流当前位置读取到末尾并显示在WebBrower控件中
            string content = sr.ReadToEnd();
            webBrowser1.ScriptErrorsSuppressed = true; //防止脚本报错
            webBrowser1.DocumentText = content;
        }
    }
}

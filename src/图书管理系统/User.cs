//该文件定义一个基类User，主要描述用户的基本属性。在BorrowRecord类和CommonUI中均被调用。
namespace 图书管理系统
{
    class User
    {
        private string name;
        public string Name { get { return name; } }
        public User(string name)
        {
            this.name = name;
        }
    }
}

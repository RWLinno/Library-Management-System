﻿using MySql.Data.MySqlClient;
using System.Data;


namespace 图书管理系统
{
    class DataBaseConnection
    {
        string connectionString = "server=1.12.238.52;port=3306;user=root;password=129496;database=library;";
        //连接本地mysql数据库
        //登录用户管理员与用户
        public bool Login(string userName, string password, bool IsAdmin)
        {

            bool LoginResult = true;
            string CommandText = "select * from users where UserName='" + userName + "'";
            string AdminCommandText = "select * from admin where AdminName='" + userName + "'";
            string FinallyCommand;

            if (IsAdmin)
                FinallyCommand = AdminCommandText;
            else
                FinallyCommand = CommandText;

            using (MySqlConnection libaryConnection = new MySqlConnection(connectionString))
            {
                libaryConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(FinallyCommand, libaryConnection);
                MySqlDataReader nameReader = mySqlCommand.ExecuteReader();
                if (nameReader.Read())
                {
                    string passwordRead = nameReader.GetString(nameReader.GetOrdinal("Password"));
                    if (password == passwordRead)
                        LoginResult = true;
                    else
                        LoginResult = false;
                }
                else
                    LoginResult = false;
            }

            return LoginResult;
        }

        public void LoginRecord(string name, string LoginTime) //在登录成功时将登陆记录记录到数据库
        {
            string LoginRecordCommandText = "insert into loginrecord(UserName,LoginTime)" +
                "values" +
                "('" + name + "','" + LoginTime + "')";

            using (MySqlConnection loginRecords = new MySqlConnection(connectionString))
            {
                loginRecords.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(LoginRecordCommandText, loginRecords);
                mySqlCommand.ExecuteNonQuery();
            }
        }

        public DataTable loanRecord(string name) //在借书时将所需的书名、书号和结束用户记录到数据库的借书记录表中
        {
            DataTable loanRecord;

            string CommandText = "select 图书编号,书名,借阅人,借阅时间,应归还时间,是否归还,归还时间 from loaninfo" +
                " where 借阅人='" + name + "'";

            using (MySqlConnection loanRecordConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText, connectionString);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                loanRecord = dataTable;
            }

            return loanRecord;
        }

        public DataTable showBook() //显示数据库的书籍表
        {
            DataTable books;
            string showBookCommandText = "select 编号,书名,类别,出版时间,出版社,内容摘写,ISBN号 " +
                "from booksinfo";

            using (MySqlConnection showBookConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showBookConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                books = dataTable;
            }
            return books;
        }

        public DataTable commonUser() //在用户注册完成时将信息添加到数据库的用户表中
        {
            DataTable commonUser;

            string CommonUserCommandText = "select Power 权限,UserName 用户名,StudentName 姓名,Sex 性别," +
                "WorkUnit 学院,PhoneNumber 手机号码,SigninTime 注册时间 from users";

            using (MySqlConnection commonUserConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommonUserCommandText, commonUserConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                commonUser = dataTable;
            }
            return commonUser;

        }

        public bool passwordChange(string name, string password, string newPassword) //在用户注册完成时将信息添加到数据库的用户表中
        {
            bool IsPasswordChange;
            string passwordChangeCommand = "update users set Password='" + newPassword + "'where UserName='" + name + "'";
            string IsPasswordCommand = "select * from users where UserName='" + name + "'";

            using (MySqlConnection passwordChangeConnection = new MySqlConnection(connectionString))
            {
                passwordChangeConnection.Open();
                MySqlCommand isPassword = new MySqlCommand(IsPasswordCommand, passwordChangeConnection);
                MySqlCommand passwordChange = new MySqlCommand(passwordChangeCommand, passwordChangeConnection);
                using (MySqlDataReader mySqlDataReader = isPassword.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        string passwordRead = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Password"));
                        if (password == passwordRead)
                        {
                            IsPasswordChange = true;
                        }
                        else
                            IsPasswordChange = false;
                    }
                    else
                        IsPasswordChange = false;
                }
                if (IsPasswordChange)
                    passwordChange.ExecuteNonQuery();

            }
            return IsPasswordChange;
        }

        public DataTable seekBookByName(string bookName) //按照书名对数据库中的书目表进行查询
        {
            string seekBookByNameCommand = "select 书名,类别,语种,原名,编号,索书号," +
                "作者,ISBN号,译者,出版时间,出版社 from booksinfo where 书名='" + bookName + "'";

            DataTable bookData;

            using (MySqlConnection seekBookByNameConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekBookByNameCommand, seekBookByNameConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookData = dataTable;
            }
            return bookData;
        }

        public DataTable seekBookByClass(string bookClass) //按照书类对数据库中的书目表进行查询
        {
            string seekBookByNameCommand = "select 书名,类别,语种,原名,编号,索书号," +
                 "作者,ISBN号,译者,出版时间,出版社 from booksinfo where 类别='" + bookClass + "'";

            DataTable bookData;

            using (MySqlConnection seekBookByNameConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekBookByNameCommand, seekBookByNameConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookData = dataTable;
            }
            return bookData;
        }



        public string[] bookinfos(string bookName) //返回对应书目的所有字段
        {

            string bookDigestCommand = "select * from booksinfo where 书名='" + bookName + "'";
            string[] bookinfos = new string[7];

            using (MySqlConnection bookDigestConnection = new MySqlConnection(connectionString))
            {
                bookDigestConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookDigestCommand, bookDigestConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    bookinfos[0] = mySqlDataReader["内容摘写"].ToString();
                    bookinfos[1] = mySqlDataReader["书名"].ToString();
                    bookinfos[2] = mySqlDataReader["类别"].ToString();
                    bookinfos[3] = mySqlDataReader["出版社"].ToString();
                    bookinfos[4] = mySqlDataReader["作者"].ToString();
                    bookinfos[5] = mySqlDataReader["出版时间"].ToString();
                    bookinfos[6] = mySqlDataReader["编号"].ToString();
                }
            }
            return bookinfos;
        }

        public void borrowBook(string bookName, string name, string borrowTime, string bookNumber)
        {
            string borrowBookCommand = "insert into loaninfo(图书编号,书名,借阅人,借阅时间,应归还时间,是否归还)" +
                "values('" + bookNumber + "','" + bookName + "','" + name + "','" + borrowTime + "','一个月','否')";

            using (MySqlConnection borrowBookConnection = new MySqlConnection(connectionString))
            {
                borrowBookConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(borrowBookCommand, borrowBookConnection);
                mySqlCommand.ExecuteNonQuery();

            }
        }

        public bool[] returnBook(string returnTime, string borrowTime, string userName) //修改数据库中的书目表的归还字段
        {
            bool isBorrow = false;
            bool[] flag = new bool[2];
            string returnCommandText = "update loaninfo set 是否归还='是',归还时间='" +
                returnTime + "' where 借阅时间='" + borrowTime + "'" + " and 借阅人='" + userName + "'";
            string IsReturnCommandText = "select * from loaninfo where 借阅时间='" + borrowTime + "'" + " and 是否归还='否'";
            bool IsReturn = false;

            using (MySqlConnection returnBookConnection = new MySqlConnection(connectionString))
            {
                returnBookConnection.Open();
                MySqlCommand returnCommand = new MySqlCommand(returnCommandText, returnBookConnection);
                MySqlCommand IsReturnCommand = new MySqlCommand(IsReturnCommandText, returnBookConnection);
                using (MySqlDataReader IsReturnRead = IsReturnCommand.ExecuteReader())
                {
                    if (IsReturnRead.Read())
                    {
                        if (IsReturnRead["是否归还"].ToString() == "是")
                        {
                            IsReturn = true;
                        }
                        else
                        {
                            IsReturn = false;

                        }

                        isBorrow = false;//选择的是你已经还了
                    }
                    else
                    {
                        isBorrow = true;
                    }
                }
                if (!IsReturn && !isBorrow)
                    returnCommand.ExecuteNonQuery();
            }
            flag[0] = IsReturn;
            flag[1] = isBorrow;
            return flag;
        }
        public DataTable seekUser(string userClass, string value) //查找数据库中对应用户
        {
            string seekUserByClassCommandText = "select Power 权限 , UserName 用户名,StudentName 姓名,Sex 性别,WorkUnit 学院 ,PhoneNumber 电话号码," +
                "UserID 编号,SigninTime 注册时间 from users " +
                "where " + userClass + "='" + value + "'";
            DataTable seekUsers;
            using (MySqlConnection seekUserConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekUserByClassCommandText, seekUserConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                seekUsers = dataTable;
            }
            return seekUsers;
        }

        public void deleteUser(string name) //删除数据库中的对应用户的记录
        {
            string deleteUserCommand = "delete from users where UserName='" + name + "'";
            using (MySqlConnection deletUserConnection = new MySqlConnection(connectionString))
            {
                deletUserConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(deleteUserCommand, deletUserConnection);
                mySqlCommand.ExecuteNonQuery();

            }
        }
        public void bookInfoChange(string bookNumber, string bookName, string bookClass,
            string press, string author, string publishTime) //修改数据库中对应书籍的相关信息
        {
            string bookInfoChangeCommandText = "update booksinfo set 书名='" + bookName + "',类别='" + bookClass + "',出版社='" + press + "'," +
                "作者='" + author + "',出版时间='" + publishTime + "' where 编号='" + bookNumber + "'";

            using (MySqlConnection bookInfoChangeConnection = new MySqlConnection(connectionString))
            {
                bookInfoChangeConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookInfoChangeCommandText, bookInfoChangeConnection);
                mySqlCommand.ExecuteNonQuery();
            }
        }

        public void bookDelete(string name)  //删除数据库中对应书籍的记录
        {
            string bookDeleteCommand = "delete from booksinfo where 书名='" + name + "'";
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            using (MySqlConnection bookDeleteConnection = new MySqlConnection(connectionString))
            {
                bookDeleteConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookDeleteCommand, bookDeleteConnection);
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, bookDeleteConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, bookDeleteConnection);
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                mySqlCommand.ExecuteNonQuery();
                foreign_key_checksCommand.ExecuteNonQuery();
                bookDeleteConnection.Close();
            }
        }
        public bool rollGRANT(string name) //回收数据库中相应用户的权限
        {
            string getAdmin = "select count(*) from admin where AdminName='" + name + "'";
            using (MySqlConnection rollGRANTConnection = new MySqlConnection(connectionString))
            {
                bool getAdminData = false;
                rollGRANTConnection.Open();
                MySqlCommand getAdminCommand = new MySqlCommand(getAdmin, rollGRANTConnection);
                string rollGRANT = "DELETE FROM admin WHERE AdminName='" + name + "'";
                MySqlCommand rollGRANTCommand = new MySqlCommand(rollGRANT, rollGRANTConnection);
                string setUserPower = " UPDATE users SET Power='普通用户' WHERE UserName='" + name + "'";
                MySqlCommand setUserPowerCommand = new MySqlCommand(setUserPower, rollGRANTConnection);
                using (MySqlDataReader getAdminDataReader = getAdminCommand.ExecuteReader())
                {

                    if (getAdminDataReader.Read())
                    {
                        getAdminData = false;
                    }
                    else
                    {
                        getAdminData = true;
                    }
                }
                if (!getAdminData)
                {
                    rollGRANTCommand.ExecuteNonQuery();
                    setUserPowerCommand.ExecuteNonQuery();
                    return getAdminData;
                }
                else
                {
                    return getAdminData;
                }
            }
        }
        public bool GRANT(string name) //赋予数据库中相应用户的权限
        {
            string getAdmin = "select * from admin where AdminName='" + name + "'";
            string getUserPassword = "select * from users where UserName='" + name + "'";
            string grantUserCommand = "";
            using (MySqlConnection rollGRANTConnection = new MySqlConnection(connectionString))
            {
                bool isAdminData = false;
                rollGRANTConnection.Open();

                //读取是否在管理员下
                MySqlCommand getAdminCommand = new MySqlCommand(getAdmin, rollGRANTConnection);
                using (MySqlDataReader getAdminDataReader = getAdminCommand.ExecuteReader())
                {

                    if (getAdminDataReader.Read())
                    {
                        isAdminData = true;
                        getAdminDataReader.Close();//存在已经授予过权力了
                    }
                    else
                    {
                        isAdminData = false;
                        getAdminDataReader.Close();
                    }
                }
                //读取密码
                MySqlCommand getUserPasswordCommand = new MySqlCommand(getUserPassword, rollGRANTConnection);
                using (MySqlDataReader getUserPasswordDataReader = getUserPasswordCommand.ExecuteReader())
                {
                    if (getUserPasswordDataReader.Read())
                    {
                        grantUserCommand = "insert into admin(AdminName,Password)" +
                        "value('" + name + "','" + getUserPasswordDataReader["Password"].ToString() + "')";
                        getUserPasswordDataReader.Close();
                    }
                }
                MySqlCommand mySqlgetUserCommand = new MySqlCommand(grantUserCommand, rollGRANTConnection);
                string setPowerList = " UPDATE users SET Power='管理员' WHERE UserName='" + name + "'";
                MySqlCommand setPowerListCommand = new MySqlCommand(setPowerList, rollGRANTConnection);
                if (isAdminData)
                {
                    return isAdminData;
                }
                else
                {
                    mySqlgetUserCommand.ExecuteNonQuery();
                    setPowerListCommand.ExecuteNonQuery();
                    return isAdminData;
                }
            }
        }

        public bool addNewBook(string bookName, string bookClass, string language, string oldName,
            string bookNumber, string callNumber, string author, string iSBN, string translator,
           string publish, string press, string content) //将书目信息登记到数据库中
        {
            bool IsBookAdd;
            string addNewBookCommandText = "insert into booksinfo (书名,类别,语种,原名,编号,索书号," +
                "作者,ISBN号,译者,出版时间,出版社,内容摘写)" +
                "value('" + bookName + "','" + bookClass + "','" + language + "','" + oldName + "'," +
                "'" + bookNumber + "','" + callNumber + "','" + author + "','" + iSBN + "','" + translator + "','" + publish + "'," +
                "'" + press + "','" + content + "')";
            string IsBookEixstedCommandText = "select * from booksinfo where 书名='" + bookName + "'";
            using (MySqlConnection addNewBookConnection = new MySqlConnection(connectionString))
            {
                addNewBookConnection.Open();
                MySqlCommand AddCommand = new MySqlCommand(addNewBookCommandText, addNewBookConnection);
                MySqlCommand IsExistedCommand = new MySqlCommand(IsBookEixstedCommandText, addNewBookConnection);
                using (MySqlDataReader IsExistedReader = IsExistedCommand.ExecuteReader())
                {
                    if (IsExistedReader.Read())
                        IsBookAdd = false;
                    else
                        IsBookAdd = true;
                }
                if (IsBookAdd)
                    AddCommand.ExecuteNonQuery();
            }
            return IsBookAdd;
        }
        public bool userLogout(string name, string password)
        {
            bool IsDelete;

            string userLogoutCommand = "delete from users where UserName='" + name + "'";
            string seekUserCommand = "select * from users where UserName='" + name + "'";
            using (MySqlConnection userLogoutConnection = new MySqlConnection(connectionString))
            {
                userLogoutConnection.Open();
                MySqlCommand logoutCommand = new MySqlCommand(userLogoutCommand, userLogoutConnection);
                MySqlCommand seekCommad = new MySqlCommand(seekUserCommand, userLogoutConnection);
                using (MySqlDataReader mySqlDataReader = seekCommad.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        string passwordRead = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Password"));
                        if (password == passwordRead)
                        {
                            IsDelete = true;
                        }
                        else
                            IsDelete = false;
                    }
                    else
                        IsDelete = false;
                }
                if (IsDelete)
                    logoutCommand.ExecuteNonQuery();
            }
            return IsDelete;
        }

        public bool userAdd(string userName, string StudentName, string password, string sex,
            string workUnit, string phoneNumber, string userID, string signinTime)
        {
            bool IsUserAdd;
            string is_admin = "普通用户";
            if (userName == "root")
            {
                is_admin = "管理员";
                admin_add(userName,password);
            }
            string userAddCommand = "insert into users(Power,UserName,StudentName,Sex,Password," +
                "WorkUnit,PhoneNumber,UserID,SigninTime)" +
                "value('"+ is_admin + "','" + userName + "','" + StudentName + "','" + sex + "','" + password + "','"
                + workUnit + "','" + phoneNumber + "','" + userID + "','" + signinTime + "')";
            string seekUserCommand = "select * from users where UserName='" + userName + "'";
            using (MySqlConnection userAddConnection = new MySqlConnection(connectionString))
            {
                userAddConnection.Open();
                MySqlCommand AddCommand = new MySqlCommand(userAddCommand, userAddConnection);
                MySqlCommand SeekCommand = new MySqlCommand(seekUserCommand, userAddConnection);
                using (MySqlDataReader mySqlDataReader = SeekCommand.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        IsUserAdd = false;
                    }
                    else
                    {
                        IsUserAdd = true;
                    }
                }
                if (IsUserAdd)
                    AddCommand.ExecuteNonQuery();
            }
            return IsUserAdd;
        }
        public bool admin_add(string userName, string password)
        {
            bool IsUserAdd;
            string userAddCommand = "insert into admin(AdminName,Password)" +
                "value('" + userName + "','" + password + "')";
            string seekUserCommand = "select * from admin where AdminName='" + userName + "'";
            using (MySqlConnection userAddConnection = new MySqlConnection(connectionString))
            {
                userAddConnection.Open();
                MySqlCommand AddCommand = new MySqlCommand(userAddCommand, userAddConnection);
                MySqlCommand SeekCommand = new MySqlCommand(seekUserCommand, userAddConnection);
                using (MySqlDataReader mySqlDataReader = SeekCommand.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        IsUserAdd = false;
                    }
                    else
                    {
                        IsUserAdd = true;
                    }
                }
                if (IsUserAdd)
                    AddCommand.ExecuteNonQuery();
            }
            return IsUserAdd;
        }
        public DataTable showborrow() //显示数据库的借阅表
        {
            DataTable books;
            string showBookCommandText = "select 图书编号,书名,借阅人,借阅时间,应归还时间,是否归还,归还时间 " +
                "from loaninfo";

            using (MySqlConnection showborrowConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showborrowConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                books = dataTable;
            }
            return books;
        }
        public DataTable seekBookByName_borrow(string bookName) //显示数据库中满足名字字段的借阅书籍
        {
            string seekBookByNameCommand = "select 图书编号,书名,借阅人,借阅时间,应归还时间,是否归还,归还时间" +
                " from loaninfo where 书名='" + bookName + "'";

            DataTable bookData;

            using (MySqlConnection seekBookByNameConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekBookByNameCommand, seekBookByNameConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookData = dataTable;
            }
            return bookData;
        }
        public DataTable seekBookByUserName_borrow(string UserName) //显示数据库中满足借书人字段的借阅书籍
        {
            string seekBookByNameCommand = "select 图书编号,书名,借阅人,借阅时间,应归还时间,是否归还,归还时间" +
                " from loaninfo where 借阅人='" + UserName + "'";

            DataTable bookData;

            using (MySqlConnection seekBookByNameConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekBookByNameCommand, seekBookByNameConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookData = dataTable;
            }
            return bookData;
        }

        public bool borrowAdd(string bookName, string name, string borrowTime, string bookNumber) //将借阅的书籍登记到数据库的借阅表中
        {
            bool IsborrowAdd = false;
            string borrowBookCommand = "insert into loaninfo(图书编号,书名,借阅人,借阅时间,应归还时间,是否归还)" +
                 "values('" + bookNumber + "','" + bookName + "','" + name + "','" + borrowTime + "','一个月','否')";
            string seekBookCommand = "select * from loaninfo where 书名='" + bookName + "'" + " and 借阅人='" + name + "'"
                + " and 是否归还='否'";

            using (MySqlConnection userAddConnection = new MySqlConnection(connectionString))
            {
                userAddConnection.Open();
                MySqlCommand AddCommand = new MySqlCommand(borrowBookCommand, userAddConnection);
                MySqlCommand SeekCommand = new MySqlCommand(seekBookCommand, userAddConnection);
                using (MySqlDataReader mySqlDataReader = SeekCommand.ExecuteReader())
                {

                    if (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader["是否归还"].ToString() == "否")
                        {
                            IsborrowAdd = false;
                        }
                        else
                        {
                            IsborrowAdd = true;
                        }
                    }
                    else IsborrowAdd = true;
                }
                if (IsborrowAdd)
                    AddCommand.ExecuteNonQuery();
            }
            return IsborrowAdd;
        }
        public DataTable seekLoginData(string userClass, string value)
        {
            string seekLoginDataByClassCommandText = "select * from loginrecord " +
                "where " + userClass + "='" + value + "'";
            DataTable seekUsers;
            using (MySqlConnection seekLoginDataConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekLoginDataByClassCommandText, seekLoginDataConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                seekUsers = dataTable;
            }
            return seekUsers;
        }
    }
}

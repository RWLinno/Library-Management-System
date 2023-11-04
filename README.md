# Library-Management-System
 windows编程课程设计，基于.NET、C#、MySQL、Windows Forms实现的图书管理系统。

项目地址：https://github.com/RWLinno/Library-Management-System



# 帮助文档

该项目包括：

\-     该说明文档（安装说明和使用说明）

\-     课程设计报告

\-     视频介绍（视频版的使用说明和项目介绍）

\-     Book_Management_System_Setup文件夹：包含程序安装包

\-     Code文件夹：包含所有项目源代码及其他相关文件，具体包含：

o  图书管理系统文件夹：程序的主要设计代码

o  Create.sql：数据库初始化sql命令

o  Pic文件夹：截取的一些项目制作图像

o  以及其他素材包括图标、Visual Studio解决方案和Jetbrains Rider运行环境。

 

 

# 安装说明

1.移动到项目目录下的`\Book_Management_System_Setup\Debug\`文件夹中如图所示：

![img](https://s2.loli.net/2023/11/05/Whi6arV9tm5cGQy.png)

 

2.使用Book_Management_System_Setup.msi活着setup.exe安装程序，将程序放在适合目录下：

![img](https://s2.loli.net/2023/11/05/eM3cmJUV6YELF7q.png)

 

3.为了保证用户体验，在打开软件前请确保数据库中存在超级管理员，账号为”root”，密码为”123456”。可以通过运行Code目录中的create.sql查询命令来创建软件所需用到的数据库和超级管理员。

![img](https://s2.loli.net/2023/11/05/WCXL1KAwRfjQGFc.png)

 

4.安装完成后，运行安装目录中的exe文件即可使用该程序。项目所需要用到的数据库结构如下。
 ![img](https://s2.loli.net/2023/11/05/Q3OnZf9rVLx5IHa.jpg)

 

 

5.运行安装目录下的exe文件即可打开软件。

![img](https://s2.loli.net/2023/11/05/3XfWCQuTztLa85d.png)

 






























# 使用说明书

1.当开始运行程序时，跳转到主页面，用户需要选择登录、注册或注销。

![img](https://s2.loli.net/2023/11/05/qKrOSAxV1z3Bn7g.png)

2.首先选择注册时，跳转到注册页面。手机位数要符合规范，用户名和密码要用字母和数字组成。密码和确认密码必须保持一直，随后完成注册。

![img](https://s2.loli.net/2023/11/05/f6KCTr4SIp2dX3l.png)

3．按下访问官网时可以通过浏览器控件获取学校图书馆的相关资讯。可以和登录的主界面同时进行。

![img](https://s2.loli.net/2023/11/05/aLmUVf9GjD4nFJB.jpg)

 

4.当读者选择登录按钮时，可以输入用户名和密码，并且选择以普通用户或者是管理员的模式登录，当输入的用户名或密码不正确时，会返回不正确的提示，否则跳到相应的用户界面。同时该页面支持跳转到修改密码。

![img](https://s2.loli.net/2023/11/05/DxXJIU8jRGyHg52.png)

![img](https://s2.loli.net/2023/11/05/sjZ6OBIt9iwrLUW.png)

 

5.如果是以普通用户的身份登录到该图书管理系统中，窗口主要呈现查书、借书和查看借书记录的功能。点击借书按钮，可以知道该用户有哪些书没有还，并提供快捷的一键借还书服务。在用户界面还可以按照书名或者书籍类别对书库进行查询。

![img](https://s2.loli.net/2023/11/05/OLWwTUl4xu13DQy.jpg)

![img](https://s2.loli.net/2023/11/05/vtrPDRp6Ua2gJeX.jpg)

 

6.如果是以管理员的身份登录到图书管理系统中，那么在主页面可以跳转到用户管理和图书管理窗口。在用户管理系统的窗口中。可以看到所有已注册普通用户的信息，并且支持用户的条件查询、删除记录以及决定该用户的管理员权限。

![img](https://s2.loli.net/2023/11/05/n7muLfqMeGj3BDh.jpg)

7.选择用户管理，左边列表的用户，修改权限可以切换该用户的性质为管理员或普通用户。查询课通过用户名、姓名、性别、学院、注册日期进行精准查询，若条件为空，则刷新为初始列表。

![img](https://s2.loli.net/2023/11/05/i8NOrfXRlGHjF7T.jpg)

![img](https://s2.loli.net/2023/11/05/ICLirAXSKpj23GY.jpg)

 

7.在图书管理系统中，则可以看到数据库中的所有书籍，可以实现对所有书籍信息的增删改查。此外，可以根据书名或者借阅人查询对应的借书记录。对于选中相应书记记录的查询、修改和删除操作，均可在该页面进行，而添加书目则在另外一个窗口。

![img](https://s2.loli.net/2023/11/05/uKotCQDplsFBfM9.jpg)

 

8.添加书目有额外的一个页面，把相关信息填写进去，则可以在数据库中找到新增的书目了。

![img](https://s2.loli.net/2023/11/05/nvIT52DdKcLB6xr.jpg)

 

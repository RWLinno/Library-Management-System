namespace 图书管理系统
{
    partial class BooksManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitButtom = new System.Windows.Forms.Button();
            this.bookClassComboBox = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.borrowRwcordButtom = new System.Windows.Forms.Button();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.publishTimeText = new System.Windows.Forms.TextBox();
            this.pressText = new System.Windows.Forms.TextBox();
            this.bookKindText = new System.Windows.Forms.TextBox();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.alterButtom = new System.Windows.Forms.Button();
            this.bookAddButtom = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButtom);
            this.groupBox1.Controls.Add(this.bookClassComboBox);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.borrowRwcordButtom);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.alterButtom);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.deleteBook);
            this.groupBox1.Controls.Add(this.bookAddButtom);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(602, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(497, 348);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(100, 22);
            this.exitButtom.TabIndex = 10;
            this.exitButtom.Text = "退出";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // bookClassComboBox
            // 
            this.bookClassComboBox.FormattingEnabled = true;
            this.bookClassComboBox.Items.AddRange(new object[] {
            "IT",
            "科学",
            "文化"});
            this.bookClassComboBox.Location = new System.Drawing.Point(332, 25);
            this.bookClassComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookClassComboBox.Name = "bookClassComboBox";
            this.bookClassComboBox.Size = new System.Drawing.Size(106, 20);
            this.bookClassComboBox.TabIndex = 1;
            this.bookClassComboBox.Text = "IT";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(497, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 22);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // borrowRwcordButtom
            // 
            this.borrowRwcordButtom.Location = new System.Drawing.Point(497, 293);
            this.borrowRwcordButtom.Name = "borrowRwcordButtom";
            this.borrowRwcordButtom.Size = new System.Drawing.Size(100, 22);
            this.borrowRwcordButtom.TabIndex = 8;
            this.borrowRwcordButtom.Text = "借书记录";
            this.borrowRwcordButtom.UseVisualStyleBackColor = true;
            this.borrowRwcordButtom.Click += new System.EventHandler(this.borrowRwcordButtom_Click);
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(452, 19);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(65, 26);
            this.searchBookButtom.TabIndex = 2;
            this.searchBookButtom.Text = "查找书名";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(12, 29);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(65, 12);
            this.lblBookNameForSearch.TabIndex = 34;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(81, 24);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(153, 21);
            this.bookNameTextBox.TabIndex = 0;
            // 
            // booksDVG
            // 
            this.booksDVG.AllowUserToAddRows = false;
            this.booksDVG.AllowUserToDeleteRows = false;
            this.booksDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDVG.Location = new System.Drawing.Point(12, 52);
            this.booksDVG.Name = "booksDVG";
            this.booksDVG.ReadOnly = true;
            this.booksDVG.RowHeadersWidth = 82;
            this.booksDVG.RowTemplate.Height = 23;
            this.booksDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDVG.Size = new System.Drawing.Size(585, 135);
            this.booksDVG.TabIndex = 4;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // searchByKindButtom
            // 
            this.searchByKindButtom.Location = new System.Drawing.Point(523, 19);
            this.searchByKindButtom.Name = "searchByKindButtom";
            this.searchByKindButtom.Size = new System.Drawing.Size(63, 26);
            this.searchByKindButtom.TabIndex = 3;
            this.searchByKindButtom.Text = "查找类别";
            this.searchByKindButtom.UseVisualStyleBackColor = true;
            this.searchByKindButtom.Click += new System.EventHandler(this.searchByKindButtom_Click);
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(262, 28);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(65, 12);
            this.lblKind.TabIndex = 27;
            this.lblKind.Text = "书籍类别：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookNameText);
            this.groupBox2.Controls.Add(this.authorText);
            this.groupBox2.Controls.Add(this.publishTimeText);
            this.groupBox2.Controls.Add(this.pressText);
            this.groupBox2.Controls.Add(this.bookKindText);
            this.groupBox2.Controls.Add(this.bookDigestTextBox);
            this.groupBox2.Controls.Add(this.lblPress);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblBookKind);
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.lblBookName);
            this.groupBox2.Location = new System.Drawing.Point(11, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(481, 187);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可修改部分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "摘要：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(55, 18);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(180, 21);
            this.bookNameText.TabIndex = 0;
            this.bookNameText.TextChanged += new System.EventHandler(this.bookNameText_TextChanged);
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(55, 45);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(180, 21);
            this.authorText.TabIndex = 1;
            // 
            // publishTimeText
            // 
            this.publishTimeText.Location = new System.Drawing.Point(299, 70);
            this.publishTimeText.Name = "publishTimeText";
            this.publishTimeText.Size = new System.Drawing.Size(170, 21);
            this.publishTimeText.TabIndex = 4;
            // 
            // pressText
            // 
            this.pressText.Location = new System.Drawing.Point(299, 39);
            this.pressText.Name = "pressText";
            this.pressText.Size = new System.Drawing.Size(170, 21);
            this.pressText.TabIndex = 3;
            // 
            // bookKindText
            // 
            this.bookKindText.Location = new System.Drawing.Point(299, 12);
            this.bookKindText.Name = "bookKindText";
            this.bookKindText.Size = new System.Drawing.Size(170, 21);
            this.bookKindText.TabIndex = 2;
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.Location = new System.Drawing.Point(16, 98);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(454, 81);
            this.bookDigestTextBox.TabIndex = 5;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(249, 45);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(53, 12);
            this.lblPress.TabIndex = 43;
            this.lblPress.Text = "出版社：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(237, 74);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 12);
            this.lblTime.TabIndex = 42;
            this.lblTime.Text = "出版时间：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(261, 18);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(41, 12);
            this.lblBookKind.TabIndex = 41;
            this.lblBookKind.Text = "类别：";
            this.lblBookKind.Click += new System.EventHandler(this.lblBookKind_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(16, 47);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 12);
            this.lblAuthor.TabIndex = 40;
            this.lblAuthor.Text = "作者：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(16, 24);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(41, 12);
            this.lblBookName.TabIndex = 39;
            this.lblBookName.Text = "书名：";
            // 
            // alterButtom
            // 
            this.alterButtom.AutoSize = true;
            this.alterButtom.Location = new System.Drawing.Point(497, 239);
            this.alterButtom.Name = "alterButtom";
            this.alterButtom.Size = new System.Drawing.Size(100, 22);
            this.alterButtom.TabIndex = 6;
            this.alterButtom.Text = "修改书目";
            this.alterButtom.UseVisualStyleBackColor = true;
            this.alterButtom.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // bookAddButtom
            // 
            this.bookAddButtom.Location = new System.Drawing.Point(497, 212);
            this.bookAddButtom.Name = "bookAddButtom";
            this.bookAddButtom.Size = new System.Drawing.Size(100, 22);
            this.bookAddButtom.TabIndex = 5;
            this.bookAddButtom.Text = "新增书目";
            this.bookAddButtom.UseVisualStyleBackColor = true;
            this.bookAddButtom.Click += new System.EventHandler(this.bookAddButtom_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(497, 266);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(100, 22);
            this.deleteBook.TabIndex = 7;
            this.deleteBook.Text = "删除书目";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(38, 151);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 16);
            this.lblContent.TabIndex = 38;
            // 
            // BooksManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BooksManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.Button borrowRwcordButtom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox publishTimeText;
        private System.Windows.Forms.TextBox pressText;
        private System.Windows.Forms.TextBox bookKindText;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button alterButtom;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button bookAddButtom;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox bookClassComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
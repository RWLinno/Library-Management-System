namespace 图书管理系统
{
    partial class CommonUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bookClassComboBox = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.borrowButtoom = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bookClassComboBox);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.borrowButtoom);
            this.groupBox1.Controls.Add(this.bookDigestTextBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(663, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查书系统";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookClassComboBox
            // 
            this.bookClassComboBox.FormattingEnabled = true;
            this.bookClassComboBox.Items.AddRange(new object[] {
            "IT",
            "文学",
            "科学"});
            this.bookClassComboBox.Location = new System.Drawing.Point(467, 13);
            this.bookClassComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookClassComboBox.Name = "bookClassComboBox";
            this.bookClassComboBox.Size = new System.Drawing.Size(110, 20);
            this.bookClassComboBox.TabIndex = 2;
            this.bookClassComboBox.Text = "IT";
            this.bookClassComboBox.SelectedIndexChanged += new System.EventHandler(this.bookClassComboBox_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(520, 309);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(130, 37);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "还书";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // borrowButtoom
            // 
            this.borrowButtoom.Location = new System.Drawing.Point(12, 308);
            this.borrowButtoom.Name = "borrowButtoom";
            this.borrowButtoom.Size = new System.Drawing.Size(130, 37);
            this.borrowButtoom.TabIndex = 6;
            this.borrowButtoom.Text = "借书";
            this.borrowButtoom.UseVisualStyleBackColor = true;
            this.borrowButtoom.Click += new System.EventHandler(this.borrowButtoom_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(2, 214);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 16);
            this.lblContent.TabIndex = 5;
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.Location = new System.Drawing.Point(8, 217);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(644, 85);
            this.bookDigestTextBox.TabIndex = 5;
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(310, 15);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(71, 23);
            this.searchBookButtom.TabIndex = 1;
            this.searchBookButtom.Text = "查找书名";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.searchBookButtom_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(8, 20);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(65, 12);
            this.lblBookNameForSearch.TabIndex = 6;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(79, 16);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(225, 21);
            this.bookNameTextBox.TabIndex = 0;
            // 
            // booksDVG
            // 
            this.booksDVG.AllowUserToAddRows = false;
            this.booksDVG.AllowUserToDeleteRows = false;
            this.booksDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDVG.Location = new System.Drawing.Point(5, 44);
            this.booksDVG.Name = "booksDVG";
            this.booksDVG.ReadOnly = true;
            this.booksDVG.RowHeadersWidth = 82;
            this.booksDVG.RowTemplate.Height = 23;
            this.booksDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDVG.Size = new System.Drawing.Size(645, 167);
            this.booksDVG.TabIndex = 4;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            this.booksDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellContentClick);
            // 
            // searchByKindButtom
            // 
            this.searchByKindButtom.Location = new System.Drawing.Point(582, 12);
            this.searchByKindButtom.Name = "searchByKindButtom";
            this.searchByKindButtom.Size = new System.Drawing.Size(71, 24);
            this.searchByKindButtom.TabIndex = 3;
            this.searchByKindButtom.Text = "查找书类";
            this.searchByKindButtom.UseVisualStyleBackColor = true;
            this.searchByKindButtom.Click += new System.EventHandler(this.searchByKindButtom_Click);
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(397, 16);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(65, 12);
            this.lblKind.TabIndex = 8;
            this.lblKind.Text = "书籍类别：";
            // 
            // CommonUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 361);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CommonUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button borrowButtoom;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox bookClassComboBox;
    }
}
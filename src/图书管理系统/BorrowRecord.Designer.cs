namespace 图书管理系统
{
    partial class BorrowRecord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowRecord));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateBtuttom = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.returnBookButtom = new System.Windows.Forms.Button();
            this.libraryRecordDGV = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryRecordDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateBtuttom);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.returnBookButtom);
            this.groupBox1.Controls.Add(this.libraryRecordDGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(563, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // updateBtuttom
            // 
            this.updateBtuttom.Location = new System.Drawing.Point(199, 13);
            this.updateBtuttom.Name = "updateBtuttom";
            this.updateBtuttom.Size = new System.Drawing.Size(111, 25);
            this.updateBtuttom.TabIndex = 1;
            this.updateBtuttom.Text = "刷新";
            this.updateBtuttom.UseVisualStyleBackColor = true;
            this.updateBtuttom.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(316, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // returnBookButtom
            // 
            this.returnBookButtom.Location = new System.Drawing.Point(92, 13);
            this.returnBookButtom.Name = "returnBookButtom";
            this.returnBookButtom.Size = new System.Drawing.Size(101, 25);
            this.returnBookButtom.TabIndex = 0;
            this.returnBookButtom.Text = "还书";
            this.returnBookButtom.UseVisualStyleBackColor = true;
            this.returnBookButtom.Click += new System.EventHandler(this.returnBookButtom_Click);
            // 
            // libraryRecordDGV
            // 
            this.libraryRecordDGV.AllowUserToAddRows = false;
            this.libraryRecordDGV.AllowUserToDeleteRows = false;
            this.libraryRecordDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.libraryRecordDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.libraryRecordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryRecordDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.libraryRecordDGV.Location = new System.Drawing.Point(5, 44);
            this.libraryRecordDGV.Name = "libraryRecordDGV";
            this.libraryRecordDGV.ReadOnly = true;
            this.libraryRecordDGV.RowHeadersWidth = 82;
            this.libraryRecordDGV.RowTemplate.Height = 23;
            this.libraryRecordDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.libraryRecordDGV.Size = new System.Drawing.Size(554, 264);
            this.libraryRecordDGV.TabIndex = 3;
            // 
            // BorrowRecord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(563, 311);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借书记录";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryRecordDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateBtuttom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button returnBookButtom;
        private System.Windows.Forms.DataGridView libraryRecordDGV;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
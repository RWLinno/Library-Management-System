﻿namespace 图书管理系统
{
    partial class pwdModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwdModify));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButtom = new System.Windows.Forms.Button();
            this.okButtom = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.lblNewPwdAgain = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButtom);
            this.groupBox1.Controls.Add(this.okButtom);
            this.groupBox1.Controls.Add(this.confirmNewPasswordTextBox);
            this.groupBox1.Controls.Add(this.newPasswordTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.lblNewPwd);
            this.groupBox1.Controls.Add(this.lblNewPwdAgain);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.hintLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(329, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "密码修改";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cancelButtom
            // 
            this.cancelButtom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButtom.Location = new System.Drawing.Point(232, 82);
            this.cancelButtom.Name = "cancelButtom";
            this.cancelButtom.Size = new System.Drawing.Size(75, 23);
            this.cancelButtom.TabIndex = 5;
            this.cancelButtom.Text = "取消";
            this.cancelButtom.UseVisualStyleBackColor = true;
            this.cancelButtom.Click += new System.EventHandler(this.cancelButtom_Click);
            // 
            // okButtom
            // 
            this.okButtom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okButtom.Location = new System.Drawing.Point(232, 44);
            this.okButtom.Name = "okButtom";
            this.okButtom.Size = new System.Drawing.Size(75, 23);
            this.okButtom.TabIndex = 4;
            this.okButtom.Text = "确认修改";
            this.okButtom.UseVisualStyleBackColor = true;
            this.okButtom.Click += new System.EventHandler(this.okButtom_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(215, 109);
            this.hintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(0, 12);
            this.hintLabel.TabIndex = 22;
            // 
            // lblNewPwdAgain
            // 
            this.lblNewPwdAgain.AutoSize = true;
            this.lblNewPwdAgain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwdAgain.Location = new System.Drawing.Point(5, 109);
            this.lblNewPwdAgain.Name = "lblNewPwdAgain";
            this.lblNewPwdAgain.Size = new System.Drawing.Size(71, 12);
            this.lblNewPwdAgain.TabIndex = 20;
            this.lblNewPwdAgain.Text = "确认新密码:";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwd.Location = new System.Drawing.Point(29, 82);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(47, 12);
            this.lblNewPwd.TabIndex = 19;
            this.lblNewPwd.Text = "新密码:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(29, 55);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(47, 12);
            this.lblPwd.TabIndex = 18;
            this.lblPwd.Text = "原密码:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(29, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 12);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "用户名:";
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(96, 100);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.PasswordChar = '*';
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(114, 21);
            this.confirmNewPasswordTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(96, 73);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(114, 21);
            this.newPasswordTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(114, 21);
            this.passwordTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(114, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // pwdModify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(329, 145);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pwdModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码修改";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNewPwdAgain;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cancelButtom;
        private System.Windows.Forms.Button okButtom;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label hintLabel;
    }
}
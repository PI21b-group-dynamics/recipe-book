using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace recipe_book
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            loginInp = new TextBox();
            passwordInp = new TextBox();
            signInBtn = new Button();
            signUpBtn = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(loginInp, 0, 0);
            tableLayoutPanel1.Controls.Add(passwordInp, 0, 1);
            tableLayoutPanel1.Controls.Add(signInBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(signUpBtn, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(9, 8, 9, 8);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.Size = new Size(269, 167);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // loginInp
            // 
            loginInp.Dock = DockStyle.Fill;
            loginInp.Location = new Point(12, 10);
            loginInp.Margin = new Padding(3, 2, 3, 2);
            loginInp.Name = "loginInp";
            loginInp.PlaceholderText = "Логин";
            loginInp.Size = new Size(245, 23);
            loginInp.TabIndex = 0;
            // 
            // passwordInp
            // 
            passwordInp.Dock = DockStyle.Fill;
            passwordInp.Location = new Point(12, 37);
            passwordInp.Margin = new Padding(3, 2, 3, 2);
            passwordInp.Name = "passwordInp";
            passwordInp.PlaceholderText = "Пароль";
            passwordInp.Size = new Size(245, 23);
            passwordInp.TabIndex = 1;
            passwordInp.UseSystemPasswordChar = true;
            // 
            // signInBtn
            // 
            signInBtn.Dock = DockStyle.Fill;
            signInBtn.Location = new Point(12, 75);
            signInBtn.Margin = new Padding(3, 2, 3, 2);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(245, 22);
            signInBtn.TabIndex = 2;
            signInBtn.Text = "Войти";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += signInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Dock = DockStyle.Fill;
            signUpBtn.Location = new Point(12, 116);
            signUpBtn.Margin = new Padding(3, 2, 3, 2);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(245, 22);
            signUpBtn.TabIndex = 3;
            signUpBtn.Text = "Зарегистрироваться";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 4;
            label1.Text = "или";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(12, 140);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(245, 19);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забыли пароль?";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 167);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += AuthForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox loginInp;
        private TextBox passwordInp;
        private Button signInBtn;
        private Button signUpBtn;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}

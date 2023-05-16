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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(307, 223);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // loginInp
            // 
            loginInp.Dock = DockStyle.Fill;
            loginInp.Location = new Point(13, 13);
            loginInp.Name = "loginInp";
            loginInp.PlaceholderText = "Логин / e-mail";
            loginInp.Size = new Size(281, 27);
            loginInp.TabIndex = 0;
            // 
            // passwordInp
            // 
            passwordInp.Dock = DockStyle.Fill;
            passwordInp.Location = new Point(13, 46);
            passwordInp.Name = "passwordInp";
            passwordInp.PlaceholderText = "Пароль";
            passwordInp.Size = new Size(281, 27);
            passwordInp.TabIndex = 1;
            passwordInp.UseSystemPasswordChar = true;
            // 
            // signInBtn
            // 
            signInBtn.Dock = DockStyle.Fill;
            signInBtn.Location = new Point(13, 94);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(281, 29);
            signInBtn.TabIndex = 2;
            signInBtn.Text = "Войти";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += signInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Dock = DockStyle.Fill;
            signUpBtn.Location = new Point(13, 149);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(281, 29);
            signUpBtn.TabIndex = 3;
            signUpBtn.Text = "Зарегистрироваться";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(13, 126);
            label1.Name = "label1";
            label1.Size = new Size(281, 20);
            label1.TabIndex = 4;
            label1.Text = "или";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(13, 181);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(281, 32);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забыли пароль?";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 223);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

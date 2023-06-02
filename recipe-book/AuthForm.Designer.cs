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
            label1 = new Label();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            btnSignUp = new Button();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 5);
            tableLayoutPanel1.Controls.Add(btnSignIn, 0, 4);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(txtEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(txtLogin, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSignUp, 0, 6);
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 11, 10, 11);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(307, 258);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(13, 165);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 4;
            label1.Text = "или";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            btnSignIn.Enabled = false;
            btnSignIn.Location = new Point(13, 133);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(281, 29);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Войти";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(13, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(281, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += authFields_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(13, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += authFields_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.Dock = DockStyle.Top;
            txtLogin.Location = new Point(13, 14);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Size = new Size(281, 27);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += authFields_TextChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Enabled = false;
            btnSignUp.Location = new Point(13, 193);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(281, 29);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Зарегистрироваться";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(13, 225);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(281, 22);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забыли пароль?";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 258);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Button btnSignUp;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txtLogin;
    }
}

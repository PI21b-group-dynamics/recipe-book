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
            tbcAuth = new TabControl();
            tabSignIn = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtLoginOrEmail = new TextBox();
            lblForgotPassword = new LinkLabel();
            tabSignUp = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPassword_ = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            btnSignUp = new Button();
            picUser = new PictureBox();
            dlgLoadProfilePic = new OpenFileDialog();
            tbcAuth.SuspendLayout();
            tabSignIn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabSignUp.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // tbcAuth
            // 
            tbcAuth.Controls.Add(tabSignIn);
            tbcAuth.Controls.Add(tabSignUp);
            tbcAuth.Dock = DockStyle.Fill;
            tbcAuth.Location = new Point(0, 0);
            tbcAuth.Name = "tbcAuth";
            tbcAuth.SelectedIndex = 0;
            tbcAuth.Size = new Size(292, 341);
            tbcAuth.TabIndex = 0;
            // 
            // tabSignIn
            // 
            tabSignIn.Controls.Add(tableLayoutPanel1);
            tabSignIn.Location = new Point(4, 29);
            tabSignIn.Name = "tabSignIn";
            tabSignIn.Padding = new Padding(3);
            tabSignIn.Size = new Size(284, 308);
            tabSignIn.TabIndex = 0;
            tabSignIn.Text = "Вход";
            tabSignIn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnSignIn, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtLoginOrEmail, 0, 0);
            tableLayoutPanel1.Controls.Add(lblForgotPassword, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 11, 10, 11);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(278, 302);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Dock = DockStyle.Top;
            btnSignIn.Enabled = false;
            btnSignIn.Location = new Point(13, 100);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(252, 29);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Войти";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(13, 47);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(252, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += signInFields_TextChanged;
            // 
            // txtLoginOrEmail
            // 
            txtLoginOrEmail.Dock = DockStyle.Top;
            txtLoginOrEmail.Location = new Point(13, 14);
            txtLoginOrEmail.Name = "txtLoginOrEmail";
            txtLoginOrEmail.PlaceholderText = "Логин / E-mail";
            txtLoginOrEmail.Size = new Size(252, 27);
            txtLoginOrEmail.TabIndex = 6;
            txtLoginOrEmail.TextChanged += signInFields_TextChanged;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Dock = DockStyle.Top;
            lblForgotPassword.Location = new Point(13, 132);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(252, 20);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Забыли пароль?";
            lblForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabSignUp
            // 
            tabSignUp.Controls.Add(tableLayoutPanel2);
            tabSignUp.Location = new Point(4, 29);
            tabSignUp.Name = "tabSignUp";
            tabSignUp.Padding = new Padding(3);
            tabSignUp.Size = new Size(284, 308);
            tabSignUp.TabIndex = 1;
            tabSignUp.Text = "Регистрация";
            tabSignUp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(txtPassword_, 0, 3);
            tableLayoutPanel2.Controls.Add(txtEmail, 0, 2);
            tableLayoutPanel2.Controls.Add(txtLogin, 0, 1);
            tableLayoutPanel2.Controls.Add(btnSignUp, 0, 5);
            tableLayoutPanel2.Controls.Add(picUser, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(6);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(278, 302);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtPassword_
            // 
            txtPassword_.Dock = DockStyle.Top;
            txtPassword_.Location = new Point(9, 211);
            txtPassword_.Name = "txtPassword_";
            txtPassword_.PlaceholderText = "Пароль";
            txtPassword_.Size = new Size(260, 27);
            txtPassword_.TabIndex = 1;
            txtPassword_.UseSystemPasswordChar = true;
            txtPassword_.TextChanged += signUpFields_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(9, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += signUpFields_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.Dock = DockStyle.Top;
            txtLogin.Location = new Point(9, 145);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Size = new Size(260, 27);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += signUpFields_TextChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Dock = DockStyle.Top;
            btnSignUp.Enabled = false;
            btnSignUp.Location = new Point(9, 264);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(260, 29);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Зарегистрироваться";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // picUser
            // 
            picUser.BackgroundImageLayout = ImageLayout.Zoom;
            picUser.Image = Properties.Resources.UserIcon;
            picUser.Location = new Point(9, 9);
            picUser.Name = "picUser";
            picUser.Size = new Size(128, 128);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 7;
            picUser.TabStop = false;
            picUser.Click += picUser_Click;
            // 
            // dlgLoadProfilePic
            // 
            dlgLoadProfilePic.DefaultExt = "jpg";
            dlgLoadProfilePic.FileName = "Фото.jpg";
            dlgLoadProfilePic.Filter = "Изображения|*.jpg;*.png";
            dlgLoadProfilePic.Title = "Выберите фото профиля";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 341);
            Controls.Add(tbcAuth);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            tbcAuth.ResumeLayout(false);
            tabSignIn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabSignUp.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcAuth;
        private TabPage tabSignIn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSignIn;
        private TextBox txtPassword;
        private TextBox txtLoginOrEmail;
        private TabPage tabSignUp;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPassword_;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private Button btnSignUp;
        private LinkLabel lblForgotPassword;
        private PictureBox picUser;
        private OpenFileDialog dlgLoadProfilePic;
    }
}

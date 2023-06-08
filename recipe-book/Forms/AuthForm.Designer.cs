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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
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
            tbcAuth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbcAuth.Location = new Point(0, 0);
            tbcAuth.Margin = new Padding(3, 2, 3, 2);
            tbcAuth.Name = "tbcAuth";
            tbcAuth.SelectedIndex = 0;
            tbcAuth.Size = new Size(256, 342);
            tbcAuth.TabIndex = 0;
            // 
            // tabSignIn
            // 
            tabSignIn.Controls.Add(tableLayoutPanel1);
            tabSignIn.Location = new Point(4, 26);
            tabSignIn.Margin = new Padding(3, 2, 3, 2);
            tabSignIn.Name = "tabSignIn";
            tabSignIn.Padding = new Padding(3, 2, 3, 2);
            tabSignIn.Size = new Size(248, 312);
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
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(9, 55, 9, 55);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(242, 308);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Dock = DockStyle.Top;
            btnSignIn.Enabled = false;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignIn.Location = new Point(12, 147);
            btnSignIn.Margin = new Padding(3, 6, 3, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(218, 39);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Войти";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(12, 95);
            txtPassword.Margin = new Padding(3, 0, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(218, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += signInFields_TextChanged;
            // 
            // txtLoginOrEmail
            // 
            txtLoginOrEmail.Dock = DockStyle.Top;
            txtLoginOrEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginOrEmail.Location = new Point(12, 55);
            txtLoginOrEmail.Margin = new Padding(3, 0, 3, 11);
            txtLoginOrEmail.Name = "txtLoginOrEmail";
            txtLoginOrEmail.PlaceholderText = "Логин / E-mail";
            txtLoginOrEmail.Size = new Size(218, 29);
            txtLoginOrEmail.TabIndex = 6;
            txtLoginOrEmail.TextChanged += signInFields_TextChanged;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Dock = DockStyle.Top;
            lblForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblForgotPassword.Location = new Point(12, 268);
            lblForgotPassword.Margin = new Padding(3, 80, 3, 0);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(218, 19);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Забыли пароль?";
            lblForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabSignUp
            // 
            tabSignUp.Controls.Add(tableLayoutPanel2);
            tabSignUp.Location = new Point(4, 26);
            tabSignUp.Margin = new Padding(3, 2, 3, 2);
            tabSignUp.Name = "tabSignUp";
            tabSignUp.Padding = new Padding(3, 2, 3, 2);
            tabSignUp.Size = new Size(248, 312);
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
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 4, 5, 4);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(242, 308);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtPassword_
            // 
            txtPassword_.Dock = DockStyle.Top;
            txtPassword_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword_.Location = new Point(8, 211);
            txtPassword_.Margin = new Padding(3, 2, 3, 2);
            txtPassword_.Name = "txtPassword_";
            txtPassword_.PlaceholderText = "Пароль";
            txtPassword_.Size = new Size(226, 29);
            txtPassword_.TabIndex = 1;
            txtPassword_.UseSystemPasswordChar = true;
            txtPassword_.TextChanged += signUpFields_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(8, 172);
            txtEmail.Margin = new Padding(3, 2, 3, 8);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(226, 29);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += signUpFields_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.Dock = DockStyle.Top;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(8, 133);
            txtLogin.Margin = new Padding(3, 2, 3, 8);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Size = new Size(226, 29);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += signUpFields_TextChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Dock = DockStyle.Top;
            btnSignUp.Enabled = false;
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.Location = new Point(8, 261);
            btnSignUp.Margin = new Padding(3, 4, 3, 6);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(226, 37);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Зарегистрироваться";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // picUser
            // 
            picUser.BackgroundImageLayout = ImageLayout.Zoom;
            picUser.Image = (System.Drawing.Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(57, 14);
            picUser.Margin = new Padding(52, 10, 3, 10);
            picUser.Name = "picUser";
            picUser.Size = new Size(128, 103);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 342);
            Controls.Add(tbcAuth);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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

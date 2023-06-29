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
			LoginTLP = new TableLayoutPanel();
			txtLoginOrEmail = new TextBox();
			txtPassword = new TextBox();
			btnSignIn = new Button();
			lblForgotPassword = new LinkLabel();
			tabSignUp = new TabPage();
			SignUpTLP = new TableLayoutPanel();
			picUser = new PictureBox();
			linkLabel1 = new LinkLabel();
			txtLogin = new TextBox();
			txtEmail = new TextBox();
			txtPassword_ = new TextBox();
			btnSignUp = new Button();
			dlgLoadProfilePic = new OpenFileDialog();
			tbcAuth.SuspendLayout();
			tabSignIn.SuspendLayout();
			LoginTLP.SuspendLayout();
			tabSignUp.SuspendLayout();
			SignUpTLP.SuspendLayout();
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
			tabSignIn.Controls.Add(LoginTLP);
			tabSignIn.Location = new Point(4, 26);
			tabSignIn.Margin = new Padding(3, 2, 3, 2);
			tabSignIn.Name = "tabSignIn";
			tabSignIn.Padding = new Padding(3, 2, 3, 2);
			tabSignIn.Size = new Size(248, 312);
			tabSignIn.TabIndex = 0;
			tabSignIn.Text = "Вход";
			tabSignIn.UseVisualStyleBackColor = true;
			// 
			// LoginTLP
			// 
			LoginTLP.ColumnCount = 1;
			LoginTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			LoginTLP.Controls.Add(txtLoginOrEmail, 0, 0);
			LoginTLP.Controls.Add(txtPassword, 0, 1);
			LoginTLP.Controls.Add(btnSignIn, 0, 3);
			LoginTLP.Controls.Add(lblForgotPassword, 0, 2);
			LoginTLP.Dock = DockStyle.Fill;
			LoginTLP.Location = new Point(3, 2);
			LoginTLP.Name = "LoginTLP";
			LoginTLP.RowCount = 3;
			LoginTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			LoginTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			LoginTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			LoginTLP.Size = new Size(242, 308);
			LoginTLP.TabIndex = 7;
			// 
			// txtLoginOrEmail
			// 
			txtLoginOrEmail.Dock = DockStyle.Fill;
			txtLoginOrEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtLoginOrEmail.Location = new Point(3, 0);
			txtLoginOrEmail.Margin = new Padding(3, 0, 3, 11);
			txtLoginOrEmail.MaxLength = 40;
			txtLoginOrEmail.Name = "txtLoginOrEmail";
			txtLoginOrEmail.PlaceholderText = "Логин / E-mail";
			txtLoginOrEmail.Size = new Size(236, 29);
			txtLoginOrEmail.TabIndex = 6;
			txtLoginOrEmail.TextChanged += signInFields_TextChanged;
			// 
			// txtPassword
			// 
			txtPassword.Dock = DockStyle.Fill;
			txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(3, 32);
			txtPassword.Margin = new Padding(3, 0, 3, 2);
			txtPassword.MaxLength = 32;
			txtPassword.Name = "txtPassword";
			txtPassword.PlaceholderText = "Пароль";
			txtPassword.Size = new Size(236, 29);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			txtPassword.TextChanged += signInFields_TextChanged;
			// 
			// btnSignIn
			// 
			btnSignIn.Dock = DockStyle.Fill;
			btnSignIn.Enabled = false;
			btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnSignIn.Location = new Point(3, 271);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.Size = new Size(236, 34);
			btnSignIn.TabIndex = 2;
			btnSignIn.Text = "Войти";
			btnSignIn.UseVisualStyleBackColor = true;
			btnSignIn.Click += btnSignIn_Click;
			// 
			// lblForgotPassword
			// 
			lblForgotPassword.Dock = DockStyle.Fill;
			lblForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblForgotPassword.Location = new Point(3, 67);
			lblForgotPassword.Margin = new Padding(3);
			lblForgotPassword.Name = "lblForgotPassword";
			lblForgotPassword.Size = new Size(236, 198);
			lblForgotPassword.TabIndex = 5;
			lblForgotPassword.TabStop = true;
			lblForgotPassword.Text = "Забыли пароль?";
			lblForgotPassword.TextAlign = ContentAlignment.TopRight;
			// 
			// tabSignUp
			// 
			tabSignUp.Controls.Add(SignUpTLP);
			tabSignUp.Location = new Point(4, 26);
			tabSignUp.Margin = new Padding(3, 2, 3, 2);
			tabSignUp.Name = "tabSignUp";
			tabSignUp.Padding = new Padding(3, 2, 3, 2);
			tabSignUp.Size = new Size(248, 312);
			tabSignUp.TabIndex = 1;
			tabSignUp.Text = "Регистрация";
			tabSignUp.UseVisualStyleBackColor = true;
			// 
			// SignUpTLP
			// 
			SignUpTLP.ColumnCount = 1;
			SignUpTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			SignUpTLP.Controls.Add(picUser, 0, 0);
			SignUpTLP.Controls.Add(linkLabel1, 0, 1);
			SignUpTLP.Controls.Add(txtLogin, 0, 2);
			SignUpTLP.Controls.Add(txtEmail, 0, 3);
			SignUpTLP.Controls.Add(txtPassword_, 0, 4);
			SignUpTLP.Controls.Add(btnSignUp, 0, 5);
			SignUpTLP.Dock = DockStyle.Fill;
			SignUpTLP.Location = new Point(3, 2);
			SignUpTLP.Name = "SignUpTLP";
			SignUpTLP.RowCount = 6;
			SignUpTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			SignUpTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			SignUpTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			SignUpTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			SignUpTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			SignUpTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			SignUpTLP.Size = new Size(242, 308);
			SignUpTLP.TabIndex = 3;
			// 
			// picUser
			// 
			picUser.BackgroundImageLayout = ImageLayout.Zoom;
			picUser.Dock = DockStyle.Fill;
			picUser.Image = (System.Drawing.Image)resources.GetObject("picUser.Image");
			picUser.Location = new Point(0, 10);
			picUser.Margin = new Padding(0, 10, 0, 0);
			picUser.Name = "picUser";
			picUser.Size = new Size(242, 130);
			picUser.SizeMode = PictureBoxSizeMode.Zoom;
			picUser.TabIndex = 7;
			picUser.TabStop = false;
			picUser.Click += picUser_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.Dock = DockStyle.Fill;
			linkLabel1.Location = new Point(3, 140);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(236, 32);
			linkLabel1.TabIndex = 8;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Изменить изображение";
			linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
			linkLabel1.Click += picUser_Click;
			// 
			// txtLogin
			// 
			txtLogin.Dock = DockStyle.Top;
			txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtLogin.Location = new Point(3, 174);
			txtLogin.Margin = new Padding(3, 2, 3, 8);
			txtLogin.MaxLength = 32;
			txtLogin.Name = "txtLogin";
			txtLogin.PlaceholderText = "Логин";
			txtLogin.Size = new Size(236, 29);
			txtLogin.TabIndex = 6;
			txtLogin.TextChanged += signUpFields_TextChanged;
			// 
			// txtEmail
			// 
			txtEmail.Dock = DockStyle.Top;
			txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmail.Location = new Point(3, 206);
			txtEmail.Margin = new Padding(3, 2, 3, 8);
			txtEmail.MaxLength = 40;
			txtEmail.Name = "txtEmail";
			txtEmail.PlaceholderText = "E-mail";
			txtEmail.Size = new Size(236, 29);
			txtEmail.TabIndex = 0;
			txtEmail.TextChanged += signUpFields_TextChanged;
			// 
			// txtPassword_
			// 
			txtPassword_.Dock = DockStyle.Top;
			txtPassword_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword_.Location = new Point(3, 238);
			txtPassword_.Margin = new Padding(3, 2, 3, 2);
			txtPassword_.MaxLength = 32;
			txtPassword_.Name = "txtPassword_";
			txtPassword_.PlaceholderText = "Пароль";
			txtPassword_.Size = new Size(236, 29);
			txtPassword_.TabIndex = 1;
			txtPassword_.UseSystemPasswordChar = true;
			txtPassword_.TextChanged += signUpFields_TextChanged;
			// 
			// btnSignUp
			// 
			btnSignUp.Dock = DockStyle.Fill;
			btnSignUp.Enabled = false;
			btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnSignUp.Location = new Point(3, 271);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.Size = new Size(236, 34);
			btnSignUp.TabIndex = 3;
			btnSignUp.Text = "Зарегистрироваться";
			btnSignUp.UseVisualStyleBackColor = true;
			btnSignUp.Click += btnSignUp_Click;
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
			LoginTLP.ResumeLayout(false);
			LoginTLP.PerformLayout();
			tabSignUp.ResumeLayout(false);
			SignUpTLP.ResumeLayout(false);
			SignUpTLP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picUser).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tbcAuth;
		private TabPage tabSignIn;
		private TextBox txtPassword;
		private TextBox txtLoginOrEmail;
		private TabPage tabSignUp;
		private TextBox txtPassword_;
		private TextBox txtEmail;
		private TextBox txtLogin;
		private Button btnSignUp;
		private LinkLabel lblForgotPassword;
		private OpenFileDialog dlgLoadProfilePic;
		private Button btnSignIn;
		private TableLayoutPanel LoginTLP;
		private PictureBox picUser;
		private LinkLabel linkLabel1;
		private TableLayoutPanel SignUpTLP;
	}
}

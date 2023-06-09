namespace recipe_book
{
    partial class EditProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnDeleteProfile = new Button();
            picUser = new PictureBox();
            dlgLoadProfilePic = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 0, 2);
            tableLayoutPanel1.Controls.Add(txtLogin, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancel, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 4);
            tableLayoutPanel1.Controls.Add(btnDeleteProfile, 0, 6);
            tableLayoutPanel1.Controls.Add(picUser, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 11, 10, 11);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(355, 457);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            tableLayoutPanel1.SetColumnSpan(txtPassword, 2);
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(13, 326);
            txtPassword.Margin = new Padding(3, 4, 3, 11);
            txtPassword.MaxLength = 32;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(329, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += authFields_TextChanged;
            // 
            // txtEmail
            // 
            tableLayoutPanel1.SetColumnSpan(txtEmail, 2);
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(13, 277);
            txtEmail.Margin = new Padding(3, 4, 3, 11);
            txtEmail.MaxLength = 40;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(329, 34);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += authFields_TextChanged;
            // 
            // txtLogin
            // 
            tableLayoutPanel1.SetColumnSpan(txtLogin, 2);
            txtLogin.Dock = DockStyle.Top;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(13, 228);
            txtLogin.Margin = new Padding(3, 4, 3, 11);
            txtLogin.MaxLength = 32;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Size = new Size(329, 34);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += authFields_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(13, 379);
            btnCancel.Margin = new Padding(3, 8, 3, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(180, 379);
            btnSave.Margin = new Padding(3, 8, 3, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 38);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.AutoSize = true;
            btnDeleteProfile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(btnDeleteProfile, 2);
            btnDeleteProfile.Dock = DockStyle.Top;
            btnDeleteProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteProfile.Location = new Point(10, 425);
            btnDeleteProfile.Margin = new Padding(0);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Size = new Size(335, 38);
            btnDeleteProfile.TabIndex = 9;
            btnDeleteProfile.Text = "Удалить профиль";
            btnDeleteProfile.UseVisualStyleBackColor = true;
            btnDeleteProfile.Click += btnDeleteProfile_Click;
            // 
            // picUser
            // 
            picUser.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.SetColumnSpan(picUser, 2);
            picUser.Image = Properties.Resources.UserIcon;
            picUser.Location = new Point(93, 11);
            picUser.Margin = new Padding(83, 0, 3, 8);
            picUser.Name = "picUser";
            picUser.Size = new Size(168, 205);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 10;
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
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 457);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditProfileForm";
            Text = "Редактирование профиля";
            Load += EditProfileForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDeleteProfile;
        private OpenFileDialog dlgLoadProfilePic;
        private PictureBox picUser;
    }
}
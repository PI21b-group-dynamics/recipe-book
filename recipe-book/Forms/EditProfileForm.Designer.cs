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
            tableLayoutPanel1.Controls.Add(picUser, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 11, 10, 11);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(347, 328);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            tableLayoutPanel1.SetColumnSpan(txtPassword, 2);
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(13, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(321, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += authFields_TextChanged;
            // 
            // txtEmail
            // 
            tableLayoutPanel1.SetColumnSpan(txtEmail, 2);
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(13, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(321, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += authFields_TextChanged;
            // 
            // txtLogin
            // 
            tableLayoutPanel1.SetColumnSpan(txtLogin, 2);
            txtLogin.Dock = DockStyle.Top;
            txtLogin.Location = new Point(13, 150);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Size = new Size(321, 27);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += authFields_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(13, 249);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnSave.Location = new Point(176, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 29);
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
            btnDeleteProfile.Location = new Point(13, 284);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Size = new Size(321, 30);
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
            picUser.Location = new Point(13, 14);
            picUser.Name = "picUser";
            picUser.Size = new Size(128, 128);
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
            ClientSize = new Size(347, 328);
            Controls.Add(tableLayoutPanel1);
            Name = "EditProfileForm";
            Text = "Редактирование профиля";
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
        private PictureBox picUser;
        private OpenFileDialog dlgLoadProfilePic;
    }
}
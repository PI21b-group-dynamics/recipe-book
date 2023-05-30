namespace recipe_book
{
    partial class RegisterForm
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
            LoginInput = new TextBox();
            EmailInput = new TextBox();
            PasswordInput = new TextBox();
            signUpBtn = new Button();
            SuspendLayout();
            // 
            // LoginInput
            // 
            LoginInput.Location = new Point(12, 11);
            LoginInput.Margin = new Padding(3, 2, 3, 2);
            LoginInput.Name = "LoginInput";
            LoginInput.PlaceholderText = "Логин";
            LoginInput.Size = new Size(245, 23);
            LoginInput.TabIndex = 1;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(12, 38);
            EmailInput.Margin = new Padding(3, 2, 3, 2);
            EmailInput.Name = "EmailInput";
            EmailInput.PlaceholderText = "E-mail";
            EmailInput.Size = new Size(245, 23);
            EmailInput.TabIndex = 2;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(12, 65);
            PasswordInput.Margin = new Padding(3, 2, 3, 2);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Пароль";
            PasswordInput.Size = new Size(245, 23);
            PasswordInput.TabIndex = 3;
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(12, 98);
            signUpBtn.Margin = new Padding(3, 2, 3, 2);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(245, 22);
            signUpBtn.TabIndex = 4;
            signUpBtn.Text = "Зарегистрироваться";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 133);
            Controls.Add(signUpBtn);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(LoginInput);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginInput;
        private TextBox EmailInput;
        private TextBox PasswordInput;
        private Button signUpBtn;
    }
}
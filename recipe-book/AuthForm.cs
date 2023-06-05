using System.Data.SQLite;

namespace recipe_book
{
    public sealed partial class AuthForm : Form
    {
        public long Id;
        public string Login { get => txtLogin.Text; }

        public AuthForm()
        {
            InitializeComponent();
            ActiveControl = btnSignIn;
        }

        private void authFields_TextChanged(object sender, EventArgs e)
        {
            btnSignIn.Enabled = (txtLogin.TextLength > 0 || txtEmail.TextLength > 0) && txtPassword.TextLength > 0;
            btnSignUp.Enabled = txtLogin.TextLength > 0 && txtEmail.TextLength > 0 && txtPassword.TextLength > 0;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT id, password FROM Users
                WHERE ($login = '' OR login = $login)
                    AND ($email = '' OR email = $email)
                LIMIT 1;
                """,
                new SQLiteParameter("login", txtLogin.Text),
                new SQLiteParameter("email", txtEmail.Text)
            );
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            string? message = null;
            if (!rdr.Read())
                message = "Пользователь с таким логином или e-mail не найден. Возможно, вы хотели зарегистрироваться?";
            else if (txtPassword.Text != rdr.GetString(1))
                message = "Вы ввели неверный пароль от учётной записи. Возможно, вы хотели войти в другой аккаунт?";
            if (message is null)
            {
                Id = rdr.GetInt64(0);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(
                    caption: "Ошибка входа",
                    text: message,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand("""
                INSERT INTO Users (login, email, password)
                VALUES ($login, $email, $password)
                """,
                new SQLiteParameter("login", txtLogin.Text),
                new SQLiteParameter("email", txtEmail.Text),
                new SQLiteParameter("password", txtPassword.Text)
            );
            try
            {
                cmd.ExecuteNonQuery();
                cmd = DbModule.CreateCommand("SELECT last_insert_rowid();");
                Id = (long)cmd.ExecuteScalar();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SQLiteException ex)
            {
                string message;
                if (ex.ResultCode == SQLiteErrorCode.Constraint)
                    message = "Пользователь с таким логином или e-mail уже зарегистрирован. Возможно, вы хотели войти в учётную запись?";
                else
                    message = ex.Message;
                MessageBox.Show(
                    caption: "Ошибка регистрации",
                    text: message,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }
    }
}

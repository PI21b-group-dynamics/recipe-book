using System.Data.SQLite;

namespace recipe_book
{
    public sealed partial class AuthForm : Form
    {
        public string Login { get => txtLogin.Text; }

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
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
                SELECT login FROM Users
                WHERE ($login = '' OR login = $login)
                    AND ($email = '' OR email = $email)
                    AND password = $password
                LIMIT 1;
                """,
                new SQLiteParameter("login", txtLogin.Text),
                new SQLiteParameter("email", txtEmail.Text),
                new SQLiteParameter("password", txtPassword.Text)
            );
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(
                    caption: "Ошибка входа",
                    text: "Учётная запись с такими данными не найдена.",
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
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(
                    caption: "Ошибка регистрации",
                    text: ex.Message,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
            finally
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

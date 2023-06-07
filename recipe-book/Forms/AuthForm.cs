using recipe_book.Properties;
using System.Data.SQLite;

namespace recipe_book
{
    public sealed partial class AuthForm : Form
    {
        public long Id;
        public string Login
        {
            get => (tbcAuth.SelectedTab == tabSignIn ? txtLoginOrEmail : txtLogin).Text;
        }

        public Image? Photo
        {
            get => picUser.Image == Resources.UserIcon ? null : picUser.Image;
        }

        public AuthForm()
        {
            InitializeComponent();
            ActiveControl = btnSignIn;
            picUser.MakeRound();
        }

        private void signInFields_TextChanged(object sender, EventArgs e)
        {
            btnSignIn.Enabled = txtLoginOrEmail.TextLength > 0
                && txtPassword.TextLength > 0;
        }

        private void signUpFields_TextChanged(object sender, EventArgs e)
        {
            btnSignUp.Enabled = txtLogin.TextLength > 0
                && txtEmail.TextLength > 0
                && txtPassword_.TextLength > 0;
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            if (dlgLoadProfilePic.ShowDialog() == DialogResult.OK)
                try
                {
                    picUser.ImageLocation = dlgLoadProfilePic.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        caption: "Ошибка добавления фотографии",
                        text: ex.Message,
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                    );
                }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand("""
                INSERT INTO Users (login, email, password, photo)
                VALUES ($login, $email, $password, $photo)
                """,
                new SQLiteParameter("login", txtLogin.Text),
                new SQLiteParameter("email", txtEmail.Text),
                new SQLiteParameter("password", txtPassword_.Text),
                new SQLiteParameter("photo",
                    picUser.Image == Resources.UserIcon ? null : picUser.Image.ToBytes()
                )
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


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT id, password, photo FROM Users
                WHERE $loginOrEmail IN (login, email)
                LIMIT 1;
                """,
                new SQLiteParameter("loginOrEmail", txtLoginOrEmail.Text)
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
                picUser.Image = (rdr.GetValue(2) as byte[])?.ToImage();
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
    }
}

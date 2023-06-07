using recipe_book.Properties;
using System.Data.SQLite;

namespace recipe_book
{
    public partial class EditProfileForm : Form
    {
        private long _userId;

        public EditProfileForm(long userId, string login, Image image)
        {
            InitializeComponent();
            _userId = userId;
            txtLogin.Text = login;
            picUser.Image = image;
            picUser.MakeRound();
            ActiveControl = btnCancel;
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT email, password
                FROM Users
                WHERE id = $id
                """,
               new SQLiteParameter("id", _userId)
            );

            SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            txtEmail.Text = rdr.GetString(0);
            txtPassword.Text = rdr.GetString(1);
        }

        private void authFields_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = txtLogin.TextLength > 0 && txtEmail.TextLength > 0 && txtPassword.TextLength > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Здесь можно сделать возврат к изначальным настройкам. Пока что это закрытие окна.
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand($"""
                UPDATE Users
                SET login = $login, email = $email, password = $password, photo = $photo
                WHERE id = $id
                """,
                new SQLiteParameter("login", txtLogin.Text),
                new SQLiteParameter("email", txtEmail.Text),
                new SQLiteParameter("password", txtPassword.Text),
                new SQLiteParameter("photo",
                    picUser.Image == Resources.UserIcon ? null : picUser.Image.ToBytes()
                ),
                new SQLiteParameter("id", _userId)
            );
            cmd.ExecuteNonQuery();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    caption: "Удаление профиля",
                    text: "Вы собираетесь удалить свой профиль из книги. Вместе с ним удалятся все ваши рецепты. Продолжить?",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Error
            ) == DialogResult.No)
                return;

            SQLiteCommand cmd = DbModule.CreateCommand("""
                DELETE FROM Users
                WHERE id = $id
                """,
               new SQLiteParameter("id", _userId)
            );
            cmd.ExecuteNonQuery();

            DialogResult = DialogResult.Abort;
            Close();
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
    }
}

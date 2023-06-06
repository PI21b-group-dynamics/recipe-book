using Microsoft.VisualBasic.ApplicationServices;
using recipe_book.Properties;
using System.Data.SQLite;

namespace recipe_book
{
    public partial class EditProfileForm : Form
    {
        private long _userId;

        public string Login { get => txtLogin.Text; }

        public Image UserImage { get => picUser.Image; }

        public EditProfileForm(long userId)
        {
            InitializeComponent();
            _userId = userId;
            Utils.MakeRound(picUser);
            ActiveControl = btnCancel;
            // Здесь напиши селект для загрузки данных из БД по айдишнику юзера
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
                new SQLiteParameter("photo", UserImage == Resources.UserIcon ? null : UserImage.ToArray()),
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

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT login, email, password, photo
                FROM Users
                WHERE id = $id
                """,
               new SQLiteParameter("id", _userId)
           );

            SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            txtLogin.Text = rdr.GetString(0);
            txtEmail.Text = rdr.GetString(1);
            txtPassword.Text = rdr.GetString(2);
            if (rdr.IsDBNull(3))
                picUser.Image = Resources.UserIcon;
            else picUser.Image = ((byte[])rdr.GetValue(3)).ToImage();
        }
    }
}

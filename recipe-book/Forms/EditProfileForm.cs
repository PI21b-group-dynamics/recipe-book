using System.Data.SQLite;

namespace recipe_book
{
    public partial class EditProfileForm : Form
    {
        private long _userId;

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
            // Код сохранения изменений
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

            Close();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            if (dlgLoadProfilePic.ShowDialog() == DialogResult.OK)
                try
                {
                    picUser.Image = Image.FromFile(dlgLoadProfilePic.FileName);
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

using System.Data.SQLite;
using System.Windows.Forms;


namespace recipe_book
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение всех полей
            if (LoginInput.Text == "" || EmailInput.Text == "" || PasswordInput.Text == "")
            {
                MessageBox.Show("Все текстовые поля должны быть заполнены", "Ошибка при регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Login = LoginInput.Text;
            string Email = EmailInput.Text;
            string Password = PasswordInput.Text;

            using (SQLiteConnection Connection = new SQLiteConnection("Data Source = Database.db"))
            {
                Connection.Open();
                SQLiteCommand Command = new SQLiteCommand();
                Command.Connection = Connection;

                if (CheckSameUsers(Command, Login, Email))
                {
                    MessageBox.Show("Пользователь с таким логином/e-mail уже существует", "Ошибка при регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
                    

                Command.CommandText = $"INSERT INTO USERS (Login, Email, Password) VALUES ('{Login}', '{Email}', '{Password}')";
                Command.ExecuteNonQuery();
                Close();
            }
        }

        private bool CheckSameUsers(SQLiteCommand Command, string Login, string Email)
        {
            bool SameUser = false;
            Command.CommandText = $"SELECT Login FROM USERS WHERE Login = '{Login}' OR Email = '{Email}'";

            using (SQLiteDataReader Reader = Command.ExecuteReader())
            {
                if (Reader.HasRows) SameUser = true;
            }

            return SameUser;
        }
    }
}

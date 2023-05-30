using System.Data.SQLite;

namespace recipe_book
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            DB_Initialization();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (loginInp.Text == "" || passwordInp.Text == "")
            {
                MessageBox.Show("Все текстовые поля должны быть заполнены", "Ошибка при авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string Login = loginInp.Text;
                string Password = passwordInp.Text;

                string SQLExpression = $"SELECT Login FROM USERS WHERE Login = '{Login}' AND Password = '{Password}'";
                using (SQLiteConnection Connection = new SQLiteConnection("Data Source = Database.db"))
                {
                    Connection.Open();

                    SQLiteCommand Command = new SQLiteCommand(SQLExpression, Connection);
                    using (SQLiteDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            Hide();
                            MainForm Main = new MainForm();
                            Main.UserNameChanger(Login);
                            Main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неверно введен логин и/или пароль", "Ошибка при авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            ActiveControl = signInBtn;
        }
        
        private void DB_Initialization()
        {
            // Если файла БД нет, то создаем его и инициализируем БД
            if (!File.Exists("Database.db"))
            {
                using (SQLiteConnection Connection = new SQLiteConnection("Data Source = Database.db"))
                {
                    Connection.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.Connection = Connection;
                    Command.CommandText = "CREATE TABLE USERS (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Login TEXT NOT NULL UNIQUE, " +
                                          "Email TEXT NOT NULL UNIQUE, Password TEXT NOT NULL)";
                    Command.ExecuteNonQuery();
                }
            }
        }
    }
}

namespace recipe_book
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (loginInp.Text == "" && passwordInp.Text == "")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show(
                    caption: "Ошибка авторизации",
                    text: "Введённые вами учётные данные неверны. Попробуйте снова.",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            ActiveControl = signInBtn;
        }
    }
}
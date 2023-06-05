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
            // Здесь напиши селект для загрузки данных из БД по айдишнику юзера
        }
    }
}

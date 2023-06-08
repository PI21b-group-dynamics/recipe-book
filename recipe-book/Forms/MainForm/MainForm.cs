using System.Data.SQLite;
using recipe_book.Properties;

namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private long userId;
        private readonly Color UserLayoutPanelOriginalBackColor;
        private readonly Rectangle SlideMenuHoverZone;
        private readonly TimeSpan _minimumCookingTime;
        private HelpForm? _helpForm;
        private TabPage _previousSelectedTab;

        public MainForm()
        {
            InitializeComponent();
            UserLayoutPanelOriginalBackColor = pnlUser.BackColor;
            SlideMenuHoverZone = new(
                new Point(),
                new Size(
                    pnlUser.Width,
                    pnlUser.Height + pnlSlideMenu.Height
                )
            );
            _minimumCookingTime = new TimeSpan(0, 3, 0);
            _previousSelectedTab = tabRecipeView;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlSlideMenu.BringToFront();
            ActiveControl = btnAddRecipe;
            cboContentSort.Items.AddRange(new[] { "Дате создания", "Дате изменения", "Рейтингу" });
            cboContentSort.SelectedIndex = 0;
            picUser.MakeRound();
            btnAddRecipe.MakeRound();
            picRecipePhoto.Visible = false;

            Authorize();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _helpForm?.Close();
            DbModule.Conn.Dispose();
        }

        private void Authorize()
        {
            AuthForm authForm = new();
            if (authForm.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }
            lblUser.Text = authForm.Login;
            if (authForm.Photo is not null)
                picUser.Image = authForm.Photo;
            userId = authForm.Id;
            DisplayRecipes();
            DisplayTags();
        }

        private void DisplayRecipes()
        {
            pnlRecipes.Clear();
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT id, name, photo FROM Recipes
                WHERE user_id = $user_id
                """,
                new SQLiteParameter("user_id", userId)
            );
            SQLiteDataReader rdr = cmd.ExecuteReader();
            ListViewItem item;
            ImageList imgList = new()
            {
                ImageSize = new Size(256, 256),
                ColorDepth = ColorDepth.Depth32Bit
            };
            int i = 0;
            while (rdr.Read())
            {
                imgList.Images.Add(rdr.GetImage(2) ?? Resources.UserIcon);
                item = new ListViewItem(rdr.GetString(1), i++) { Name = rdr.GetInt64(0).ToString() };
                pnlRecipes.Items.Add(item);
            }
            pnlRecipes.LargeImageList = imgList;
        }

        private void DisplayTags()
        {
            pnlTags.Controls.Clear();
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT * FROM Tags
                JOIN RecipeTags ON tag_id = Tags.id
                JOIN Recipes ON Recipes.id = recipe_id
                JOIN Users ON Users.id = user_id
                WHERE user_id = $user_id
                """,
                new SQLiteParameter("user_id", userId)
            );
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                pnlTags.Controls.Add(new Button()
                {
                    Name = $"tag{rdr.GetInt64(0)}",
                    Text = rdr.GetString(1),
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                });
        }

        private void tbcMainFormTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = tbcMainFormTabs.SelectedTab == tabListOfRecipes;
            if (tbcMainFormTabs.SelectedTab == tabListOfRecipes)
            {
                if (_previousSelectedTab == tabCreateOrEditRecipe)
                {
                    ClearRecipeInputFields();
                    DisplayTags();
                    DisplayRecipes();
                }
            }
        }
    }
}

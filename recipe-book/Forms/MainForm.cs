using System.Data.SQLite;
using recipe_book.Controls;
using recipe_book.Properties;

namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private long userId;
        private readonly Color UserLayoutPanelOriginalBackColor;
        private readonly Rectangle SlideMenuHoverZone;
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
            byte[]? assumingImage;
            while (rdr.Read())
            {
                assumingImage = rdr.GetValue(2) as byte[];
                imgList.Images.Add(assumingImage?.ToImage() ?? Resources.UserIcon);
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

        private void ChangeSlideMenuVisibility(bool visibility)
        {
            pnlUser.BackColor = visibility ? pnlSlideMenu.BackColor : UserLayoutPanelOriginalBackColor;
            pnlSlideMenu.Visible = visibility;
        }

        private void ShowSlideMenuOnMouseEnter(object sender, EventArgs e)
        {
            ChangeSlideMenuVisibility(true);
        }

        private void HideSlideMenuOnMouseLeave(object sender, EventArgs e)
        {
            if (!SlideMenuHoverZone.Contains(PointToClient(Cursor.Position)))
                ChangeSlideMenuVisibility(false);
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EditProfileForm editProfileForm = new(userId, lblUser.Text, picUser.Image);
            switch (editProfileForm.ShowDialog())
            {
                case DialogResult.Abort:
                    Hide();
                    Authorize();
                    break;
                case DialogResult.OK:
                    lblUser.Text = editProfileForm.Login;
                    picUser.Image = editProfileForm.Photo;
                    break;
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            _helpForm = new HelpForm();
            _helpForm.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm_Load(sender, e);
            if (!IsDisposed)
                Show();
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            new ShoppingListForm();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabCreateOrEditRecipe;
            _previousSelectedTab = tabListOfRecipes;
        }

        private void btnCancelCreationOrEdition_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabListOfRecipes;
            _previousSelectedTab = tabCreateOrEditRecipe;
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

        private void btnLoadRecipePhoto_Click(object sender, EventArgs e)
        {
            if (dlgLoadRecipePhoto.ShowDialog() == DialogResult.OK)
                try
                {
                    picRecipePhoto.ImageLocation = dlgLoadRecipePhoto.FileName;
                    picRecipePhoto.Visible = true;
                    btnDeleteRecipePhoto.Enabled = true;
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

        private void btnDeleteRecipePhoto_Click(object sender, EventArgs e)
        {
            picRecipePhoto.Visible = false;
            picRecipePhoto.Image = null;
            btnDeleteRecipePhoto.Enabled = false;
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            string cookingTime = string.Join(' ',
                (numWeeks.Value, numDays.Value, numHours.Value, numMinutes.Value, numSeconds.Value)
            );
            SQLiteCommand cmd = DbModule.CreateCommand("""
                INSERT INTO Recipes (user_id, name, rating, cooking_time, photo, cooking_method)
                VALUES ($user_id, $name, $rating, $cooking_time, $photo, $cooking_method)
                """,
                new SQLiteParameter("user_id", userId),
                new SQLiteParameter("name", txtRecipeName.Text),
                new SQLiteParameter("rating", numRecipeRating.Value),
                new SQLiteParameter("cooking_time", cookingTime),
                new SQLiteParameter("photo", picRecipePhoto.Image?.ToBytes()),
                new SQLiteParameter("cooking_method", txtCookingMethod.Text)
            );
            cmd.ExecuteNonQuery();

            SQLiteCommand cmdGetLastInsertedId = DbModule.CreateCommand("SELECT last_insert_rowid()");

            long recipeId = (long)cmdGetLastInsertedId.ExecuteScalar();

            var autoFillingPanels = new[]
            {
                ("Tags", pnlTagInput),
                ("Ingredients", pnlIngredientInput)
            };
            foreach ((string tableName, AutoFillingFlowPanel panel) in autoFillingPanels)
                foreach (string value in panel.Values)
                {
                    cmd = DbModule.CreateCommand($"""
                        INSERT INTO {tableName} (name)
                        VALUES ($name)
                        """,
                        new SQLiteParameter("name", value)
                    );

                    cmd.ExecuteNonQuery();

                    long lastElementId = (long)cmdGetLastInsertedId.ExecuteScalar();

                    cmd = DbModule.CreateCommand($"""
                        INSERT INTO {"Recipe" + tableName}
                        VALUES ($recipe_id, $element_id)
                        """,
                        new SQLiteParameter("recipe_id", recipeId),
                        new SQLiteParameter("element_id", lastElementId)
                    );
                    cmd.ExecuteNonQuery();
                }
            _previousSelectedTab = tabCreateOrEditRecipe;
            tbcMainFormTabs.SelectedTab = tabListOfRecipes;
        }

        private void ClearRecipeInputFields()
        {
            txtRecipeName.Clear();
            txtCookingMethod.Clear();
            pnlTagInput.Clear();
            pnlIngredientInput.Clear();
            btnDeleteRecipePhoto_Click(new(), new());
            foreach (var numericUpDown in new[] { numHours, numMinutes, numSeconds, numWeeks, numDays, numRecipeRating })
                numericUpDown.Value = numericUpDown.Minimum;
        }

        private void pnlRecipes_DoubleClick(object sender, EventArgs e)
        {
            _previousSelectedTab = tabListOfRecipes;
            tbcMainFormTabs.SelectedTab = tabRecipeView;

            int selectedItemIndex = pnlRecipes.SelectedItems[0].Index;
            lblRecipeName.Text = pnlRecipes.Items[selectedItemIndex].Text;

            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT cooking_time, rating, photo, cooking_method
                FROM Recipes
                WHERE name = $name
                """,
                new SQLiteParameter("name", lblRecipeName.Text)
            );
            SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            byte[]? recipeImage;
            recipeImage = (byte[]?)rdr.GetValue(2);

            lblCookingTime.Text = rdr.GetString(0);
            lblRating.Text = $"{rdr.GetInt32(1)} / 10";
            picRecipePhoto.Image = recipeImage?.ToImage() ?? Resources.UserIcon;
            lblRecipeCookingMethod.Text = rdr.GetString(3);
        }
    }
}

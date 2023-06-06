using System.Data.SQLite;
using recipe_book.Controls;

namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private long userId;
        private readonly Color UserLayoutPanelOriginalBackColor;
        private readonly List<TableLayoutPanel> recipes = new();
        private readonly Rectangle SlideMenuHoverZone;
        private HelpForm? _helpForm;

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

            pnlSlideMenu.BringToFront();
            ActiveControl = btnAddRecipe;
            cboContentSort.Items.AddRange(new[] { "Дате создания", "Дате изменения", "Рейтингу" });
            cboContentSort.SelectedIndex = 0;
            Utils.MakeRound(picUser);
            Utils.MakeRound(btnAddRecipe);
            picRecipePhoto.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AuthForm authForm = new();
            if (authForm.ShowDialog() != DialogResult.OK)
                Close();
            lblUser.Text = authForm.Login;
            userId = authForm.Id;
            DisplayRecipes();
            DisplayTags();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _helpForm?.Close();
            DbModule.Conn.Dispose();
        }

        private void DisplayRecipes()
        {
            int rows = 6;
            int offset = pnlRecipes.Controls.Count;
            for (int i = 0; i < rows * pnlRecipes.ColumnCount; ++i)
            {
                // Позиция рецепта в таблице
                int index = (offset + i);
                int x = index % pnlRecipes.ColumnCount;
                int y = index / pnlRecipes.ColumnCount;

                // Генерация рецепта
                (TableLayoutPanel panel, Label label, Button btn, PictureBox pb) = BuildRecipeControls($"Рецепт {pnlRecipes.Controls.Count + 1}");
                recipes.Add(panel);

                // Добавление рецепта на форму
                pnlRecipes.Controls.Add(panel);
                pnlRecipes.SetColumn(panel, x);
                pnlRecipes.SetRow(panel, y);
            }

            // Установка одинаковой высоты строк
            pnlRecipes.RowStyles.Clear();
            for (int i = 0; i < rows; ++i)
                pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 180));
        }

        private void DisplayTags()
        {
            for (int i = 0; i < 24; ++i)
            {
                Button button = new() { Text = $"Тег {i + 1}", AutoSize = true };
                pnlTags.Controls.Add(button);
            }
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
            new EditProfileForm(userId).ShowDialog();
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
        }

        private void btnCancelCreationOrEdition_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabListOfRecipes;
            ClearRecipeInputFields();
        }

        private void tbcMainFormTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMainFormTabs.SelectedTab == tabListOfRecipes)
            {
                txtSearch.Visible = true;
            }
            else if (tbcMainFormTabs.SelectedTab == tabCreateOrEditRecipe)
            {
                txtSearch.Visible = false;
            }
            else if (tbcMainFormTabs.SelectedTab == tabRecipeView)
            {
                txtSearch.Visible = false;
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
            byte[]? imageData = null;
            if (picRecipePhoto.Image is not null)
            {
                using FileStream fs = new(picRecipePhoto.ImageLocation, FileMode.Open);
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }

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
                new SQLiteParameter("photo", imageData),
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
            {
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
            }
            ClearRecipeInputFields();
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

        public (TableLayoutPanel, Label, Button, PictureBox) BuildRecipeControls(string caption)
        {
            TableLayoutPanel panel = new()
            {
                ColumnCount = 2,
                RowCount = 2,
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                Dock = DockStyle.Fill,
                Margin = new Padding(3)
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            Label label = new()
            {
                Dock = DockStyle.Fill,
                Text = caption,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(label);
            panel.SetColumn(label, 0);
            panel.SetRow(label, 0);
            panel.SetColumnSpan(label, 1);
            panel.SetRowSpan(label, 1);

            Button btn = new()
            {
                Text = "❌",
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };
            panel.Controls.Add(btn);
            panel.SetColumn(btn, 1);
            panel.SetRow(btn, 0);
            panel.SetColumnSpan(btn, 1);
            panel.SetRowSpan(btn, 1);

            PictureBox pb = new()
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };
            panel.Controls.Add(pb);
            panel.SetColumn(pb, 0);
            panel.SetRow(pb, 1);
            panel.SetColumnSpan(pb, 2);
            panel.SetRowSpan(pb, 1);
            panel.Margin = new Padding(12);

            return (panel, label, btn, pb);
        }
    }
}

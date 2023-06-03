namespace recipe_book
{
    public partial class MainForm : Form
    {
        private Color UserLayoutPanelOriginalBackColor;
        private readonly List<TableLayoutPanel> recipes = new();

        public MainForm()
        {
            InitializeComponent();
            UserLayoutPanelOriginalBackColor = pnlUser.BackColor;

            pnlRecipes.AutoScroll = true;
            pnlRecipes.HorizontalScroll.Visible = false;
            pnlRecipes.VerticalScroll.Visible = true;

            // Заполнение таблицы рецептов
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

            for (int i = 0; i < 24; ++i)
            {
                Button button = new() { Text = $"Тег {i + 1}", AutoSize = true };
                pnlTags.Controls.Add(button);
            }

            cboContentSort.Items.AddRange(new string[] { "Дате создания", "Дате изменения", "Рейтингу" });
            cboContentSort.SelectedIndex = 0;

            Utils.MakeRound(picUser);
            Utils.MakeRound(btnAddRecipe);
            ActiveControl = btnAddRecipe;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AuthForm authForm = new();
            if (authForm.ShowDialog() != DialogResult.OK)
                Close();
            lblUser.Text = authForm.Login;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DbModule.Conn.Dispose();
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

        private void ChangeSlideMenuVisibility(bool visibility)
        {
            pnlUser.BackColor = visibility ? pnlSlideMenu.BackColor : UserLayoutPanelOriginalBackColor;
            pnlSlideMenu.Visible = visibility;
        }

        private void pnlUser_MouseEnter(object sender, EventArgs e)
        {
            ChangeSlideMenuVisibility(true);
        }

        private void HideSlideMenuOnMouseLeave(object sender, EventArgs e)
        {
            if (!pnlUser.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                ChangeSlideMenuVisibility(false);
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
    }
}

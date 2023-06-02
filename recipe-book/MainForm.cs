using System.Data.SQLite;
using System.Drawing.Drawing2D;

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

            // Заполнение списка тегов
            for (int i = 0; i < 24; ++i)
            {
                Button button = new() { Text = $"Тег {i + 1}", AutoSize = true };
                pnlTags.Controls.Add(button);
            }

            // Заполнение методов сортировки
            cboContentSort.Items.AddRange(new string[] { "Дате создания", "Дате изменения", "Рейтингу" });
            cboContentSort.SelectedIndex = 0;

            // Скругление краев у изображения пользователя
            using GraphicsPath graphicsPath = new();
            graphicsPath.AddEllipse(0, 0, picUser.Width, picUser.Height);
            picUser.Region = new Region(graphicsPath);
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

        /// <summary>
        /// Генерация рецепта
        /// </summary>
        /// <param name="caption">Заголовок рецепта</param>
        /// <returns></returns>
        /// ToDo: Добавить как параметр изображение рецепта
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
                AutoSize = false,
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

        private void ChangeUserPanelVisibility(bool visibility)
        {
            pnlUser.BackColor = visibility ? pnlSlideMenu.BackColor : UserLayoutPanelOriginalBackColor;
            pnlSlideMenu.Visible = visibility;
        }

        private void pnlUser_MouseEnter(object sender, EventArgs e)
        {
            ChangeUserPanelVisibility(true);
        }

        private void pnlUser_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlUser.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                ChangeUserPanelVisibility(false);
        }

        private void pnlSlideMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlUser.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                ChangeUserPanelVisibility(false);
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlUser.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                ChangeUserPanelVisibility(false);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm_Load(sender, e);
            if (!IsDisposed)
                Show();
        }
    }
}

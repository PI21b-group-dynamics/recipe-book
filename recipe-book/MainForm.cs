using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace recipe_book
{
    public partial class MainForm : Form
    {

        private Color UserLayoutPanelOriginalBackColor;
        private readonly List<TableLayoutPanel> recipes = new();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MainForm()
        {
            InitializeComponent();
            UserLayoutPanelOriginalBackColor = UserLayoutPanel.BackColor;

            ContentRecPanel.AutoScroll = true;
            ContentRecPanel.HorizontalScroll.Visible = false;
            ContentRecPanel.VerticalScroll.Visible = true;

            // Заполнение таблицы рецептов
            int rows = 8;
            int offset = ContentRecPanel.Controls.Count;
            for (int i = 0; i < rows * ContentRecPanel.ColumnCount; i += 1)
            {
                // Позиция рецепта в таблице
                int index = (offset + i);
                int x = index % ContentRecPanel.ColumnCount;
                int y = index / ContentRecPanel.ColumnCount;

                // Генерация рецепта
                (TableLayoutPanel panel, Label label, Button btn, PictureBox pb) = BuildRecipeControls($"Рецепт {ContentRecPanel.Controls.Count + 1}");
                recipes.Add(panel);

                // Добавление рецепта на форму
                ContentRecPanel.Controls.Add(panel);
                ContentRecPanel.SetColumn(panel, x);
                ContentRecPanel.SetRow(panel, y);
            }

            // Установка одинаковой высоты строк
            ContentRecPanel.RowStyles.Clear();
            for (int i = 0; i < rows; i += 1)
                ContentRecPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 180));

            // Заполнение списка тегов
            for (int i = 0; i < 32; i += 1)
            {
                Button button = new() { Text = $"Тег {i + 1}", AutoSize = true };
                ContentTagFlowPanel.Controls.Add(button);
            }

            // Заполнение методов сортировки
            cboContentSort.Items.AddRange(new string[] { "Дате создания", "Дате изменения", "Рейтингу" });
            cboContentSort.Text = "Дате создания";

            // Скругление краев у изображения пользователя, а также кнопки создания рецепта
            picUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picUser.Width, picUser.Height, picUser.Width, picUser.Height));
            btnAddRecipe.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAddRecipe.Width, btnAddRecipe.Height, btnAddRecipe.Width, btnAddRecipe.Height));
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

        /// <summary>
        /// Показывает всплывающую панель
        /// </summary>
        private void ShowUserPanel()
        {
            UserLayoutPanel.BackColor = UserSlideLayoutPanel.BackColor;
            UserSlideLayoutPanel.Visible = true;
        }

        /// <summary>
        /// Скрывает всплывающую панель
        /// </summary>
        private void HideUserPanel()
        {
            UserLayoutPanel.BackColor = UserLayoutPanelOriginalBackColor;
            UserSlideLayoutPanel.Visible = false;
        }

        private void UserLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            ShowUserPanel();
        }

        private void UserLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            if (!UserLayoutPanel.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                HideUserPanel();
        }

        private void UserSlideLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            if (!UserLayoutPanel.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                HideUserPanel();
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (!UserLayoutPanel.ClientRectangle.Contains(PointToClient(Cursor.Position)))
                HideUserPanel();
        }

        private void lblShoppingList_Click(object sender, EventArgs e)
        {

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

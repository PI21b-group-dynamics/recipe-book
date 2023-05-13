using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Recipe_Book
{
	public partial class MainForm : Form
	{
		private Color UserLayoutPanelOriginalBackColor;
		private List<TableLayoutPanel> receipts = new List<TableLayoutPanel>();

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		/// <summary>
		/// Генерация рецепта
		/// </summary>
		/// <param name="caption">Заголовок рецепта</param>
		/// <returns></returns>
		/// ToDo: Добавить как параметр изображение рецепта
		public (TableLayoutPanel, Label, Button, PictureBox) BuildRecipeControls(string caption)
		{
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.ColumnCount = 2;
			panel.RowCount = 2;
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
			panel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			panel.Dock = DockStyle.Fill;

			Label label = new Label();
			label.AutoSize = false;
			label.Dock = DockStyle.Fill;
			label.Text = caption;
			label.TextAlign = ContentAlignment.MiddleCenter;
			panel.Margin = new Padding(3);
			panel.Controls.Add(label);
			panel.SetColumn(label, 0);
			panel.SetRow(label, 0);
			panel.SetColumnSpan(label, 1);
			panel.SetRowSpan(label, 1);

			Button btn = new Button();
			btn.Text = "≡";
			btn.Dock = DockStyle.Fill;
			btn.Margin = new Padding(0);
			panel.Controls.Add(btn);
			panel.SetColumn(btn, 1);
			panel.SetRow(btn, 0);
			panel.SetColumnSpan(btn, 1);
			panel.SetRowSpan(btn, 1);

			PictureBox pb = new PictureBox();
			pb.Dock = DockStyle.Fill;
			pb.Margin = new Padding(0);
			panel.Controls.Add(pb);
			panel.SetColumn(pb, 0);
			panel.SetRow(pb, 1);
			panel.SetColumnSpan(pb, 2);
			panel.SetRowSpan(pb, 1);
			panel.Margin = new Padding(12);

			return (panel, label, btn, pb);
		}

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
				receipts.Add(panel);

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
				Button button = new Button();
				button.Text = $"Тег {i + 1}";
				ContentTagFlowPanel.Controls.Add(button);
			}

			// Заполнение методов сортировки
			ContentSortComboBox.Items.AddRange(new string[] { "Дате создания", "Дате изменения", "Рейтингу" });
			ContentSortComboBox.Text = "Дате создания";

			// Скругление краев у изображения пользователя, а также кнопки создания рецепта
			UserPictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UserPictureBox.Width, UserPictureBox.Height, UserPictureBox.Width, UserPictureBox.Height));
			AddRecipeButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AddRecipeButton.Width, AddRecipeButton.Height, AddRecipeButton.Width, AddRecipeButton.Height));
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
	}
}
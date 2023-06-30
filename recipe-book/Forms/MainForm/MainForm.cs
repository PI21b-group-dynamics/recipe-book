using System.Data.SQLite;
using System.Linq;
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

			btnAddRecipe.BackColor = Color.LightGray;
			btnAddRecipe.FlatStyle = FlatStyle.Flat;
			btnAddRecipe.FlatAppearance.BorderSize = 0;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			pnlSlideMenu.BringToFront();
			ActiveControl = btnAddRecipe;
			cboContentSort.Items.AddRange(new[] { "Дате создания", "Времени готовки", "Рейтингу" });
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
			DisplayRecipes("");
			DisplayTags();
		}

		private void DisplayRecipes(string recipeName)
		{
			pnlRecipes.Clear();
			string[] parametersName = new string[] { "creation_time", "cooking_time", "rating" };

			SQLiteCommand cmd_1 = DbModule.CreateCommand(
				$"""
					SELECT Recipes.id, Tags.name
					FROM Recipes
					JOIN RecipeTags ON RecipeTags.recipe_id = Recipes.id
					JOIN Tags ON Tags.id = RecipeTags.tag_id
					WHERE Recipes.user_id = $user_id AND Recipes.name LIKE '{recipeName}%'
					ORDER BY Recipes.id, $parameter_name
				""",
				new SQLiteParameter("user_id", userId),
				new SQLiteParameter("parameter_name", parametersName[cboContentSort.SelectedIndex])
			);
			ListViewItem item;
			ImageList imgList = new()
			{
				ImageSize = new Size(256, 256),
				ColorDepth = ColorDepth.Depth32Bit
			};

			var recipe_tags = new Dictionary<int, List<string>>();
			var active_tags = new List<string>();

			foreach (Control control in pnlTags.Controls)
			{
				if (control.BackColor == Color.LightBlue)
					active_tags.Add(control.Text);
			}

			int last_id = -1;
			int i = 0;
			using (SQLiteDataReader rdr = cmd_1.ExecuteReader())
			{
				while (rdr.Read())
				{
					var id = rdr.GetInt32(0);

					if (recipe_tags.ContainsKey(id))
						recipe_tags[id].Add(rdr.GetString(1));
					else
						recipe_tags.Add(id, new List<string>() { rdr.GetString(1) });
				}
			}

			SQLiteCommand cmd_2 = DbModule.CreateCommand(
				$"""
					SELECT Recipes.id, Recipes.name, Recipes.photo
					FROM Recipes
					WHERE Recipes.user_id = $user_id AND Recipes.name LIKE '{recipeName}%'
					ORDER BY Recipes.id, $parameter_name
				""",
				new SQLiteParameter("user_id", userId),
				new SQLiteParameter("parameter_name", parametersName[cboContentSort.SelectedIndex])
			);
			using (SQLiteDataReader rdr = cmd_2.ExecuteReader())
			{
				while (rdr.Read())
				{
					var id = rdr.GetInt32(0);
					var skip = false;
					foreach (var tag in active_tags)
					{
						if (recipe_tags.ContainsKey(id) && recipe_tags[id].Contains(tag) == false)
						{
							skip = true;
							break;
						}
					}

					if (!skip)
					{
						imgList.Images.Add(rdr.GetImage(2) ?? Resources.UserIcon);
						item = new ListViewItem(rdr.GetString(1), i++) { Name = rdr.GetInt64(0).ToString() };
						pnlRecipes.Items.Add(item);
					}
				}
			}

			pnlRecipes.LargeImageList = imgList;
		}


		private void DisplayTags()
		{
			pnlTags.Controls.Clear();
			SQLiteCommand cmd = DbModule.CreateCommand(
				"""
					SELECT Tags.id, Tags.name
					FROM Recipes
					JOIN RecipeTags ON RecipeTags.recipe_id = Recipes.id
					JOIN Tags ON Tags.id = RecipeTags.tag_id
					WHERE Recipes.user_id = $user_id
				""",
				new SQLiteParameter("user_id", userId)
			);
			SQLiteDataReader rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				var btn = new Button()
				{
					Name = $"tag{rdr.GetInt64(0)}",
					Text = rdr.GetString(1),
					AutoSize = true,
					AutoSizeMode = AutoSizeMode.GrowAndShrink
				};

				var base_color = btn.BackColor;
				var changed_color = Color.LightBlue;
				btn.Click += new EventHandler((_, _) =>
				{
					btn.BackColor = (btn.BackColor == base_color
									? changed_color : base_color);
					DisplayRecipes("");
				});

				pnlTags.Controls.Add(btn);
			}
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
					DisplayRecipes("");
				}
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			DisplayRecipes(txtSearch.Text);
		}

		private void cboContentSort_SelectedValueChanged(object sender, EventArgs e)
		{
			DisplayRecipes(txtSearch.Text);
		}

		private void btnDeleteRecipe_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления",
				MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				SQLiteCommand cmd = DbModule.CreateCommand(
					"""
					DELETE FROM Recipes
					WHERE Recipes.id = $recipe_id
					""",
					new SQLiteParameter("recipe_id", recipe_active_index)
				);
				cmd.ExecuteNonQuery();

				tbcMainFormTabs.SelectTab(0);
				DisplayRecipes("");
				DisplayTags();
			}
		}
	}
}

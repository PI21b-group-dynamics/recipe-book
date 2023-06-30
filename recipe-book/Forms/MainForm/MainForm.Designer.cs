using recipe_book.Controls;

namespace recipe_book
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			pnlSlideMenu = new TableLayoutPanel();
			lblEditProfile = new Label();
			lblHelp = new Label();
			lblExit = new Label();
			pnlMainLayout = new TableLayoutPanel();
			txtSearch = new TextBox();
			pnlUser = new TableLayoutPanel();
			lblUser = new Label();
			picUser = new PictureBox();
			tbcMainFormTabs = new TablessControl();
			tabListOfRecipes = new TabPage();
			btnAddRecipe = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			cboContentSort = new ComboBox();
			lblSortBy = new Label();
			pnlTags = new FlowLayoutPanel();
			btnShoppingList = new Button();
			pnlRecipes = new ListView();
			tabRecipeView = new TabPage();
			tableLayoutPanel4 = new TableLayoutPanel();
			lblRating = new Label();
			lbl_3 = new Label();
			lblCookingTime = new Label();
			lbl_2 = new Label();
			lblRecipeName = new Label();
			lbl_1 = new Label();
			picRecipeViewPhoto = new PictureBox();
			spoilerContainer3 = new SpoilerContainer();
			pnlRecipeViewTags = new FlowLayoutPanel();
			spoilerContainer2 = new SpoilerContainer();
			pnlRecipeViewIngredients = new FlowLayoutPanel();
			spoilerContainer1 = new SpoilerContainer();
			lblRecipeCookingMethod = new Label();
			btnBackToMain = new Button();
			btnEditRecipe = new Button();
			btnDeleteRecipe = new Button();
			tabCreateOrEditRecipe = new TabPage();
			tableLayoutPanel5 = new TableLayoutPanel();
			txtCookingMethod = new TextBox();
			label6 = new Label();
			numRecipeRating = new NumericUpDown();
			label5 = new Label();
			label4 = new Label();
			pnlIngredientInput = new AutoFillingFlowPanel();
			pnlTagInput = new AutoFillingFlowPanel();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			label7 = new Label();
			txtRecipeName = new TextBox();
			tableLayoutPanel6 = new TableLayoutPanel();
			picRecipePhoto = new PictureBox();
			btnDeleteRecipePhoto = new Button();
			btnLoadRecipePhoto = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			numWeeks = new NumericUpDown();
			labelWeeks = new Label();
			numDays = new NumericUpDown();
			labelDays = new Label();
			numHours = new NumericUpDown();
			labelSeparator_1 = new Label();
			numMinutes = new NumericUpDown();
			labelSeparator_2 = new Label();
			numSeconds = new NumericUpDown();
			flowLayoutPanel2 = new FlowLayoutPanel();
			btnCancelCreationOrEdition = new Button();
			btnSaveRecipe = new Button();
			dlgLoadRecipePhoto = new OpenFileDialog();
			pnlSlideMenu.SuspendLayout();
			pnlMainLayout.SuspendLayout();
			pnlUser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
			tbcMainFormTabs.SuspendLayout();
			tabListOfRecipes.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tabRecipeView.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picRecipeViewPhoto).BeginInit();
			spoilerContainer3.SuspendLayout();
			spoilerContainer2.SuspendLayout();
			spoilerContainer1.SuspendLayout();
			tabCreateOrEditRecipe.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numRecipeRating).BeginInit();
			tableLayoutPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picRecipePhoto).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numWeeks).BeginInit();
			((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
			((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
			((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
			((System.ComponentModel.ISupportInitialize)numSeconds).BeginInit();
			flowLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// pnlSlideMenu
			// 
			pnlSlideMenu.BackColor = SystemColors.ControlDark;
			pnlSlideMenu.ColumnCount = 1;
			pnlSlideMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			pnlSlideMenu.Controls.Add(lblEditProfile, 0, 0);
			pnlSlideMenu.Controls.Add(lblHelp, 0, 1);
			pnlSlideMenu.Controls.Add(lblExit, 0, 2);
			pnlSlideMenu.Location = new Point(0, 56);
			pnlSlideMenu.Margin = new Padding(0);
			pnlSlideMenu.Name = "pnlSlideMenu";
			pnlSlideMenu.Padding = new Padding(46, 0, 0, 0);
			pnlSlideMenu.RowCount = 3;
			pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
			pnlSlideMenu.Size = new Size(245, 102);
			pnlSlideMenu.TabIndex = 7;
			pnlSlideMenu.Visible = false;
			pnlSlideMenu.MouseLeave += HideSlideMenuOnMouseLeave;
			// 
			// lblEditProfile
			// 
			lblEditProfile.AutoEllipsis = true;
			lblEditProfile.Cursor = Cursors.Hand;
			lblEditProfile.Dock = DockStyle.Fill;
			lblEditProfile.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblEditProfile.Location = new Point(53, 6);
			lblEditProfile.Margin = new Padding(7, 6, 7, 3);
			lblEditProfile.Name = "lblEditProfile";
			lblEditProfile.Size = new Size(185, 24);
			lblEditProfile.TabIndex = 4;
			lblEditProfile.Text = "Редактировать профиль";
			lblEditProfile.Click += lblEditProfile_Click;
			// 
			// lblHelp
			// 
			lblHelp.Cursor = Cursors.Hand;
			lblHelp.Dock = DockStyle.Fill;
			lblHelp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblHelp.Location = new Point(53, 39);
			lblHelp.Margin = new Padding(7, 6, 7, 3);
			lblHelp.Name = "lblHelp";
			lblHelp.Size = new Size(185, 24);
			lblHelp.TabIndex = 5;
			lblHelp.Text = "Справка";
			lblHelp.Click += lblHelp_Click;
			// 
			// lblExit
			// 
			lblExit.Cursor = Cursors.Hand;
			lblExit.Dock = DockStyle.Fill;
			lblExit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblExit.Location = new Point(53, 72);
			lblExit.Margin = new Padding(7, 6, 9, 3);
			lblExit.Name = "lblExit";
			lblExit.Size = new Size(183, 27);
			lblExit.TabIndex = 6;
			lblExit.Text = "Выйти";
			lblExit.Click += lblExit_Click;
			// 
			// pnlMainLayout
			// 
			pnlMainLayout.ColumnCount = 2;
			pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 245F));
			pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			pnlMainLayout.Controls.Add(txtSearch, 1, 0);
			pnlMainLayout.Controls.Add(pnlUser, 0, 0);
			pnlMainLayout.Controls.Add(tbcMainFormTabs, 0, 1);
			pnlMainLayout.Dock = DockStyle.Fill;
			pnlMainLayout.Location = new Point(0, 0);
			pnlMainLayout.Margin = new Padding(0);
			pnlMainLayout.Name = "pnlMainLayout";
			pnlMainLayout.RowCount = 2;
			pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
			pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			pnlMainLayout.Size = new Size(634, 698);
			pnlMainLayout.TabIndex = 8;
			// 
			// txtSearch
			// 
			txtSearch.Dock = DockStyle.Right;
			txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtSearch.Location = new Point(461, 17);
			txtSearch.Margin = new Padding(3, 17, 12, 18);
			txtSearch.Name = "txtSearch";
			txtSearch.PlaceholderText = "Найти...";
			txtSearch.Size = new Size(161, 29);
			txtSearch.TabIndex = 1;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// pnlUser
			// 
			pnlUser.AutoSize = true;
			pnlUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnlUser.ColumnCount = 2;
			pnlUser.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
			pnlUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			pnlUser.Controls.Add(lblUser, 1, 0);
			pnlUser.Controls.Add(picUser, 0, 0);
			pnlUser.Dock = DockStyle.Fill;
			pnlUser.Location = new Point(0, 0);
			pnlUser.Margin = new Padding(0);
			pnlUser.Name = "pnlUser";
			pnlUser.RowCount = 1;
			pnlUser.RowStyles.Add(new RowStyle());
			pnlUser.Size = new Size(245, 64);
			pnlUser.TabIndex = 3;
			// 
			// lblUser
			// 
			lblUser.Dock = DockStyle.Fill;
			lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			lblUser.Location = new Point(68, 0);
			lblUser.Margin = new Padding(4, 0, 0, 0);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(177, 68);
			lblUser.TabIndex = 0;
			lblUser.Text = "Пользователь";
			lblUser.TextAlign = ContentAlignment.MiddleLeft;
			lblUser.MouseEnter += ShowSlideMenuOnMouseEnter;
			lblUser.MouseLeave += HideSlideMenuOnMouseLeave;
			// 
			// picUser
			// 
			picUser.Dock = DockStyle.Fill;
			picUser.Image = Properties.Resources.UserIcon;
			picUser.InitialImage = (Image)resources.GetObject("picUser.InitialImage");
			picUser.Location = new Point(12, 12);
			picUser.Margin = new Padding(12);
			picUser.Name = "picUser";
			picUser.Size = new Size(40, 44);
			picUser.SizeMode = PictureBoxSizeMode.Zoom;
			picUser.TabIndex = 1;
			picUser.TabStop = false;
			picUser.MouseEnter += ShowSlideMenuOnMouseEnter;
			picUser.MouseLeave += HideSlideMenuOnMouseLeave;
			// 
			// tbcMainFormTabs
			// 
			pnlMainLayout.SetColumnSpan(tbcMainFormTabs, 2);
			tbcMainFormTabs.Controls.Add(tabListOfRecipes);
			tbcMainFormTabs.Controls.Add(tabRecipeView);
			tbcMainFormTabs.Controls.Add(tabCreateOrEditRecipe);
			tbcMainFormTabs.Dock = DockStyle.Fill;
			tbcMainFormTabs.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			tbcMainFormTabs.Location = new Point(3, 66);
			tbcMainFormTabs.Margin = new Padding(3, 2, 3, 2);
			tbcMainFormTabs.Name = "tbcMainFormTabs";
			tbcMainFormTabs.SelectedIndex = 0;
			tbcMainFormTabs.Size = new Size(628, 630);
			tbcMainFormTabs.TabIndex = 5;
			tbcMainFormTabs.SelectedIndexChanged += tbcMainFormTabs_SelectedIndexChanged;
			// 
			// tabListOfRecipes
			// 
			tabListOfRecipes.Controls.Add(btnAddRecipe);
			tabListOfRecipes.Controls.Add(tableLayoutPanel1);
			tabListOfRecipes.Location = new Point(4, 29);
			tabListOfRecipes.Margin = new Padding(3, 2, 3, 2);
			tabListOfRecipes.Name = "tabListOfRecipes";
			tabListOfRecipes.Padding = new Padding(3, 2, 3, 2);
			tabListOfRecipes.Size = new Size(620, 597);
			tabListOfRecipes.TabIndex = 0;
			tabListOfRecipes.Text = "Список";
			tabListOfRecipes.UseVisualStyleBackColor = true;
			// 
			// btnAddRecipe
			// 
			btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAddRecipe.Cursor = Cursors.Hand;
			btnAddRecipe.Location = new Point(575, 557);
			btnAddRecipe.Margin = new Padding(3, 2, 3, 2);
			btnAddRecipe.Name = "btnAddRecipe";
			btnAddRecipe.Size = new Size(32, 32);
			btnAddRecipe.TabIndex = 9;
			btnAddRecipe.Text = "+";
			btnAddRecipe.UseVisualStyleBackColor = true;
			btnAddRecipe.Click += btnAddRecipe_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			tableLayoutPanel1.Controls.Add(cboContentSort, 2, 1);
			tableLayoutPanel1.Controls.Add(lblSortBy, 1, 1);
			tableLayoutPanel1.Controls.Add(pnlTags, 0, 0);
			tableLayoutPanel1.Controls.Add(btnShoppingList, 0, 1);
			tableLayoutPanel1.Controls.Add(pnlRecipes, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 2);
			tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(614, 593);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// cboContentSort
			// 
			cboContentSort.Dock = DockStyle.Fill;
			cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
			cboContentSort.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			cboContentSort.FormattingEnabled = true;
			cboContentSort.Location = new Point(467, 3);
			cboContentSort.Margin = new Padding(3, 3, 3, 2);
			cboContentSort.Name = "cboContentSort";
			cboContentSort.Size = new Size(144, 28);
			cboContentSort.TabIndex = 9;
			// 
			// lblSortBy
			// 
			lblSortBy.AutoSize = true;
			lblSortBy.Dock = DockStyle.Fill;
			lblSortBy.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblSortBy.Location = new Point(253, 0);
			lblSortBy.Name = "lblSortBy";
			lblSortBy.Size = new Size(208, 34);
			lblSortBy.TabIndex = 10;
			lblSortBy.Text = "Сортировать по:";
			lblSortBy.TextAlign = ContentAlignment.MiddleRight;
			// 
			// pnlTags
			// 
			pnlTags.AutoScroll = true;
			pnlTags.AutoSize = true;
			pnlTags.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.SetColumnSpan(pnlTags, 3);
			pnlTags.Dock = DockStyle.Fill;
			pnlTags.Location = new Point(0, 0);
			pnlTags.Margin = new Padding(0);
			pnlTags.Name = "pnlTags";
			pnlTags.Size = new Size(614, 1);
			pnlTags.TabIndex = 4;
			pnlTags.WrapContents = false;
			// 
			// btnShoppingList
			// 
			btnShoppingList.AutoSize = true;
			btnShoppingList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnShoppingList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			btnShoppingList.Location = new Point(3, 2);
			btnShoppingList.Margin = new Padding(3, 2, 3, 2);
			btnShoppingList.Name = "btnShoppingList";
			btnShoppingList.Size = new Size(237, 30);
			btnShoppingList.TabIndex = 11;
			btnShoppingList.Text = "Сформировать список покупок";
			btnShoppingList.UseVisualStyleBackColor = true;
			btnShoppingList.Click += btnShoppingList_Click;
			// 
			// pnlRecipes
			// 
			tableLayoutPanel1.SetColumnSpan(pnlRecipes, 3);
			pnlRecipes.Dock = DockStyle.Fill;
			pnlRecipes.Location = new Point(3, 36);
			pnlRecipes.Margin = new Padding(3, 2, 3, 2);
			pnlRecipes.Name = "pnlRecipes";
			pnlRecipes.Size = new Size(608, 555);
			pnlRecipes.TabIndex = 12;
			pnlRecipes.UseCompatibleStateImageBehavior = false;
			pnlRecipes.DoubleClick += pnlRecipes_DoubleClick;
			// 
			// tabRecipeView
			// 
			tabRecipeView.Controls.Add(tableLayoutPanel4);
			tabRecipeView.Location = new Point(4, 29);
			tabRecipeView.Margin = new Padding(3, 2, 3, 2);
			tabRecipeView.Name = "tabRecipeView";
			tabRecipeView.Padding = new Padding(3, 2, 3, 2);
			tabRecipeView.Size = new Size(620, 597);
			tabRecipeView.TabIndex = 1;
			tabRecipeView.Text = "Просмотр";
			tabRecipeView.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.AutoSize = true;
			tableLayoutPanel4.ColumnCount = 4;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel4.Controls.Add(lblRating, 1, 2);
			tableLayoutPanel4.Controls.Add(lbl_3, 0, 2);
			tableLayoutPanel4.Controls.Add(lblCookingTime, 1, 1);
			tableLayoutPanel4.Controls.Add(lbl_2, 0, 1);
			tableLayoutPanel4.Controls.Add(lblRecipeName, 1, 0);
			tableLayoutPanel4.Controls.Add(lbl_1, 0, 0);
			tableLayoutPanel4.Controls.Add(picRecipeViewPhoto, 1, 0);
			tableLayoutPanel4.Controls.Add(spoilerContainer3, 0, 3);
			tableLayoutPanel4.Controls.Add(spoilerContainer2, 0, 4);
			tableLayoutPanel4.Controls.Add(spoilerContainer1, 0, 5);
			tableLayoutPanel4.Controls.Add(btnBackToMain, 0, 6);
			tableLayoutPanel4.Controls.Add(btnEditRecipe, 3, 6);
			tableLayoutPanel4.Controls.Add(btnDeleteRecipe, 2, 6);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 2);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 7;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 28.26369F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1269169F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 53.60939F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel4.Size = new Size(614, 593);
			tableLayoutPanel4.TabIndex = 18;
			// 
			// lblRating
			// 
			lblRating.AutoSize = true;
			lblRating.Dock = DockStyle.Fill;
			lblRating.Location = new Point(153, 118);
			lblRating.Margin = new Padding(0);
			lblRating.Name = "lblRating";
			lblRating.Size = new Size(153, 137);
			lblRating.TabIndex = 5;
			lblRating.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_3
			// 
			lbl_3.Dock = DockStyle.Fill;
			lbl_3.Location = new Point(0, 118);
			lbl_3.Margin = new Padding(0);
			lbl_3.Name = "lbl_3";
			lbl_3.Size = new Size(153, 137);
			lbl_3.TabIndex = 2;
			lbl_3.Text = "Рейтинг блюда:";
			lbl_3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblCookingTime
			// 
			lblCookingTime.AutoSize = true;
			lblCookingTime.Dock = DockStyle.Fill;
			lblCookingTime.Location = new Point(153, 72);
			lblCookingTime.Margin = new Padding(0);
			lblCookingTime.Name = "lblCookingTime";
			lblCookingTime.Size = new Size(153, 46);
			lblCookingTime.TabIndex = 4;
			lblCookingTime.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_2
			// 
			lbl_2.Dock = DockStyle.Fill;
			lbl_2.Location = new Point(0, 72);
			lbl_2.Margin = new Padding(0);
			lbl_2.Name = "lbl_2";
			lbl_2.Size = new Size(153, 46);
			lbl_2.TabIndex = 1;
			lbl_2.Text = "Время готовки: ";
			lbl_2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblRecipeName
			// 
			lblRecipeName.AutoSize = true;
			lblRecipeName.Dock = DockStyle.Fill;
			lblRecipeName.Location = new Point(153, 0);
			lblRecipeName.Margin = new Padding(0);
			lblRecipeName.Name = "lblRecipeName";
			lblRecipeName.Size = new Size(153, 72);
			lblRecipeName.TabIndex = 3;
			lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_1
			// 
			lbl_1.Dock = DockStyle.Fill;
			lbl_1.Location = new Point(0, 0);
			lbl_1.Margin = new Padding(0);
			lbl_1.Name = "lbl_1";
			lbl_1.Size = new Size(153, 72);
			lbl_1.TabIndex = 0;
			lbl_1.Text = "Название блюда:";
			lbl_1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// picRecipeViewPhoto
			// 
			tableLayoutPanel4.SetColumnSpan(picRecipeViewPhoto, 2);
			picRecipeViewPhoto.Dock = DockStyle.Fill;
			picRecipeViewPhoto.Location = new Point(306, 0);
			picRecipeViewPhoto.Margin = new Padding(0);
			picRecipeViewPhoto.Name = "picRecipeViewPhoto";
			tableLayoutPanel4.SetRowSpan(picRecipeViewPhoto, 3);
			picRecipeViewPhoto.Size = new Size(308, 255);
			picRecipeViewPhoto.SizeMode = PictureBoxSizeMode.Zoom;
			picRecipeViewPhoto.TabIndex = 19;
			picRecipeViewPhoto.TabStop = false;
			// 
			// spoilerContainer3
			// 
			spoilerContainer3.AutoSize = true;
			spoilerContainer3.ColumnCount = 1;
			tableLayoutPanel4.SetColumnSpan(spoilerContainer3, 4);
			spoilerContainer3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			spoilerContainer3.Controls.Add(pnlRecipeViewTags, 0, 1);
			spoilerContainer3.Dock = DockStyle.Fill;
			spoilerContainer3.Location = new Point(0, 255);
			spoilerContainer3.Margin = new Padding(0);
			spoilerContainer3.Name = "spoilerContainer3";
			spoilerContainer3.RowCount = 2;
			spoilerContainer3.RowStyles.Add(new RowStyle());
			spoilerContainer3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			spoilerContainer3.Size = new Size(614, 76);
			spoilerContainer3.TabIndex = 17;
			spoilerContainer3.Title = "Теги";
			// 
			// pnlRecipeViewTags
			// 
			pnlRecipeViewTags.Dock = DockStyle.Fill;
			pnlRecipeViewTags.Location = new Point(3, 39);
			pnlRecipeViewTags.Name = "pnlRecipeViewTags";
			pnlRecipeViewTags.Size = new Size(608, 34);
			pnlRecipeViewTags.TabIndex = 14;
			// 
			// spoilerContainer2
			// 
			spoilerContainer2.AutoSize = true;
			spoilerContainer2.ColumnCount = 1;
			tableLayoutPanel4.SetColumnSpan(spoilerContainer2, 4);
			spoilerContainer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			spoilerContainer2.Controls.Add(pnlRecipeViewIngredients, 0, 1);
			spoilerContainer2.Dock = DockStyle.Fill;
			spoilerContainer2.Location = new Point(0, 331);
			spoilerContainer2.Margin = new Padding(0);
			spoilerContainer2.Name = "spoilerContainer2";
			spoilerContainer2.RowCount = 2;
			spoilerContainer2.RowStyles.Add(new RowStyle());
			spoilerContainer2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			spoilerContainer2.Size = new Size(614, 108);
			spoilerContainer2.TabIndex = 16;
			spoilerContainer2.Title = "Ингредиенты";
			// 
			// pnlRecipeViewIngredients
			// 
			pnlRecipeViewIngredients.Dock = DockStyle.Fill;
			pnlRecipeViewIngredients.Location = new Point(3, 39);
			pnlRecipeViewIngredients.Name = "pnlRecipeViewIngredients";
			pnlRecipeViewIngredients.Size = new Size(608, 66);
			pnlRecipeViewIngredients.TabIndex = 13;
			// 
			// spoilerContainer1
			// 
			spoilerContainer1.AutoSize = true;
			spoilerContainer1.ColumnCount = 1;
			tableLayoutPanel4.SetColumnSpan(spoilerContainer1, 4);
			spoilerContainer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			spoilerContainer1.Controls.Add(lblRecipeCookingMethod, 0, 1);
			spoilerContainer1.Dock = DockStyle.Fill;
			spoilerContainer1.Location = new Point(0, 439);
			spoilerContainer1.Margin = new Padding(0);
			spoilerContainer1.Name = "spoilerContainer1";
			spoilerContainer1.RowCount = 2;
			spoilerContainer1.RowStyles.Add(new RowStyle());
			spoilerContainer1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			spoilerContainer1.Size = new Size(614, 120);
			spoilerContainer1.TabIndex = 15;
			spoilerContainer1.Title = "Способ приготовления";
			// 
			// lblRecipeCookingMethod
			// 
			lblRecipeCookingMethod.Dock = DockStyle.Fill;
			lblRecipeCookingMethod.Location = new Point(3, 36);
			lblRecipeCookingMethod.Name = "lblRecipeCookingMethod";
			lblRecipeCookingMethod.Size = new Size(608, 84);
			lblRecipeCookingMethod.TabIndex = 9;
			// 
			// btnBackToMain
			// 
			btnBackToMain.Dock = DockStyle.Fill;
			btnBackToMain.Location = new Point(3, 561);
			btnBackToMain.Margin = new Padding(3, 2, 3, 2);
			btnBackToMain.Name = "btnBackToMain";
			btnBackToMain.Size = new Size(147, 30);
			btnBackToMain.TabIndex = 10;
			btnBackToMain.Text = "Назад";
			btnBackToMain.UseVisualStyleBackColor = true;
			btnBackToMain.Click += btnBackToMain_Click;
			// 
			// btnEditRecipe
			// 
			btnEditRecipe.Dock = DockStyle.Fill;
			btnEditRecipe.Location = new Point(462, 562);
			btnEditRecipe.Name = "btnEditRecipe";
			btnEditRecipe.Size = new Size(149, 28);
			btnEditRecipe.TabIndex = 12;
			btnEditRecipe.Text = "Редактировать";
			btnEditRecipe.UseVisualStyleBackColor = true;
			btnEditRecipe.Click += btnEditRecipe_Click;
			// 
			// btnDeleteRecipe
			// 
			btnDeleteRecipe.Dock = DockStyle.Fill;
			btnDeleteRecipe.Location = new Point(309, 561);
			btnDeleteRecipe.Margin = new Padding(3, 2, 3, 2);
			btnDeleteRecipe.Name = "btnDeleteRecipe";
			btnDeleteRecipe.Size = new Size(147, 30);
			btnDeleteRecipe.TabIndex = 11;
			btnDeleteRecipe.Text = "Удалить";
			btnDeleteRecipe.UseVisualStyleBackColor = true;
			btnDeleteRecipe.Click += btnDeleteRecipe_Click;
			// 
			// tabCreateOrEditRecipe
			// 
			tabCreateOrEditRecipe.Controls.Add(tableLayoutPanel5);
			tabCreateOrEditRecipe.Location = new Point(4, 29);
			tabCreateOrEditRecipe.Margin = new Padding(3, 2, 3, 2);
			tabCreateOrEditRecipe.Name = "tabCreateOrEditRecipe";
			tabCreateOrEditRecipe.Size = new Size(192, 67);
			tabCreateOrEditRecipe.TabIndex = 2;
			tabCreateOrEditRecipe.Text = "Создание и редактирование";
			tabCreateOrEditRecipe.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			tableLayoutPanel5.ColumnCount = 2;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel5.Controls.Add(txtCookingMethod, 1, 6);
			tableLayoutPanel5.Controls.Add(label6, 0, 5);
			tableLayoutPanel5.Controls.Add(numRecipeRating, 1, 3);
			tableLayoutPanel5.Controls.Add(label5, 0, 4);
			tableLayoutPanel5.Controls.Add(label4, 0, 3);
			tableLayoutPanel5.Controls.Add(pnlIngredientInput, 1, 5);
			tableLayoutPanel5.Controls.Add(pnlTagInput, 1, 4);
			tableLayoutPanel5.Controls.Add(label3, 0, 2);
			tableLayoutPanel5.Controls.Add(label2, 0, 1);
			tableLayoutPanel5.Controls.Add(label1, 0, 0);
			tableLayoutPanel5.Controls.Add(label7, 0, 6);
			tableLayoutPanel5.Controls.Add(txtRecipeName, 1, 0);
			tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 1);
			tableLayoutPanel5.Controls.Add(flowLayoutPanel1, 1, 2);
			tableLayoutPanel5.Controls.Add(flowLayoutPanel2, 1, 7);
			tableLayoutPanel5.Dock = DockStyle.Fill;
			tableLayoutPanel5.Location = new Point(0, 0);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 8;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel5.Size = new Size(192, 67);
			tableLayoutPanel5.TabIndex = 1;
			// 
			// txtCookingMethod
			// 
			txtCookingMethod.Dock = DockStyle.Fill;
			txtCookingMethod.Location = new Point(157, 105);
			txtCookingMethod.Margin = new Padding(3, 2, 3, 2);
			txtCookingMethod.Multiline = true;
			txtCookingMethod.Name = "txtCookingMethod";
			txtCookingMethod.Size = new Size(30, 1);
			txtCookingMethod.TabIndex = 8;
			txtCookingMethod.TextChanged += RecipeInputFieldsChanged;
			// 
			// label6
			// 
			label6.Dock = DockStyle.Fill;
			label6.Location = new Point(5, 69);
			label6.Name = "label6";
			label6.Padding = new Padding(0, 6, 0, 0);
			label6.Size = new Size(144, 32);
			label6.TabIndex = 5;
			label6.Text = "Ингредиенты:";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// numRecipeRating
			// 
			numRecipeRating.AutoSize = true;
			numRecipeRating.Location = new Point(157, 3);
			numRecipeRating.Margin = new Padding(3, 2, 3, 2);
			numRecipeRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			numRecipeRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numRecipeRating.Name = "numRecipeRating";
			numRecipeRating.Size = new Size(30, 27);
			numRecipeRating.TabIndex = 9;
			numRecipeRating.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// label5
			// 
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(5, 35);
			label5.Name = "label5";
			label5.Padding = new Padding(0, 6, 0, 0);
			label5.Size = new Size(144, 32);
			label5.TabIndex = 4;
			label5.Text = "Теги:";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(5, 1);
			label4.Name = "label4";
			label4.Size = new Size(144, 32);
			label4.TabIndex = 3;
			label4.Text = "Рейтинг:";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlIngredientInput
			// 
			pnlIngredientInput.AutoScroll = true;
			pnlIngredientInput.Dock = DockStyle.Fill;
			pnlIngredientInput.Location = new Point(154, 69);
			pnlIngredientInput.Margin = new Padding(0);
			pnlIngredientInput.Name = "pnlIngredientInput";
			pnlIngredientInput.Size = new Size(36, 32);
			pnlIngredientInput.TabIndex = 15;
			pnlIngredientInput.ControlAdded += RecipeInputFieldsChanged;
			pnlIngredientInput.ControlRemoved += RecipeInputFieldsChanged;
			// 
			// pnlTagInput
			// 
			pnlTagInput.AutoScroll = true;
			pnlTagInput.Dock = DockStyle.Fill;
			pnlTagInput.Location = new Point(154, 35);
			pnlTagInput.Margin = new Padding(0);
			pnlTagInput.Name = "pnlTagInput";
			pnlTagInput.Size = new Size(36, 32);
			pnlTagInput.TabIndex = 14;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(5, -33);
			label3.Name = "label3";
			label3.Size = new Size(144, 32);
			label3.TabIndex = 2;
			label3.Text = "Время готовки:";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(5, 36);
			label2.Name = "label2";
			label2.Size = new Size(144, 1);
			label2.TabIndex = 1;
			label2.Text = "Фотография:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(5, 2);
			label1.Name = "label1";
			label1.Size = new Size(144, 32);
			label1.TabIndex = 0;
			label1.Text = "Название блюда:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Dock = DockStyle.Fill;
			label7.Location = new Point(5, 103);
			label7.Name = "label7";
			label7.Size = new Size(144, 1);
			label7.TabIndex = 6;
			label7.Text = "Способ приготовления:";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtRecipeName
			// 
			txtRecipeName.Dock = DockStyle.Fill;
			txtRecipeName.Location = new Point(157, 4);
			txtRecipeName.Margin = new Padding(3, 2, 3, 2);
			txtRecipeName.Name = "txtRecipeName";
			txtRecipeName.Size = new Size(30, 27);
			txtRecipeName.TabIndex = 7;
			txtRecipeName.TextChanged += RecipeInputFieldsChanged;
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 2;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel6.Controls.Add(picRecipePhoto, 0, 0);
			tableLayoutPanel6.Controls.Add(btnDeleteRecipePhoto, 0, 1);
			tableLayoutPanel6.Controls.Add(btnLoadRecipePhoto, 1, 1);
			tableLayoutPanel6.Dock = DockStyle.Fill;
			tableLayoutPanel6.Location = new Point(157, 39);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 2;
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel6.Size = new Size(30, 1);
			tableLayoutPanel6.TabIndex = 8;
			// 
			// picRecipePhoto
			// 
			tableLayoutPanel6.SetColumnSpan(picRecipePhoto, 2);
			picRecipePhoto.Dock = DockStyle.Fill;
			picRecipePhoto.Location = new Point(3, 2);
			picRecipePhoto.Margin = new Padding(3, 2, 3, 2);
			picRecipePhoto.Name = "picRecipePhoto";
			picRecipePhoto.Size = new Size(24, 1);
			picRecipePhoto.SizeMode = PictureBoxSizeMode.Zoom;
			picRecipePhoto.TabIndex = 11;
			picRecipePhoto.TabStop = false;
			// 
			// btnDeleteRecipePhoto
			// 
			btnDeleteRecipePhoto.Dock = DockStyle.Fill;
			btnDeleteRecipePhoto.Enabled = false;
			btnDeleteRecipePhoto.Location = new Point(3, -29);
			btnDeleteRecipePhoto.Margin = new Padding(3, 2, 3, 2);
			btnDeleteRecipePhoto.Name = "btnDeleteRecipePhoto";
			btnDeleteRecipePhoto.Size = new Size(9, 28);
			btnDeleteRecipePhoto.TabIndex = 13;
			btnDeleteRecipePhoto.Text = "Удалить";
			btnDeleteRecipePhoto.UseVisualStyleBackColor = true;
			btnDeleteRecipePhoto.Click += btnDeleteRecipePhoto_Click;
			// 
			// btnLoadRecipePhoto
			// 
			btnLoadRecipePhoto.Dock = DockStyle.Fill;
			btnLoadRecipePhoto.Location = new Point(18, -29);
			btnLoadRecipePhoto.Margin = new Padding(3, 2, 3, 2);
			btnLoadRecipePhoto.Name = "btnLoadRecipePhoto";
			btnLoadRecipePhoto.Size = new Size(9, 28);
			btnLoadRecipePhoto.TabIndex = 12;
			btnLoadRecipePhoto.Text = "Выбрать";
			btnLoadRecipePhoto.UseVisualStyleBackColor = true;
			btnLoadRecipePhoto.Click += btnLoadRecipePhoto_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(numWeeks);
			flowLayoutPanel1.Controls.Add(labelWeeks);
			flowLayoutPanel1.Controls.Add(numDays);
			flowLayoutPanel1.Controls.Add(labelDays);
			flowLayoutPanel1.Controls.Add(numHours);
			flowLayoutPanel1.Controls.Add(labelSeparator_1);
			flowLayoutPanel1.Controls.Add(numMinutes);
			flowLayoutPanel1.Controls.Add(labelSeparator_2);
			flowLayoutPanel1.Controls.Add(numSeconds);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(154, -33);
			flowLayoutPanel1.Margin = new Padding(0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(36, 32);
			flowLayoutPanel1.TabIndex = 9;
			// 
			// numWeeks
			// 
			numWeeks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			numWeeks.AutoSize = true;
			numWeeks.Location = new Point(3, 2);
			numWeeks.Margin = new Padding(3, 2, 3, 2);
			numWeeks.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			numWeeks.Name = "numWeeks";
			numWeeks.Size = new Size(41, 27);
			numWeeks.TabIndex = 5;
			numWeeks.ValueChanged += RecipeInputFieldsChanged;
			// 
			// labelWeeks
			// 
			labelWeeks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			labelWeeks.AutoSize = true;
			labelWeeks.Location = new Point(3, 31);
			labelWeeks.Name = "labelWeeks";
			labelWeeks.Size = new Size(28, 60);
			labelWeeks.TabIndex = 6;
			labelWeeks.Text = "недель, ";
			labelWeeks.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// numDays
			// 
			numDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			numDays.AutoSize = true;
			numDays.Location = new Point(3, 93);
			numDays.Margin = new Padding(3, 2, 3, 2);
			numDays.Maximum = new decimal(new int[] { 29, 0, 0, 0 });
			numDays.Name = "numDays";
			numDays.Size = new Size(41, 27);
			numDays.TabIndex = 7;
			numDays.ValueChanged += RecipeInputFieldsChanged;
			// 
			// labelDays
			// 
			labelDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			labelDays.AutoSize = true;
			labelDays.Location = new Point(3, 122);
			labelDays.Name = "labelDays";
			labelDays.Size = new Size(29, 40);
			labelDays.TabIndex = 8;
			labelDays.Text = "дней,";
			labelDays.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// numHours
			// 
			numHours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			numHours.AutoSize = true;
			numHours.Location = new Point(3, 164);
			numHours.Margin = new Padding(3, 2, 3, 2);
			numHours.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
			numHours.Name = "numHours";
			numHours.Size = new Size(41, 27);
			numHours.TabIndex = 0;
			numHours.ValueChanged += RecipeInputFieldsChanged;
			// 
			// labelSeparator_1
			// 
			labelSeparator_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			labelSeparator_1.AutoSize = true;
			labelSeparator_1.Location = new Point(3, 193);
			labelSeparator_1.Name = "labelSeparator_1";
			labelSeparator_1.Size = new Size(12, 20);
			labelSeparator_1.TabIndex = 4;
			labelSeparator_1.Text = ":";
			labelSeparator_1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// numMinutes
			// 
			numMinutes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			numMinutes.AutoSize = true;
			numMinutes.Location = new Point(3, 215);
			numMinutes.Margin = new Padding(3, 2, 3, 2);
			numMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
			numMinutes.Name = "numMinutes";
			numMinutes.Size = new Size(41, 27);
			numMinutes.TabIndex = 1;
			numMinutes.ValueChanged += RecipeInputFieldsChanged;
			// 
			// labelSeparator_2
			// 
			labelSeparator_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			labelSeparator_2.AutoSize = true;
			labelSeparator_2.Location = new Point(3, 244);
			labelSeparator_2.Name = "labelSeparator_2";
			labelSeparator_2.Size = new Size(12, 20);
			labelSeparator_2.TabIndex = 3;
			labelSeparator_2.Text = ":";
			labelSeparator_2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// numSeconds
			// 
			numSeconds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			numSeconds.AutoSize = true;
			numSeconds.Location = new Point(3, 266);
			numSeconds.Margin = new Padding(3, 2, 3, 2);
			numSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
			numSeconds.Name = "numSeconds";
			numSeconds.Size = new Size(41, 27);
			numSeconds.TabIndex = 2;
			numSeconds.ValueChanged += RecipeInputFieldsChanged;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(btnCancelCreationOrEdition);
			flowLayoutPanel2.Controls.Add(btnSaveRecipe);
			flowLayoutPanel2.Dock = DockStyle.Fill;
			flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel2.Location = new Point(154, 34);
			flowLayoutPanel2.Margin = new Padding(0);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(36, 32);
			flowLayoutPanel2.TabIndex = 16;
			// 
			// btnCancelCreationOrEdition
			// 
			btnCancelCreationOrEdition.Location = new Point(-87, 2);
			btnCancelCreationOrEdition.Margin = new Padding(3, 2, 3, 2);
			btnCancelCreationOrEdition.Name = "btnCancelCreationOrEdition";
			btnCancelCreationOrEdition.Size = new Size(120, 28);
			btnCancelCreationOrEdition.TabIndex = 2;
			btnCancelCreationOrEdition.Text = "Отмена";
			btnCancelCreationOrEdition.UseVisualStyleBackColor = true;
			btnCancelCreationOrEdition.Click += btnCancelCreationOrEdition_Click;
			// 
			// btnSaveRecipe
			// 
			btnSaveRecipe.Enabled = false;
			btnSaveRecipe.Location = new Point(-87, 34);
			btnSaveRecipe.Margin = new Padding(3, 2, 3, 2);
			btnSaveRecipe.Name = "btnSaveRecipe";
			btnSaveRecipe.Size = new Size(120, 28);
			btnSaveRecipe.TabIndex = 1;
			btnSaveRecipe.Text = "Сохранить";
			btnSaveRecipe.UseVisualStyleBackColor = true;
			btnSaveRecipe.Click += btnSaveRecipe_Click;
			// 
			// dlgLoadRecipePhoto
			// 
			dlgLoadRecipePhoto.DefaultExt = "jpg";
			dlgLoadRecipePhoto.FileName = "Фото.jpg";
			dlgLoadRecipePhoto.Filter = "Изображения|*.jpg;*.png";
			dlgLoadRecipePhoto.Title = "Выберите фотографию блюда";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(634, 698);
			Controls.Add(pnlMainLayout);
			Controls.Add(pnlSlideMenu);
			Margin = new Padding(3, 2, 3, 2);
			MinimumSize = new Size(650, 400);
			Name = "MainForm";
			Text = "Книга рецептов";
			FormClosed += MainForm_FormClosed;
			Load += MainForm_Load;
			pnlSlideMenu.ResumeLayout(false);
			pnlMainLayout.ResumeLayout(false);
			pnlMainLayout.PerformLayout();
			pnlUser.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picUser).EndInit();
			tbcMainFormTabs.ResumeLayout(false);
			tabListOfRecipes.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tabRecipeView.ResumeLayout(false);
			tabRecipeView.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picRecipeViewPhoto).EndInit();
			spoilerContainer3.ResumeLayout(false);
			spoilerContainer3.PerformLayout();
			spoilerContainer2.ResumeLayout(false);
			spoilerContainer2.PerformLayout();
			spoilerContainer1.ResumeLayout(false);
			spoilerContainer1.PerformLayout();
			tabCreateOrEditRecipe.ResumeLayout(false);
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numRecipeRating).EndInit();
			tableLayoutPanel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picRecipePhoto).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numWeeks).EndInit();
			((System.ComponentModel.ISupportInitialize)numDays).EndInit();
			((System.ComponentModel.ISupportInitialize)numHours).EndInit();
			((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
			((System.ComponentModel.ISupportInitialize)numSeconds).EndInit();
			flowLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private TableLayoutPanel pnlSlideMenu;
		private Label lblEditProfile;
		private Label lblHelp;
		private Label lblExit;
		private TableLayoutPanel pnlMainLayout;
		private TextBox txtSearch;
		private TableLayoutPanel pnlUser;
		private PictureBox picUser;
		private Label lblUser;
		private FlowLayoutPanel pnlTags;
		private TablessControl tbcMainFormTabs;
		private TabPage tabListOfRecipes;
		private TabPage tabRecipeView;
		private ComboBox cboContentSort;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lblSortBy;
		private Button btnShoppingList;
		private Button btnAddRecipe;
		private TabPage tabCreateOrEditRecipe;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox txtRecipeName;
		private TextBox txtCookingMethod;
		private NumericUpDown numRecipeRating;
		private NumericUpDown numHours;
		private NumericUpDown numMinutes;
		private NumericUpDown numSeconds;
		private Label labelSeparator_2;
		private Label labelSeparator_1;
		private Button btnCancelCreationOrEdition;
		private NumericUpDown numWeeks;
		private Label labelWeeks;
		private NumericUpDown numDays;
		private Label labelDays;
		private PictureBox picRecipePhoto;
		private Button btnDeleteRecipePhoto;
		private OpenFileDialog dlgLoadRecipePhoto;
		private AutoFillingFlowPanel pnlTagInput;
		private AutoFillingFlowPanel pnlIngredientInput;
		private ListView pnlRecipes;
		private Label lbl_1;
		private Label lbl_2;
		private Label lblRecipeName;
		private Label lbl_3;
		private Label lblRating;
		private Label lblRecipeCookingMethod;
		private FlowLayoutPanel pnlRecipeViewTags;
		private FlowLayoutPanel pnlRecipeViewIngredients;
		private SpoilerContainer spoilerContainer1;
		private SpoilerContainer spoilerContainer3;
		private SpoilerContainer spoilerContainer2;
		private TableLayoutPanel tableLayoutPanel4;
		private Button btnSaveRecipe;
		private Button btnLoadRecipePhoto;
		private TableLayoutPanel tableLayoutPanel5;
		private TableLayoutPanel tableLayoutPanel6;
		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel2;
		private PictureBox picRecipeViewPhoto;
		private Label lblCookingTime;
		private Button btnBackToMain;
		private Button btnEditRecipe;
		private Button btnDeleteRecipe;
	}
}
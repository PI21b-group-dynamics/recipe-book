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
            picUser = new PictureBox();
            lblUser = new Label();
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
            btnEditRecipe = new Button();
            btnDeleteRecipe = new Button();
            btnBackToMain = new Button();
            lblRecipeCookingMethod = new Label();
            picRecipeViewPhoto = new PictureBox();
            lblRating = new Label();
            lblCookingTime = new Label();
            lblRecipeName = new Label();
            lbl_3 = new Label();
            lbl_2 = new Label();
            lbl_1 = new Label();
            tabCreateOrEditRecipe = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtRecipeName = new TextBox();
            txtCookingMethod = new TextBox();
            numRecipeRating = new NumericUpDown();
            tableLayoutPanel3 = new TableLayoutPanel();
            numHours = new NumericUpDown();
            numSeconds = new NumericUpDown();
            numMinutes = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            numWeeks = new NumericUpDown();
            label10 = new Label();
            numDays = new NumericUpDown();
            label11 = new Label();
            btnSaveRecipe = new Button();
            btnCancelCreationOrEdition = new Button();
            picRecipePhoto = new PictureBox();
            btnLoadRecipePhoto = new Button();
            btnDeleteRecipePhoto = new Button();
            pnlTagInput = new AutoFillingFlowPanel();
            pnlIngredientInput = new AutoFillingFlowPanel();
            dlgLoadRecipePhoto = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnlSlideMenu.SuspendLayout();
            pnlMainLayout.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            tbcMainFormTabs.SuspendLayout();
            tabListOfRecipes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabRecipeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRecipeViewPhoto).BeginInit();
            tabCreateOrEditRecipe.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRecipeRating).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeeks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRecipePhoto).BeginInit();
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
            pnlSlideMenu.Location = new Point(5, 60);
            pnlSlideMenu.Margin = new Padding(0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Padding = new Padding(53, 0, 0, 0);
            pnlSlideMenu.RowCount = 3;
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlSlideMenu.Size = new Size(253, 107);
            pnlSlideMenu.TabIndex = 7;
            pnlSlideMenu.Visible = false;
            pnlSlideMenu.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // lblEditProfile
            // 
            lblEditProfile.AutoEllipsis = true;
            lblEditProfile.Cursor = Cursors.Hand;
            lblEditProfile.Dock = DockStyle.Fill;
            lblEditProfile.Location = new Point(61, 4);
            lblEditProfile.Margin = new Padding(8, 4, 8, 4);
            lblEditProfile.Name = "lblEditProfile";
            lblEditProfile.Size = new Size(184, 27);
            lblEditProfile.TabIndex = 4;
            lblEditProfile.Text = "Редактировать профиль";
            lblEditProfile.Click += lblEditProfile_Click;
            // 
            // lblHelp
            // 
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Dock = DockStyle.Fill;
            lblHelp.Location = new Point(61, 39);
            lblHelp.Margin = new Padding(8, 4, 8, 4);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(184, 27);
            lblHelp.TabIndex = 5;
            lblHelp.Text = "Справка";
            lblHelp.Click += lblHelp_Click;
            // 
            // lblExit
            // 
            lblExit.Cursor = Cursors.Hand;
            lblExit.Dock = DockStyle.Fill;
            lblExit.Location = new Point(61, 74);
            lblExit.Margin = new Padding(8, 4, 8, 4);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(184, 29);
            lblExit.TabIndex = 6;
            lblExit.Text = "Выйти";
            lblExit.Click += lblExit_Click;
            // 
            // pnlMainLayout
            // 
            pnlMainLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMainLayout.ColumnCount = 3;
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlMainLayout.Controls.Add(txtSearch, 2, 0);
            pnlMainLayout.Controls.Add(pnlUser, 0, 0);
            pnlMainLayout.Controls.Add(tbcMainFormTabs, 0, 1);
            pnlMainLayout.Location = new Point(0, 0);
            pnlMainLayout.Name = "pnlMainLayout";
            pnlMainLayout.RowCount = 2;
            pnlMainLayout.RowStyles.Add(new RowStyle());
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlMainLayout.Size = new Size(965, 529);
            pnlMainLayout.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(645, 16);
            txtSearch.Margin = new Padding(3, 16, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Найти...";
            txtSearch.Size = new Size(317, 27);
            txtSearch.TabIndex = 1;
            // 
            // pnlUser
            // 
            pnlUser.AutoSize = true;
            pnlUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlUser.ColumnCount = 2;
            pnlUser.ColumnStyles.Add(new ColumnStyle());
            pnlUser.ColumnStyles.Add(new ColumnStyle());
            pnlUser.Controls.Add(picUser, 0, 0);
            pnlUser.Controls.Add(lblUser, 1, 0);
            pnlUser.Location = new Point(3, 3);
            pnlUser.Name = "pnlUser";
            pnlUser.RowCount = 2;
            pnlUser.RowStyles.Add(new RowStyle());
            pnlUser.RowStyles.Add(new RowStyle());
            pnlUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlUser.Size = new Size(253, 54);
            pnlUser.TabIndex = 3;
            // 
            // picUser
            // 
            picUser.Dock = DockStyle.Fill;
            picUser.Image = Properties.Resources.UserIcon;
            picUser.InitialImage = (Image)resources.GetObject("picUser.InitialImage");
            picUser.Location = new Point(3, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(48, 48);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 1;
            picUser.TabStop = false;
            picUser.MouseEnter += ShowSlideMenuOnMouseEnter;
            picUser.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Left;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(59, 0);
            lblUser.Margin = new Padding(5, 0, 0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(194, 54);
            lblUser.TabIndex = 0;
            lblUser.Text = "Пользователь";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            lblUser.MouseEnter += ShowSlideMenuOnMouseEnter;
            lblUser.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // tbcMainFormTabs
            // 
            pnlMainLayout.SetColumnSpan(tbcMainFormTabs, 3);
            tbcMainFormTabs.Controls.Add(tabListOfRecipes);
            tbcMainFormTabs.Controls.Add(tabRecipeView);
            tbcMainFormTabs.Controls.Add(tabCreateOrEditRecipe);
            tbcMainFormTabs.Dock = DockStyle.Fill;
            tbcMainFormTabs.Location = new Point(3, 63);
            tbcMainFormTabs.Name = "tbcMainFormTabs";
            tbcMainFormTabs.SelectedIndex = 0;
            tbcMainFormTabs.Size = new Size(959, 463);
            tbcMainFormTabs.TabIndex = 5;
            tbcMainFormTabs.SelectedIndexChanged += tbcMainFormTabs_SelectedIndexChanged;
            // 
            // tabListOfRecipes
            // 
            tabListOfRecipes.Controls.Add(btnAddRecipe);
            tabListOfRecipes.Controls.Add(tableLayoutPanel1);
            tabListOfRecipes.Location = new Point(4, 29);
            tabListOfRecipes.Name = "tabListOfRecipes";
            tabListOfRecipes.Padding = new Padding(3);
            tabListOfRecipes.Size = new Size(951, 430);
            tabListOfRecipes.TabIndex = 0;
            tabListOfRecipes.Text = "Список";
            tabListOfRecipes.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRecipe.Location = new Point(852, 339);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(70, 69);
            btnAddRecipe.TabIndex = 9;
            btnAddRecipe.Text = "➕";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(cboContentSort, 3, 1);
            tableLayoutPanel1.Controls.Add(lblSortBy, 2, 1);
            tableLayoutPanel1.Controls.Add(pnlTags, 0, 0);
            tableLayoutPanel1.Controls.Add(btnShoppingList, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlRecipes, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(945, 424);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cboContentSort
            // 
            cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContentSort.FormattingEnabled = true;
            cboContentSort.Location = new Point(786, 3);
            cboContentSort.Name = "cboContentSort";
            cboContentSort.Size = new Size(156, 28);
            cboContentSort.TabIndex = 9;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Dock = DockStyle.Fill;
            lblSortBy.Location = new Point(656, 0);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(124, 36);
            lblSortBy.TabIndex = 10;
            lblSortBy.Text = "Сортировать по:";
            lblSortBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTags
            // 
            pnlTags.AutoScroll = true;
            pnlTags.AutoSize = true;
            pnlTags.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(pnlTags, 4);
            pnlTags.Dock = DockStyle.Fill;
            pnlTags.Location = new Point(0, 0);
            pnlTags.Margin = new Padding(0);
            pnlTags.Name = "pnlTags";
            pnlTags.Size = new Size(945, 1);
            pnlTags.TabIndex = 4;
            pnlTags.WrapContents = false;
            // 
            // btnShoppingList
            // 
            btnShoppingList.AutoSize = true;
            btnShoppingList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShoppingList.Location = new Point(3, 3);
            btnShoppingList.Name = "btnShoppingList";
            btnShoppingList.Size = new Size(313, 30);
            btnShoppingList.TabIndex = 11;
            btnShoppingList.Text = "Список покупок по выбранным рецептам";
            btnShoppingList.UseVisualStyleBackColor = true;
            btnShoppingList.Click += btnShoppingList_Click;
            // 
            // pnlRecipes
            // 
            tableLayoutPanel1.SetColumnSpan(pnlRecipes, 4);
            pnlRecipes.Dock = DockStyle.Fill;
            pnlRecipes.Location = new Point(3, 39);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.Size = new Size(939, 382);
            pnlRecipes.TabIndex = 12;
            pnlRecipes.UseCompatibleStateImageBehavior = false;
            pnlRecipes.DoubleClick += pnlRecipes_DoubleClick;
            // 
            // tabRecipeView
            // 
            tabRecipeView.Controls.Add(flowLayoutPanel2);
            tabRecipeView.Controls.Add(flowLayoutPanel1);
            tabRecipeView.Controls.Add(btnEditRecipe);
            tabRecipeView.Controls.Add(btnDeleteRecipe);
            tabRecipeView.Controls.Add(btnBackToMain);
            tabRecipeView.Controls.Add(lblRecipeCookingMethod);
            tabRecipeView.Controls.Add(picRecipeViewPhoto);
            tabRecipeView.Controls.Add(lblRating);
            tabRecipeView.Controls.Add(lblCookingTime);
            tabRecipeView.Controls.Add(lblRecipeName);
            tabRecipeView.Controls.Add(lbl_3);
            tabRecipeView.Controls.Add(lbl_2);
            tabRecipeView.Controls.Add(lbl_1);
            tabRecipeView.Location = new Point(4, 29);
            tabRecipeView.Name = "tabRecipeView";
            tabRecipeView.Padding = new Padding(3);
            tabRecipeView.Size = new Size(951, 430);
            tabRecipeView.TabIndex = 1;
            tabRecipeView.Text = "Просмотр";
            tabRecipeView.UseVisualStyleBackColor = true;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Location = new Point(783, 391);
            btnEditRecipe.Margin = new Padding(3, 4, 3, 4);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(132, 31);
            btnEditRecipe.TabIndex = 12;
            btnEditRecipe.Text = "Редактировать";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(680, 391);
            btnDeleteRecipe.Margin = new Padding(3, 4, 3, 4);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(86, 31);
            btnDeleteRecipe.TabIndex = 11;
            btnDeleteRecipe.Text = "Удалить";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(37, 391);
            btnBackToMain.Margin = new Padding(3, 4, 3, 4);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(86, 31);
            btnBackToMain.TabIndex = 10;
            btnBackToMain.Text = "Назад";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // lblRecipeCookingMethod
            // 
            lblRecipeCookingMethod.Location = new Point(37, 168);
            lblRecipeCookingMethod.Name = "lblRecipeCookingMethod";
            lblRecipeCookingMethod.Size = new Size(879, 187);
            lblRecipeCookingMethod.TabIndex = 9;
            // 
            // picRecipeViewPhoto
            // 
            picRecipeViewPhoto.Location = new Point(434, 36);
            picRecipeViewPhoto.Margin = new Padding(3, 4, 3, 4);
            picRecipeViewPhoto.Name = "picRecipeViewPhoto";
            picRecipeViewPhoto.Size = new Size(158, 108);
            picRecipeViewPhoto.TabIndex = 6;
            picRecipeViewPhoto.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.Location = new Point(179, 124);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(160, 20);
            lblRating.TabIndex = 5;
            // 
            // lblCookingTime
            // 
            lblCookingTime.Location = new Point(179, 80);
            lblCookingTime.Name = "lblCookingTime";
            lblCookingTime.Size = new Size(160, 20);
            lblCookingTime.TabIndex = 4;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Location = new Point(179, 36);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(160, 20);
            lblRecipeName.TabIndex = 3;
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Location = new Point(37, 124);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(116, 20);
            lbl_3.TabIndex = 2;
            lbl_3.Text = "Рейтинг блюда:";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Location = new Point(37, 80);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(119, 20);
            lbl_2.TabIndex = 1;
            lbl_2.Text = "Время готовки: ";
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Location = new Point(37, 36);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(129, 20);
            lbl_1.TabIndex = 0;
            lbl_1.Text = "Название блюда:";
            // 
            // tabCreateOrEditRecipe
            // 
            tabCreateOrEditRecipe.Controls.Add(tableLayoutPanel2);
            tabCreateOrEditRecipe.Location = new Point(4, 29);
            tabCreateOrEditRecipe.Name = "tabCreateOrEditRecipe";
            tabCreateOrEditRecipe.Size = new Size(951, 430);
            tabCreateOrEditRecipe.TabIndex = 2;
            tabCreateOrEditRecipe.Text = "Создание и редактирование";
            tabCreateOrEditRecipe.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 6);
            tableLayoutPanel2.Controls.Add(label7, 0, 7);
            tableLayoutPanel2.Controls.Add(txtRecipeName, 1, 0);
            tableLayoutPanel2.Controls.Add(txtCookingMethod, 1, 7);
            tableLayoutPanel2.Controls.Add(numRecipeRating, 1, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel2.Controls.Add(btnSaveRecipe, 3, 8);
            tableLayoutPanel2.Controls.Add(btnCancelCreationOrEdition, 2, 8);
            tableLayoutPanel2.Controls.Add(picRecipePhoto, 1, 1);
            tableLayoutPanel2.Controls.Add(btnLoadRecipePhoto, 3, 2);
            tableLayoutPanel2.Controls.Add(btnDeleteRecipePhoto, 2, 2);
            tableLayoutPanel2.Controls.Add(pnlTagInput, 1, 5);
            tableLayoutPanel2.Controls.Add(pnlIngredientInput, 1, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(951, 430);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 33);
            label1.TabIndex = 0;
            label1.Text = "Название блюда:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            tableLayoutPanel2.SetRowSpan(label2, 2);
            label2.Size = new Size(175, 401);
            label2.TabIndex = 1;
            label2.Text = "Фотография:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 434);
            label3.Name = "label3";
            label3.Size = new Size(175, 39);
            label3.TabIndex = 2;
            label3.Text = "Время готовки:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 473);
            label4.Name = "label4";
            label4.Size = new Size(175, 33);
            label4.TabIndex = 3;
            label4.Text = "Рейтинг:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 506);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 8, 0, 0);
            label5.Size = new Size(175, 73);
            label5.TabIndex = 4;
            label5.Text = "Теги:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 579);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 8, 0, 0);
            label6.Size = new Size(175, 73);
            label6.TabIndex = 5;
            label6.Text = "Ингредиенты:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 652);
            label7.Name = "label7";
            label7.Size = new Size(175, 366);
            label7.TabIndex = 6;
            label7.Text = "Способ приготовления:";
            // 
            // txtRecipeName
            // 
            tableLayoutPanel2.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Dock = DockStyle.Top;
            txtRecipeName.Location = new Point(184, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(764, 27);
            txtRecipeName.TabIndex = 7;
            txtRecipeName.TextChanged += RecipeInputFieldsChanged;
            // 
            // txtCookingMethod
            // 
            tableLayoutPanel2.SetColumnSpan(txtCookingMethod, 3);
            txtCookingMethod.Dock = DockStyle.Fill;
            txtCookingMethod.Location = new Point(184, 655);
            txtCookingMethod.Multiline = true;
            txtCookingMethod.Name = "txtCookingMethod";
            txtCookingMethod.Size = new Size(764, 360);
            txtCookingMethod.TabIndex = 8;
            txtCookingMethod.TextChanged += RecipeInputFieldsChanged;
            // 
            // numRecipeRating
            // 
            numRecipeRating.AutoSize = true;
            numRecipeRating.Location = new Point(184, 476);
            numRecipeRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRecipeRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRecipeRating.Name = "numRecipeRating";
            numRecipeRating.Size = new Size(45, 27);
            numRecipeRating.TabIndex = 9;
            numRecipeRating.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 10;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(numHours, 0, 0);
            tableLayoutPanel3.Controls.Add(numSeconds, 4, 0);
            tableLayoutPanel3.Controls.Add(numMinutes, 2, 0);
            tableLayoutPanel3.Controls.Add(label8, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 3, 0);
            tableLayoutPanel3.Controls.Add(numWeeks, 6, 0);
            tableLayoutPanel3.Controls.Add(label10, 7, 0);
            tableLayoutPanel3.Controls.Add(numDays, 8, 0);
            tableLayoutPanel3.Controls.Add(label11, 9, 0);
            tableLayoutPanel3.Location = new Point(184, 437);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(441, 33);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // numHours
            // 
            numHours.AutoSize = true;
            numHours.Location = new Point(3, 3);
            numHours.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.Size = new Size(45, 27);
            numHours.TabIndex = 0;
            numHours.ValueChanged += RecipeInputFieldsChanged;
            // 
            // numSeconds
            // 
            numSeconds.AutoSize = true;
            numSeconds.Location = new Point(141, 3);
            numSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numSeconds.Name = "numSeconds";
            numSeconds.Size = new Size(45, 27);
            numSeconds.TabIndex = 2;
            numSeconds.ValueChanged += RecipeInputFieldsChanged;
            // 
            // numMinutes
            // 
            numMinutes.AutoSize = true;
            numMinutes.Location = new Point(72, 3);
            numMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(45, 27);
            numMinutes.TabIndex = 1;
            numMinutes.ValueChanged += RecipeInputFieldsChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(54, 0);
            label8.Name = "label8";
            label8.Size = new Size(12, 33);
            label8.TabIndex = 3;
            label8.Text = ":";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(123, 0);
            label9.Name = "label9";
            label9.Size = new Size(12, 33);
            label9.TabIndex = 4;
            label9.Text = ":";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numWeeks
            // 
            numWeeks.AutoSize = true;
            numWeeks.Location = new Point(222, 3);
            numWeeks.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numWeeks.Name = "numWeeks";
            numWeeks.Size = new Size(45, 27);
            numWeeks.TabIndex = 5;
            numWeeks.ValueChanged += RecipeInputFieldsChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(273, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 33);
            label10.TabIndex = 6;
            label10.Text = "недель, ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDays
            // 
            numDays.AutoSize = true;
            numDays.Location = new Point(344, 3);
            numDays.Maximum = new decimal(new int[] { 29, 0, 0, 0 });
            numDays.Name = "numDays";
            numDays.Size = new Size(45, 27);
            numDays.TabIndex = 7;
            numDays.ValueChanged += RecipeInputFieldsChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(395, 0);
            label11.Name = "label11";
            label11.Size = new Size(43, 33);
            label11.TabIndex = 8;
            label11.Text = "дней";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Dock = DockStyle.Top;
            btnSaveRecipe.Enabled = false;
            btnSaveRecipe.Location = new Point(834, 1021);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(114, 29);
            btnSaveRecipe.TabIndex = 1;
            btnSaveRecipe.Text = "Сохранить";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            btnSaveRecipe.Click += btnSaveRecipe_Click;
            // 
            // btnCancelCreationOrEdition
            // 
            btnCancelCreationOrEdition.Dock = DockStyle.Top;
            btnCancelCreationOrEdition.Location = new Point(714, 1021);
            btnCancelCreationOrEdition.Name = "btnCancelCreationOrEdition";
            btnCancelCreationOrEdition.Size = new Size(114, 29);
            btnCancelCreationOrEdition.TabIndex = 2;
            btnCancelCreationOrEdition.Text = "Отмена";
            btnCancelCreationOrEdition.UseVisualStyleBackColor = true;
            btnCancelCreationOrEdition.Click += btnCancelCreationOrEdition_Click;
            // 
            // picRecipePhoto
            // 
            tableLayoutPanel2.SetColumnSpan(picRecipePhoto, 3);
            picRecipePhoto.Dock = DockStyle.Fill;
            picRecipePhoto.Location = new Point(184, 36);
            picRecipePhoto.Name = "picRecipePhoto";
            picRecipePhoto.Size = new Size(764, 360);
            picRecipePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picRecipePhoto.TabIndex = 11;
            picRecipePhoto.TabStop = false;
            // 
            // btnLoadRecipePhoto
            // 
            btnLoadRecipePhoto.Dock = DockStyle.Fill;
            btnLoadRecipePhoto.Location = new Point(834, 402);
            btnLoadRecipePhoto.Name = "btnLoadRecipePhoto";
            btnLoadRecipePhoto.Size = new Size(114, 29);
            btnLoadRecipePhoto.TabIndex = 12;
            btnLoadRecipePhoto.Text = "Выбрать";
            btnLoadRecipePhoto.UseVisualStyleBackColor = true;
            btnLoadRecipePhoto.Click += btnLoadRecipePhoto_Click;
            // 
            // btnDeleteRecipePhoto
            // 
            btnDeleteRecipePhoto.Dock = DockStyle.Fill;
            btnDeleteRecipePhoto.Enabled = false;
            btnDeleteRecipePhoto.Location = new Point(714, 402);
            btnDeleteRecipePhoto.Name = "btnDeleteRecipePhoto";
            btnDeleteRecipePhoto.Size = new Size(114, 29);
            btnDeleteRecipePhoto.TabIndex = 13;
            btnDeleteRecipePhoto.Text = "Удалить";
            btnDeleteRecipePhoto.UseVisualStyleBackColor = true;
            btnDeleteRecipePhoto.Click += btnDeleteRecipePhoto_Click;
            // 
            // pnlTagInput
            // 
            pnlTagInput.AutoScroll = true;
            tableLayoutPanel2.SetColumnSpan(pnlTagInput, 3);
            pnlTagInput.Dock = DockStyle.Fill;
            pnlTagInput.Location = new Point(184, 509);
            pnlTagInput.Name = "pnlTagInput";
            pnlTagInput.Size = new Size(764, 67);
            pnlTagInput.TabIndex = 14;
            // 
            // pnlIngredientInput
            // 
            pnlIngredientInput.AutoScroll = true;
            tableLayoutPanel2.SetColumnSpan(pnlIngredientInput, 3);
            pnlIngredientInput.Dock = DockStyle.Fill;
            pnlIngredientInput.Location = new Point(184, 582);
            pnlIngredientInput.Name = "pnlIngredientInput";
            pnlIngredientInput.Size = new Size(764, 67);
            pnlIngredientInput.TabIndex = 15;
            pnlIngredientInput.ControlAdded += RecipeInputFieldsChanged;
            pnlIngredientInput.ControlRemoved += RecipeInputFieldsChanged;
            // 
            // dlgLoadRecipePhoto
            // 
            dlgLoadRecipePhoto.DefaultExt = "jpg";
            dlgLoadRecipePhoto.FileName = "Фото.jpg";
            dlgLoadRecipePhoto.Filter = "Изображения|*.jpg;*.png";
            dlgLoadRecipePhoto.Title = "Выберите фотографию блюда";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(45, 165);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 80);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(508, 178);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(408, 83);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 531);
            Controls.Add(pnlMainLayout);
            Controls.Add(pnlSlideMenu);
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
            ((System.ComponentModel.ISupportInitialize)picRecipeViewPhoto).EndInit();
            tabCreateOrEditRecipe.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRecipeRating).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeeks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRecipePhoto).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
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
        private TableLayoutPanel tableLayoutPanel3;
        private NumericUpDown numHours;
        private NumericUpDown numMinutes;
        private NumericUpDown numSeconds;
        private Label label8;
        private Label label9;
        private Button btnCancelCreationOrEdition;
        private Button btnSaveRecipe;
        private NumericUpDown numWeeks;
        private Label label10;
        private NumericUpDown numDays;
        private Label label11;
        private PictureBox picRecipePhoto;
        private Button btnLoadRecipePhoto;
        private Button btnDeleteRecipePhoto;
        private OpenFileDialog dlgLoadRecipePhoto;
        private AutoFillingFlowPanel pnlTagInput;
        private AutoFillingFlowPanel pnlIngredientInput;
        private ListView pnlRecipes;
        private Label lbl_1;
        private Label lbl_2;
        private Label lblRecipeName;
        private Label lbl_3;
        private PictureBox picRecipeViewPhoto;
        private Label lblRating;
        private Label lblCookingTime;
        private Label lblRecipeCookingMethod;
        private Button btnEditRecipe;
        private Button btnDeleteRecipe;
        private Button btnBackToMain;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
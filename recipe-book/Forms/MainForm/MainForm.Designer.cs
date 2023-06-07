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
            pictureBox1 = new PictureBox();
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
            pnlSlideMenu.SuspendLayout();
            pnlMainLayout.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            tbcMainFormTabs.SuspendLayout();
            tabListOfRecipes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabRecipeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlSlideMenu.Location = new Point(3, 43);
            pnlSlideMenu.Margin = new Padding(0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Padding = new Padding(46, 0, 0, 0);
            pnlSlideMenu.RowCount = 3;
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            pnlSlideMenu.Size = new Size(221, 80);
            pnlSlideMenu.TabIndex = 7;
            pnlSlideMenu.Visible = false;
            pnlSlideMenu.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // lblEditProfile
            // 
            lblEditProfile.AutoEllipsis = true;
            lblEditProfile.Cursor = Cursors.Hand;
            lblEditProfile.Dock = DockStyle.Fill;
            lblEditProfile.Location = new Point(53, 3);
            lblEditProfile.Margin = new Padding(7, 3, 7, 3);
            lblEditProfile.Name = "lblEditProfile";
            lblEditProfile.Size = new Size(161, 20);
            lblEditProfile.TabIndex = 4;
            lblEditProfile.Text = "Редактировать профиль";
            lblEditProfile.Click += lblEditProfile_Click;
            // 
            // lblHelp
            // 
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Dock = DockStyle.Fill;
            lblHelp.Location = new Point(53, 29);
            lblHelp.Margin = new Padding(7, 3, 7, 3);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(161, 20);
            lblHelp.TabIndex = 5;
            lblHelp.Text = "Справка";
            lblHelp.Click += lblHelp_Click;
            // 
            // lblExit
            // 
            lblExit.Cursor = Cursors.Hand;
            lblExit.Dock = DockStyle.Fill;
            lblExit.Location = new Point(53, 55);
            lblExit.Margin = new Padding(7, 3, 7, 3);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(161, 22);
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
            pnlMainLayout.Margin = new Padding(3, 2, 3, 2);
            pnlMainLayout.Name = "pnlMainLayout";
            pnlMainLayout.RowCount = 2;
            pnlMainLayout.RowStyles.Add(new RowStyle());
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            pnlMainLayout.Size = new Size(844, 397);
            pnlMainLayout.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(565, 12);
            txtSearch.Margin = new Padding(3, 12, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Найти...";
            txtSearch.Size = new Size(276, 23);
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
            pnlUser.Location = new Point(3, 2);
            pnlUser.Margin = new Padding(3, 2, 3, 2);
            pnlUser.Name = "pnlUser";
            pnlUser.RowCount = 2;
            pnlUser.RowStyles.Add(new RowStyle());
            pnlUser.RowStyles.Add(new RowStyle());
            pnlUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            pnlUser.Size = new Size(222, 40);
            pnlUser.TabIndex = 3;
            // 
            // picUser
            // 
            picUser.Dock = DockStyle.Fill;
            picUser.Image = Properties.Resources.UserIcon;
            picUser.InitialImage = (Image)resources.GetObject("picUser.InitialImage");
            picUser.Location = new Point(3, 2);
            picUser.Margin = new Padding(3, 2, 3, 2);
            picUser.Name = "picUser";
            picUser.Size = new Size(42, 36);
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
            lblUser.Location = new Point(52, 0);
            lblUser.Margin = new Padding(4, 0, 0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(170, 40);
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
            tbcMainFormTabs.Location = new Point(3, 46);
            tbcMainFormTabs.Margin = new Padding(3, 2, 3, 2);
            tbcMainFormTabs.Name = "tbcMainFormTabs";
            tbcMainFormTabs.SelectedIndex = 0;
            tbcMainFormTabs.Size = new Size(838, 349);
            tbcMainFormTabs.TabIndex = 5;
            tbcMainFormTabs.SelectedIndexChanged += tbcMainFormTabs_SelectedIndexChanged;
            // 
            // tabListOfRecipes
            // 
            tabListOfRecipes.Controls.Add(btnAddRecipe);
            tabListOfRecipes.Controls.Add(tableLayoutPanel1);
            tabListOfRecipes.Location = new Point(4, 24);
            tabListOfRecipes.Margin = new Padding(3, 2, 3, 2);
            tabListOfRecipes.Name = "tabListOfRecipes";
            tabListOfRecipes.Padding = new Padding(3, 2, 3, 2);
            tabListOfRecipes.Size = new Size(830, 321);
            tabListOfRecipes.TabIndex = 0;
            tabListOfRecipes.Text = "Список";
            tabListOfRecipes.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRecipe.Location = new Point(745, 256);
            btnAddRecipe.Margin = new Padding(3, 2, 3, 2);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(61, 52);
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
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(824, 317);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cboContentSort
            // 
            cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContentSort.FormattingEnabled = true;
            cboContentSort.Location = new Point(684, 2);
            cboContentSort.Margin = new Padding(3, 2, 3, 2);
            cboContentSort.Name = "cboContentSort";
            cboContentSort.Size = new Size(137, 23);
            cboContentSort.TabIndex = 9;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Dock = DockStyle.Fill;
            lblSortBy.Location = new Point(580, 0);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(98, 29);
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
            pnlTags.Size = new Size(824, 1);
            pnlTags.TabIndex = 4;
            pnlTags.WrapContents = false;
            // 
            // btnShoppingList
            // 
            btnShoppingList.AutoSize = true;
            btnShoppingList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShoppingList.Location = new Point(3, 2);
            btnShoppingList.Margin = new Padding(3, 2, 3, 2);
            btnShoppingList.Name = "btnShoppingList";
            btnShoppingList.Size = new Size(250, 25);
            btnShoppingList.TabIndex = 11;
            btnShoppingList.Text = "Список покупок по выбранным рецептам";
            btnShoppingList.UseVisualStyleBackColor = true;
            btnShoppingList.Click += btnShoppingList_Click;
            // 
            // pnlRecipes
            // 
            tableLayoutPanel1.SetColumnSpan(pnlRecipes, 4);
            pnlRecipes.Dock = DockStyle.Fill;
            pnlRecipes.Location = new Point(3, 31);
            pnlRecipes.Margin = new Padding(3, 2, 3, 2);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.Size = new Size(818, 284);
            pnlRecipes.TabIndex = 12;
            pnlRecipes.UseCompatibleStateImageBehavior = false;
            pnlRecipes.DoubleClick += pnlRecipes_DoubleClick;
            // 
            // tabRecipeView
            // 
            tabRecipeView.Controls.Add(btnEditRecipe);
            tabRecipeView.Controls.Add(btnDeleteRecipe);
            tabRecipeView.Controls.Add(btnBackToMain);
            tabRecipeView.Controls.Add(lblRecipeCookingMethod);
            tabRecipeView.Controls.Add(pictureBox1);
            tabRecipeView.Controls.Add(lblRating);
            tabRecipeView.Controls.Add(lblCookingTime);
            tabRecipeView.Controls.Add(lblRecipeName);
            tabRecipeView.Controls.Add(lbl_3);
            tabRecipeView.Controls.Add(lbl_2);
            tabRecipeView.Controls.Add(lbl_1);
            tabRecipeView.Location = new Point(4, 24);
            tabRecipeView.Margin = new Padding(3, 2, 3, 2);
            tabRecipeView.Name = "tabRecipeView";
            tabRecipeView.Padding = new Padding(3, 2, 3, 2);
            tabRecipeView.Size = new Size(830, 321);
            tabRecipeView.TabIndex = 1;
            tabRecipeView.Text = "Просмотр";
            tabRecipeView.UseVisualStyleBackColor = true;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Location = new Point(703, 293);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(98, 23);
            btnEditRecipe.TabIndex = 12;
            btnEditRecipe.Text = "Редактировать";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(595, 293);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(75, 23);
            btnDeleteRecipe.TabIndex = 11;
            btnDeleteRecipe.Text = "Удалить";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(32, 293);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(75, 23);
            btnBackToMain.TabIndex = 10;
            btnBackToMain.Text = "Вернуться";
            btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // lblRecipeCookingMethod
            // 
            lblRecipeCookingMethod.Location = new Point(32, 126);
            lblRecipeCookingMethod.Name = "lblRecipeCookingMethod";
            lblRecipeCookingMethod.Size = new Size(769, 140);
            lblRecipeCookingMethod.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(380, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 81);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.Location = new Point(157, 93);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(140, 15);
            lblRating.TabIndex = 5;
            // 
            // lblCookingTime
            // 
            lblCookingTime.Location = new Point(157, 60);
            lblCookingTime.Name = "lblCookingTime";
            lblCookingTime.Size = new Size(140, 15);
            lblCookingTime.TabIndex = 4;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Location = new Point(157, 27);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(140, 15);
            lblRecipeName.TabIndex = 3;
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Location = new Point(32, 93);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(93, 15);
            lbl_3.TabIndex = 2;
            lbl_3.Text = "Рейтинг блюда:";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Location = new Point(32, 60);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(94, 15);
            lbl_2.TabIndex = 1;
            lbl_2.Text = "Время готовки: ";
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Location = new Point(32, 27);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(101, 15);
            lbl_1.TabIndex = 0;
            lbl_1.Text = "Название блюда:";
            // 
            // tabCreateOrEditRecipe
            // 
            tabCreateOrEditRecipe.Controls.Add(tableLayoutPanel2);
            tabCreateOrEditRecipe.Location = new Point(4, 24);
            tabCreateOrEditRecipe.Margin = new Padding(3, 2, 3, 2);
            tabCreateOrEditRecipe.Name = "tabCreateOrEditRecipe";
            tabCreateOrEditRecipe.Size = new Size(830, 321);
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
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
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
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
            tableLayoutPanel2.Size = new Size(830, 321);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 27);
            label1.TabIndex = 0;
            label1.Text = "Название блюда:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            tableLayoutPanel2.SetRowSpan(label2, 2);
            label2.Size = new Size(139, 300);
            label2.TabIndex = 1;
            label2.Text = "Фотография:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 327);
            label3.Name = "label3";
            label3.Size = new Size(139, 31);
            label3.TabIndex = 2;
            label3.Text = "Время готовки:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 358);
            label4.Name = "label4";
            label4.Size = new Size(139, 27);
            label4.TabIndex = 3;
            label4.Text = "Рейтинг:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 385);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 6, 0, 0);
            label5.Size = new Size(139, 54);
            label5.TabIndex = 4;
            label5.Text = "Теги:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 439);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 6, 0, 0);
            label6.Size = new Size(139, 54);
            label6.TabIndex = 5;
            label6.Text = "Ингредиенты:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 493);
            label7.Name = "label7";
            label7.Size = new Size(139, 275);
            label7.TabIndex = 6;
            label7.Text = "Способ приготовления:";
            // 
            // txtRecipeName
            // 
            tableLayoutPanel2.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Dock = DockStyle.Top;
            txtRecipeName.Location = new Point(148, 2);
            txtRecipeName.Margin = new Padding(3, 2, 3, 2);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(679, 23);
            txtRecipeName.TabIndex = 7;
            // 
            // txtCookingMethod
            // 
            tableLayoutPanel2.SetColumnSpan(txtCookingMethod, 3);
            txtCookingMethod.Dock = DockStyle.Fill;
            txtCookingMethod.Location = new Point(148, 495);
            txtCookingMethod.Margin = new Padding(3, 2, 3, 2);
            txtCookingMethod.Multiline = true;
            txtCookingMethod.Name = "txtCookingMethod";
            txtCookingMethod.Size = new Size(679, 271);
            txtCookingMethod.TabIndex = 8;
            // 
            // numRecipeRating
            // 
            numRecipeRating.AutoSize = true;
            numRecipeRating.Location = new Point(148, 360);
            numRecipeRating.Margin = new Padding(3, 2, 3, 2);
            numRecipeRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRecipeRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRecipeRating.Name = "numRecipeRating";
            numRecipeRating.Size = new Size(35, 23);
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
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
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
            tableLayoutPanel3.Location = new Point(148, 329);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(359, 27);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // numHours
            // 
            numHours.AutoSize = true;
            numHours.Location = new Point(3, 2);
            numHours.Margin = new Padding(3, 2, 3, 2);
            numHours.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.Size = new Size(35, 23);
            numHours.TabIndex = 0;
            // 
            // numSeconds
            // 
            numSeconds.AutoSize = true;
            numSeconds.Location = new Point(117, 2);
            numSeconds.Margin = new Padding(3, 2, 3, 2);
            numSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numSeconds.Name = "numSeconds";
            numSeconds.Size = new Size(35, 23);
            numSeconds.TabIndex = 2;
            // 
            // numMinutes
            // 
            numMinutes.AutoSize = true;
            numMinutes.Location = new Point(60, 2);
            numMinutes.Margin = new Padding(3, 2, 3, 2);
            numMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(35, 23);
            numMinutes.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(44, 0);
            label8.Name = "label8";
            label8.Size = new Size(10, 27);
            label8.TabIndex = 3;
            label8.Text = ":";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(101, 0);
            label9.Name = "label9";
            label9.Size = new Size(10, 27);
            label9.TabIndex = 4;
            label9.Text = ":";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numWeeks
            // 
            numWeeks.AutoSize = true;
            numWeeks.Location = new Point(184, 2);
            numWeeks.Margin = new Padding(3, 2, 3, 2);
            numWeeks.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numWeeks.Name = "numWeeks";
            numWeeks.Size = new Size(35, 23);
            numWeeks.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(225, 0);
            label10.Name = "label10";
            label10.Size = new Size(51, 27);
            label10.TabIndex = 6;
            label10.Text = "недель, ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDays
            // 
            numDays.AutoSize = true;
            numDays.Location = new Point(282, 2);
            numDays.Margin = new Padding(3, 2, 3, 2);
            numDays.Maximum = new decimal(new int[] { 29, 0, 0, 0 });
            numDays.Name = "numDays";
            numDays.Size = new Size(35, 23);
            numDays.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(323, 0);
            label11.Name = "label11";
            label11.Size = new Size(33, 27);
            label11.TabIndex = 8;
            label11.Text = "дней";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Dock = DockStyle.Top;
            btnSaveRecipe.Location = new Point(728, 770);
            btnSaveRecipe.Margin = new Padding(3, 2, 3, 2);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(99, 22);
            btnSaveRecipe.TabIndex = 1;
            btnSaveRecipe.Text = "Сохранить";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            btnSaveRecipe.Click += btnSaveRecipe_Click;
            // 
            // btnCancelCreationOrEdition
            // 
            btnCancelCreationOrEdition.Dock = DockStyle.Top;
            btnCancelCreationOrEdition.Location = new Point(623, 770);
            btnCancelCreationOrEdition.Margin = new Padding(3, 2, 3, 2);
            btnCancelCreationOrEdition.Name = "btnCancelCreationOrEdition";
            btnCancelCreationOrEdition.Size = new Size(99, 22);
            btnCancelCreationOrEdition.TabIndex = 2;
            btnCancelCreationOrEdition.Text = "Отмена";
            btnCancelCreationOrEdition.UseVisualStyleBackColor = true;
            btnCancelCreationOrEdition.Click += btnCancelCreationOrEdition_Click;
            // 
            // picRecipePhoto
            // 
            tableLayoutPanel2.SetColumnSpan(picRecipePhoto, 3);
            picRecipePhoto.Dock = DockStyle.Fill;
            picRecipePhoto.Location = new Point(148, 29);
            picRecipePhoto.Margin = new Padding(3, 2, 3, 2);
            picRecipePhoto.Name = "picRecipePhoto";
            picRecipePhoto.Size = new Size(679, 270);
            picRecipePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picRecipePhoto.TabIndex = 11;
            picRecipePhoto.TabStop = false;
            // 
            // btnLoadRecipePhoto
            // 
            btnLoadRecipePhoto.Dock = DockStyle.Fill;
            btnLoadRecipePhoto.Location = new Point(728, 303);
            btnLoadRecipePhoto.Margin = new Padding(3, 2, 3, 2);
            btnLoadRecipePhoto.Name = "btnLoadRecipePhoto";
            btnLoadRecipePhoto.Size = new Size(99, 22);
            btnLoadRecipePhoto.TabIndex = 12;
            btnLoadRecipePhoto.Text = "Выбрать";
            btnLoadRecipePhoto.UseVisualStyleBackColor = true;
            btnLoadRecipePhoto.Click += btnLoadRecipePhoto_Click;
            // 
            // btnDeleteRecipePhoto
            // 
            btnDeleteRecipePhoto.Dock = DockStyle.Fill;
            btnDeleteRecipePhoto.Enabled = false;
            btnDeleteRecipePhoto.Location = new Point(623, 303);
            btnDeleteRecipePhoto.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRecipePhoto.Name = "btnDeleteRecipePhoto";
            btnDeleteRecipePhoto.Size = new Size(99, 22);
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
            pnlTagInput.Location = new Point(148, 387);
            pnlTagInput.Margin = new Padding(3, 2, 3, 2);
            pnlTagInput.Name = "pnlTagInput";
            pnlTagInput.Size = new Size(679, 50);
            pnlTagInput.TabIndex = 14;
            // 
            // pnlIngredientInput
            // 
            pnlIngredientInput.AutoScroll = true;
            tableLayoutPanel2.SetColumnSpan(pnlIngredientInput, 3);
            pnlIngredientInput.Dock = DockStyle.Fill;
            pnlIngredientInput.Location = new Point(148, 441);
            pnlIngredientInput.Margin = new Padding(3, 2, 3, 2);
            pnlIngredientInput.Name = "pnlIngredientInput";
            pnlIngredientInput.Size = new Size(679, 50);
            pnlIngredientInput.TabIndex = 15;
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
            ClientSize = new Size(844, 398);
            Controls.Add(pnlMainLayout);
            Controls.Add(pnlSlideMenu);
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lblRating;
        private Label lblCookingTime;
        private Label lblRecipeCookingMethod;
        private Button btnEditRecipe;
        private Button btnDeleteRecipe;
        private Button btnBackToMain;
    }
}
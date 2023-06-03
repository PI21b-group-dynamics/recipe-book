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
            lblChangeProfile = new Label();
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
            pnlRecipes = new TableLayoutPanel();
            tabRecipeView = new TabPage();
            tabCreateOrEditRecipe = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            tableLayoutPanel3 = new TableLayoutPanel();
            numericUpDown2 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            numericUpDown5 = new NumericUpDown();
            label10 = new Label();
            numericUpDown6 = new NumericUpDown();
            label11 = new Label();
            button1 = new Button();
            btnCancelCreationOrEdition = new Button();
            picRecipePhoto = new PictureBox();
            btnLoadRecipePhoto = new Button();
            btnDeleteRecipePhoto = new Button();
            dlgLoadRecipePhoto = new OpenFileDialog();
            pnlSlideMenu.SuspendLayout();
            pnlMainLayout.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            tbcMainFormTabs.SuspendLayout();
            tabListOfRecipes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabCreateOrEditRecipe.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRecipePhoto).BeginInit();
            SuspendLayout();
            // 
            // pnlSlideMenu
            // 
            pnlSlideMenu.BackColor = SystemColors.ControlDark;
            pnlSlideMenu.ColumnCount = 1;
            pnlSlideMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSlideMenu.Controls.Add(lblChangeProfile, 0, 0);
            pnlSlideMenu.Controls.Add(lblHelp, 0, 1);
            pnlSlideMenu.Controls.Add(lblExit, 0, 2);
            pnlSlideMenu.Location = new Point(3, 57);
            pnlSlideMenu.Margin = new Padding(0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Padding = new Padding(52, 0, 0, 0);
            pnlSlideMenu.RowCount = 3;
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlSlideMenu.Size = new Size(252, 107);
            pnlSlideMenu.TabIndex = 7;
            pnlSlideMenu.Visible = false;
            pnlSlideMenu.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // lblChangeProfile
            // 
            lblChangeProfile.AutoEllipsis = true;
            lblChangeProfile.Cursor = Cursors.Hand;
            lblChangeProfile.Dock = DockStyle.Fill;
            lblChangeProfile.Location = new Point(60, 4);
            lblChangeProfile.Margin = new Padding(8, 4, 8, 4);
            lblChangeProfile.Name = "lblChangeProfile";
            lblChangeProfile.Size = new Size(184, 27);
            lblChangeProfile.TabIndex = 4;
            lblChangeProfile.Text = "Редактировать профиль";
            // 
            // lblHelp
            // 
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Dock = DockStyle.Fill;
            lblHelp.Location = new Point(60, 39);
            lblHelp.Margin = new Padding(8, 4, 8, 4);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(184, 27);
            lblHelp.TabIndex = 5;
            lblHelp.Text = "Справка";
            // 
            // lblExit
            // 
            lblExit.Cursor = Cursors.Hand;
            lblExit.Dock = DockStyle.Fill;
            lblExit.Location = new Point(60, 74);
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
            pnlMainLayout.Size = new Size(964, 529);
            pnlMainLayout.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(645, 16);
            txtSearch.Margin = new Padding(3, 16, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Найти...";
            txtSearch.Size = new Size(316, 27);
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
            pnlUser.Size = new Size(252, 54);
            pnlUser.TabIndex = 3;
            // 
            // picUser
            // 
            picUser.Dock = DockStyle.Fill;
            picUser.Image = Properties.Resources.user_icon;
            picUser.InitialImage = (Image)resources.GetObject("picUser.InitialImage");
            picUser.Location = new Point(3, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(48, 48);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 1;
            picUser.TabStop = false;
            picUser.MouseEnter += pnlUser_MouseEnter;
            picUser.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Left;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(58, 0);
            lblUser.Margin = new Padding(4, 0, 0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(194, 54);
            lblUser.TabIndex = 0;
            lblUser.Text = "Пользователь";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            lblUser.MouseEnter += pnlUser_MouseEnter;
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
            tbcMainFormTabs.Size = new Size(958, 463);
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
            tabListOfRecipes.Size = new Size(950, 430);
            tabListOfRecipes.TabIndex = 0;
            tabListOfRecipes.Text = "Список";
            tabListOfRecipes.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRecipe.Location = new Point(833, 338);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(70, 70);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(944, 424);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cboContentSort
            // 
            cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContentSort.FormattingEnabled = true;
            cboContentSort.Location = new Point(785, 61);
            cboContentSort.Name = "cboContentSort";
            cboContentSort.Size = new Size(156, 28);
            cboContentSort.TabIndex = 9;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Dock = DockStyle.Fill;
            lblSortBy.Location = new Point(655, 58);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(124, 36);
            lblSortBy.TabIndex = 10;
            lblSortBy.Text = "Сортировать по:";
            lblSortBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTags
            // 
            pnlTags.AutoScroll = true;
            tableLayoutPanel1.SetColumnSpan(pnlTags, 4);
            pnlTags.Dock = DockStyle.Fill;
            pnlTags.Location = new Point(0, 0);
            pnlTags.Margin = new Padding(0);
            pnlTags.Name = "pnlTags";
            pnlTags.Size = new Size(944, 58);
            pnlTags.TabIndex = 4;
            pnlTags.WrapContents = false;
            // 
            // btnShoppingList
            // 
            btnShoppingList.AutoSize = true;
            btnShoppingList.Location = new Point(3, 61);
            btnShoppingList.Name = "btnShoppingList";
            btnShoppingList.Size = new Size(313, 30);
            btnShoppingList.TabIndex = 11;
            btnShoppingList.Text = "Список покупок по выбранным рецептам";
            btnShoppingList.UseVisualStyleBackColor = true;
            btnShoppingList.Click += btnShoppingList_Click;
            // 
            // pnlRecipes
            // 
            pnlRecipes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecipes.AutoScroll = true;
            pnlRecipes.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(pnlRecipes, 4);
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.Location = new Point(3, 97);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.RowCount = 6;
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.Size = new Size(938, 324);
            pnlRecipes.TabIndex = 12;
            // 
            // tabRecipeView
            // 
            tabRecipeView.Location = new Point(4, 29);
            tabRecipeView.Name = "tabRecipeView";
            tabRecipeView.Padding = new Padding(3);
            tabRecipeView.Size = new Size(950, 430);
            tabRecipeView.TabIndex = 1;
            tabRecipeView.Text = "Просмотр";
            tabRecipeView.UseVisualStyleBackColor = true;
            // 
            // tabCreateOrEditRecipe
            // 
            tabCreateOrEditRecipe.Controls.Add(tableLayoutPanel2);
            tabCreateOrEditRecipe.Location = new Point(4, 29);
            tabCreateOrEditRecipe.Name = "tabCreateOrEditRecipe";
            tabCreateOrEditRecipe.Size = new Size(950, 430);
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
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 7);
            tableLayoutPanel2.Controls.Add(numericUpDown1, 1, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel2.Controls.Add(button1, 3, 8);
            tableLayoutPanel2.Controls.Add(btnCancelCreationOrEdition, 2, 8);
            tableLayoutPanel2.Controls.Add(picRecipePhoto, 1, 1);
            tableLayoutPanel2.Controls.Add(btnLoadRecipePhoto, 3, 2);
            tableLayoutPanel2.Controls.Add(btnDeleteRecipePhoto, 2, 2);
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
            tableLayoutPanel2.Size = new Size(950, 430);
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
            label5.Size = new Size(175, 20);
            label5.TabIndex = 4;
            label5.Text = "Теги:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 526);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 5;
            label6.Text = "Ингредиенты:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 546);
            label7.Name = "label7";
            label7.Size = new Size(175, 366);
            label7.TabIndex = 6;
            label7.Text = "Способ приготовления:";
            // 
            // textBox1
            // 
            tableLayoutPanel2.SetColumnSpan(textBox1, 3);
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(184, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(763, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            tableLayoutPanel2.SetColumnSpan(textBox2, 3);
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(184, 549);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(763, 360);
            textBox2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.AutoSize = true;
            numericUpDown1.Location = new Point(184, 476);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 27);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
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
            tableLayoutPanel3.Controls.Add(numericUpDown2, 0, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown4, 4, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown3, 2, 0);
            tableLayoutPanel3.Controls.Add(label8, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 3, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown5, 6, 0);
            tableLayoutPanel3.Controls.Add(label10, 7, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown6, 8, 0);
            tableLayoutPanel3.Controls.Add(label11, 9, 0);
            tableLayoutPanel3.Location = new Point(184, 437);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(441, 33);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.AutoSize = true;
            numericUpDown2.Location = new Point(3, 3);
            numericUpDown2.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(45, 27);
            numericUpDown2.TabIndex = 0;
            // 
            // numericUpDown4
            // 
            numericUpDown4.AutoSize = true;
            numericUpDown4.Location = new Point(141, 3);
            numericUpDown4.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(45, 27);
            numericUpDown4.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            numericUpDown3.AutoSize = true;
            numericUpDown3.Location = new Point(72, 3);
            numericUpDown3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(45, 27);
            numericUpDown3.TabIndex = 1;
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
            // numericUpDown5
            // 
            numericUpDown5.AutoSize = true;
            numericUpDown5.Location = new Point(222, 3);
            numericUpDown5.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(45, 27);
            numericUpDown5.TabIndex = 5;
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
            // numericUpDown6
            // 
            numericUpDown6.AutoSize = true;
            numericUpDown6.Location = new Point(344, 3);
            numericUpDown6.Maximum = new decimal(new int[] { 29, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(45, 27);
            numericUpDown6.TabIndex = 7;
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
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(833, 915);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 1;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelCreationOrEdition
            // 
            btnCancelCreationOrEdition.Dock = DockStyle.Top;
            btnCancelCreationOrEdition.Location = new Point(713, 915);
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
            picRecipePhoto.Size = new Size(763, 360);
            picRecipePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picRecipePhoto.TabIndex = 11;
            picRecipePhoto.TabStop = false;
            // 
            // btnLoadRecipePhoto
            // 
            btnLoadRecipePhoto.Dock = DockStyle.Fill;
            btnLoadRecipePhoto.Location = new Point(833, 402);
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
            btnDeleteRecipePhoto.Location = new Point(713, 402);
            btnDeleteRecipePhoto.Name = "btnDeleteRecipePhoto";
            btnDeleteRecipePhoto.Size = new Size(114, 29);
            btnDeleteRecipePhoto.TabIndex = 13;
            btnDeleteRecipePhoto.Text = "Удалить";
            btnDeleteRecipePhoto.UseVisualStyleBackColor = true;
            btnDeleteRecipePhoto.Click += btnDeleteRecipePhoto_Click;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 531);
            Controls.Add(pnlSlideMenu);
            Controls.Add(pnlMainLayout);
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
            tabCreateOrEditRecipe.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRecipePhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel pnlSlideMenu;
        private Label lblChangeProfile;
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
        private TableLayoutPanel pnlRecipes;
        private TabPage tabCreateOrEditRecipe;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label8;
        private Label label9;
        private Button btnCancelCreationOrEdition;
        private Button button1;
        private NumericUpDown numericUpDown5;
        private Label label10;
        private NumericUpDown numericUpDown6;
        private Label label11;
        private PictureBox picRecipePhoto;
        private Button btnLoadRecipePhoto;
        private Button btnDeleteRecipePhoto;
        private OpenFileDialog dlgLoadRecipePhoto;
    }
}
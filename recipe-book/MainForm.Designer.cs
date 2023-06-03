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
            pnlTags = new FlowLayoutPanel();
            tabMainFormTabs = new TablessControl();
            tabPage1 = new TabPage();
            btnAddRecipe = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboContentSort = new ComboBox();
            lblSortBy = new Label();
            btnShoppingList = new Button();
            pnlRecipes = new TableLayoutPanel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            pnlSlideMenu.SuspendLayout();
            pnlMainLayout.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            tabMainFormTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlMainLayout.Controls.Add(txtSearch, 2, 0);
            pnlMainLayout.Controls.Add(pnlUser, 0, 0);
            pnlMainLayout.Controls.Add(pnlTags, 0, 1);
            pnlMainLayout.Controls.Add(tabMainFormTabs, 0, 2);
            pnlMainLayout.Location = new Point(0, 0);
            pnlMainLayout.Name = "pnlMainLayout";
            pnlMainLayout.RowCount = 3;
            pnlMainLayout.RowStyles.Add(new RowStyle());
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlMainLayout.Size = new Size(928, 496);
            pnlMainLayout.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(621, 16);
            txtSearch.Margin = new Padding(3, 16, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Найти...";
            txtSearch.Size = new Size(304, 27);
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
            // 
            // pnlTags
            // 
            pnlTags.AutoScroll = true;
            pnlMainLayout.SetColumnSpan(pnlTags, 3);
            pnlTags.Dock = DockStyle.Fill;
            pnlTags.Location = new Point(0, 60);
            pnlTags.Margin = new Padding(0);
            pnlTags.Name = "pnlTags";
            pnlTags.Size = new Size(928, 58);
            pnlTags.TabIndex = 4;
            pnlTags.WrapContents = false;
            // 
            // tabMainFormTabs
            // 
            pnlMainLayout.SetColumnSpan(tabMainFormTabs, 3);
            tabMainFormTabs.Controls.Add(tabPage1);
            tabMainFormTabs.Controls.Add(tabPage2);
            tabMainFormTabs.Controls.Add(tabPage3);
            tabMainFormTabs.Dock = DockStyle.Fill;
            tabMainFormTabs.Location = new Point(3, 121);
            tabMainFormTabs.Name = "tabMainFormTabs";
            tabMainFormTabs.SelectedIndex = 0;
            tabMainFormTabs.Size = new Size(922, 372);
            tabMainFormTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddRecipe);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(914, 339);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRecipe.Location = new Point(805, 252);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(70, 70);
            btnAddRecipe.TabIndex = 9;
            btnAddRecipe.Text = "➕";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(cboContentSort, 3, 0);
            tableLayoutPanel1.Controls.Add(lblSortBy, 2, 0);
            tableLayoutPanel1.Controls.Add(btnShoppingList, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlRecipes, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(908, 333);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cboContentSort
            // 
            cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContentSort.FormattingEnabled = true;
            cboContentSort.Location = new Point(749, 3);
            cboContentSort.Name = "cboContentSort";
            cboContentSort.Size = new Size(156, 28);
            cboContentSort.TabIndex = 9;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Dock = DockStyle.Fill;
            lblSortBy.Location = new Point(619, 0);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(124, 36);
            lblSortBy.TabIndex = 10;
            lblSortBy.Text = "Сортировать по:";
            lblSortBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShoppingList
            // 
            btnShoppingList.AutoSize = true;
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
            pnlRecipes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecipes.AutoScroll = true;
            pnlRecipes.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(pnlRecipes, 4);
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.Location = new Point(3, 39);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.RowCount = 6;
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlRecipes.Size = new Size(902, 291);
            pnlRecipes.TabIndex = 12;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(914, 339);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Просмотр";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(914, 339);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Создание и редактирование";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // NewMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 498);
            Controls.Add(pnlSlideMenu);
            Controls.Add(pnlMainLayout);
            Name = "NewMainForm";
            Text = "Книга рецептов";
            Load += MainForm_Load;
            FormClosed += MainForm_FormClosed;
            pnlSlideMenu.ResumeLayout(false);
            pnlMainLayout.ResumeLayout(false);
            pnlMainLayout.PerformLayout();
            pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            tabMainFormTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TablessControl tabMainFormTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cboContentSort;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSortBy;
        private Button btnShoppingList;
        private Button btnAddRecipe;
        private TableLayoutPanel pnlRecipes;
        private TabPage tabPage3;
    }
}
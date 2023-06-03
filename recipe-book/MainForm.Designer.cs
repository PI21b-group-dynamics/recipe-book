namespace recipe_book
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlHeader = new Panel();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            pnlUser = new TableLayoutPanel();
            picUser = new PictureBox();
            pnlSlideMenu = new TableLayoutPanel();
            lblChangeProfile = new Label();
            lblHelp = new Label();
            lblExit = new Label();
            lblUser = new Label();
            pnlFormContent = new TableLayoutPanel();
            ContentTagPanel = new Panel();
            pnlTags = new FlowLayoutPanel();
            ContentRecContainer = new Panel();
            btnAddRecipe = new Button();
            pnlRecipes = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboContentSort = new ComboBox();
            lblSortBy = new Label();
            btnShoppingList = new Button();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlSlideMenu.SuspendLayout();
            pnlFormContent.SuspendLayout();
            ContentTagPanel.SuspendLayout();
            ContentRecContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlSearch);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlHeader.Location = new Point(2, 2);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(837, 56);
            pnlHeader.TabIndex = 0;
            // 
            // pnlSearch
            // 
            pnlSearch.AutoSize = true;
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Right;
            pnlSearch.Location = new Point(563, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(274, 56);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Найти...";
            txtSearch.Size = new Size(268, 32);
            txtSearch.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.AutoSize = true;
            pnlUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlUser.ColumnCount = 2;
            pnlUser.ColumnStyles.Add(new ColumnStyle());
            pnlUser.ColumnStyles.Add(new ColumnStyle());
            pnlUser.Controls.Add(picUser, 0, 0);
            pnlUser.Controls.Add(pnlSlideMenu, 0, 1);
            pnlUser.Controls.Add(lblUser, 1, 0);
            pnlUser.Location = new Point(3, 3);
            pnlUser.Name = "pnlUser";
            pnlUser.RowCount = 2;
            pnlUser.RowStyles.Add(new RowStyle());
            pnlUser.RowStyles.Add(new RowStyle());
            pnlUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlUser.Size = new Size(204, 163);
            pnlUser.TabIndex = 2;
            pnlUser.MouseEnter += pnlUser_MouseEnter;
            pnlUser.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // picUser
            // 
            picUser.Dock = DockStyle.Fill;
            picUser.Image = Properties.Resources.user_icon;
            picUser.InitialImage = (Image)resources.GetObject("picUser.InitialImage");
            picUser.Location = new Point(4, 4);
            picUser.Margin = new Padding(4);
            picUser.Name = "picUser";
            picUser.Size = new Size(48, 48);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 1;
            picUser.TabStop = false;
            // 
            // pnlSlideMenu
            // 
            pnlSlideMenu.BackColor = SystemColors.ControlDark;
            pnlSlideMenu.ColumnCount = 1;
            pnlUser.SetColumnSpan(pnlSlideMenu, 2);
            pnlSlideMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSlideMenu.Controls.Add(lblChangeProfile, 0, 0);
            pnlSlideMenu.Controls.Add(lblHelp, 0, 1);
            pnlSlideMenu.Controls.Add(lblExit, 0, 2);
            pnlSlideMenu.Location = new Point(0, 56);
            pnlSlideMenu.Margin = new Padding(0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Padding = new Padding(52, 0, 0, 0);
            pnlSlideMenu.RowCount = 3;
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSlideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlSlideMenu.Size = new Size(204, 107);
            pnlSlideMenu.TabIndex = 6;
            pnlSlideMenu.Visible = false;
            pnlSlideMenu.MouseLeave += HideSlideMenuOnMouseLeave;
            // 
            // lblChangeProfile
            // 
            lblChangeProfile.Cursor = Cursors.Hand;
            lblChangeProfile.Dock = DockStyle.Fill;
            lblChangeProfile.Location = new Point(60, 4);
            lblChangeProfile.Margin = new Padding(8, 4, 8, 4);
            lblChangeProfile.Name = "lblChangeProfile";
            lblChangeProfile.Size = new Size(136, 27);
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
            lblHelp.Size = new Size(136, 27);
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
            lblExit.Size = new Size(136, 29);
            lblExit.TabIndex = 6;
            lblExit.Text = "Выйти";
            lblExit.Click += lblExit_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Left;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(60, 0);
            lblUser.Margin = new Padding(4, 0, 0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(111, 56);
            lblUser.TabIndex = 0;
            lblUser.Text = "Пользователь";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFormContent
            // 
            pnlFormContent.AutoSize = true;
            pnlFormContent.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            pnlFormContent.ColumnCount = 1;
            pnlFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormContent.Controls.Add(pnlHeader, 0, 0);
            pnlFormContent.Controls.Add(ContentTagPanel, 0, 1);
            pnlFormContent.Controls.Add(ContentRecContainer, 0, 4);
            pnlFormContent.Controls.Add(tableLayoutPanel1, 0, 2);
            pnlFormContent.Dock = DockStyle.Fill;
            pnlFormContent.Location = new Point(0, 0);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.RowCount = 5;
            pnlFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            pnlFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            pnlFormContent.RowStyles.Add(new RowStyle());
            pnlFormContent.RowStyles.Add(new RowStyle());
            pnlFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlFormContent.Size = new Size(841, 465);
            pnlFormContent.TabIndex = 2;
            // 
            // ContentTagPanel
            // 
            ContentTagPanel.AutoSize = true;
            ContentTagPanel.Controls.Add(pnlTags);
            ContentTagPanel.Dock = DockStyle.Fill;
            ContentTagPanel.Location = new Point(2, 60);
            ContentTagPanel.Margin = new Padding(0);
            ContentTagPanel.Name = "ContentTagPanel";
            ContentTagPanel.Size = new Size(837, 58);
            ContentTagPanel.TabIndex = 1;
            // 
            // pnlTags
            // 
            pnlTags.AutoScroll = true;
            pnlTags.Dock = DockStyle.Fill;
            pnlTags.Location = new Point(0, 0);
            pnlTags.Margin = new Padding(0);
            pnlTags.Name = "pnlTags";
            pnlTags.Size = new Size(837, 58);
            pnlTags.TabIndex = 3;
            pnlTags.WrapContents = false;
            // 
            // ContentRecContainer
            // 
            ContentRecContainer.Controls.Add(btnAddRecipe);
            ContentRecContainer.Controls.Add(pnlRecipes);
            ContentRecContainer.Dock = DockStyle.Fill;
            ContentRecContainer.Location = new Point(2, 166);
            ContentRecContainer.Margin = new Padding(0);
            ContentRecContainer.Name = "ContentRecContainer";
            ContentRecContainer.Size = new Size(837, 297);
            ContentRecContainer.TabIndex = 13;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRecipe.Location = new Point(728, 213);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(70, 70);
            btnAddRecipe.TabIndex = 0;
            btnAddRecipe.Text = "➕";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // pnlRecipes
            // 
            pnlRecipes.AutoScroll = true;
            pnlRecipes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRecipes.ColumnCount = 4;
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlRecipes.Dock = DockStyle.Fill;
            pnlRecipes.Location = new Point(0, 0);
            pnlRecipes.Margin = new Padding(0);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.RowCount = 5;
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            pnlRecipes.Size = new Size(837, 297);
            pnlRecipes.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.Controls.Add(cboContentSort, 3, 0);
            tableLayoutPanel1.Controls.Add(lblSortBy, 2, 0);
            tableLayoutPanel1.Controls.Add(btnShoppingList, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 123);
            tableLayoutPanel1.Margin = new Padding(8, 3, 29, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 36);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // cboContentSort
            // 
            cboContentSort.Dock = DockStyle.Fill;
            cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContentSort.Location = new Point(656, 3);
            cboContentSort.Name = "cboContentSort";
            cboContentSort.Size = new Size(141, 28);
            cboContentSort.TabIndex = 1;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Dock = DockStyle.Fill;
            lblSortBy.Location = new Point(526, 0);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(124, 36);
            lblSortBy.TabIndex = 2;
            lblSortBy.Text = "Сортировать по:";
            lblSortBy.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnShoppingList
            // 
            btnShoppingList.AutoSize = true;
            btnShoppingList.Location = new Point(3, 3);
            btnShoppingList.Name = "btnShoppingList";
            btnShoppingList.Size = new Size(140, 30);
            btnShoppingList.TabIndex = 3;
            btnShoppingList.Text = "Список покупок";
            btnShoppingList.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(841, 465);
            Controls.Add(pnlUser);
            Controls.Add(pnlFormContent);
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "Книга рецептов";
            Load += MainForm_Load;
            MouseLeave += HideSlideMenuOnMouseLeave;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlSlideMenu.ResumeLayout(false);
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ContentTagPanel.ResumeLayout(false);
            ContentRecContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlSearch;
        private PictureBox picUser;
        private Label lblUser;
        private Label lblSortBy;
        private TextBox txtSearch;
        private TableLayoutPanel pnlUser;
        private TableLayoutPanel pnlFormContent;
        private ComboBox cboContentSort;
        private TableLayoutPanel pnlSlideMenu;
        private Label lblExit;
        private Label lblHelp;
        private Label lblChangeProfile;
        private Panel ContentRecContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnShoppingList;
        private Button btnAddRecipe;
        private TableLayoutPanel pnlRecipes;
        private Panel ContentTagPanel;
        private FlowLayoutPanel pnlTags;
    }
}
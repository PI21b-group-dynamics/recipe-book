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
            ContentHeaderPanel = new Panel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            UserLayoutPanel = new TableLayoutPanel();
            picUser = new PictureBox();
            UserSlideLayoutPanel = new TableLayoutPanel();
            lblChangeProfile = new Label();
            lblHelp = new Label();
            lblExit = new Label();
            lblUser = new Label();
            lblShoppingList = new Label();
            ContentTagPanel = new Panel();
            ContentTagFlowPanel = new FlowLayoutPanel();
            ContentLayoutPanel = new TableLayoutPanel();
            ContentRecContainer = new Panel();
            btnAddRecipe = new Button();
            ContentRecPanel = new TableLayoutPanel();
            ContentSortPanel = new Panel();
            cboContentSort = new ComboBox();
            ContentSortLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            ContentHeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            UserLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            UserSlideLayoutPanel.SuspendLayout();
            ContentTagPanel.SuspendLayout();
            ContentLayoutPanel.SuspendLayout();
            ContentRecContainer.SuspendLayout();
            ContentSortPanel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // ContentHeaderPanel
            // 
            ContentHeaderPanel.Controls.Add(panel1);
            ContentHeaderPanel.Dock = DockStyle.Fill;
            ContentHeaderPanel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ContentHeaderPanel.Location = new Point(2, 2);
            ContentHeaderPanel.Margin = new Padding(0);
            ContentHeaderPanel.Name = "ContentHeaderPanel";
            ContentHeaderPanel.Size = new Size(837, 48);
            ContentHeaderPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(563, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 48);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 9);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "🔍 Найти...";
            textBox1.Size = new Size(268, 32);
            textBox1.TabIndex = 0;
            // 
            // UserLayoutPanel
            // 
            UserLayoutPanel.AutoSize = true;
            UserLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UserLayoutPanel.ColumnCount = 2;
            UserLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            UserLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            UserLayoutPanel.Controls.Add(picUser, 0, 0);
            UserLayoutPanel.Controls.Add(UserSlideLayoutPanel, 0, 2);
            UserLayoutPanel.Controls.Add(lblUser, 1, 0);
            UserLayoutPanel.Controls.Add(lblShoppingList, 0, 1);
            UserLayoutPanel.Location = new Point(3, 3);
            UserLayoutPanel.Name = "UserLayoutPanel";
            UserLayoutPanel.RowCount = 3;
            UserLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            UserLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            UserLayoutPanel.RowStyles.Add(new RowStyle());
            UserLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            UserLayoutPanel.Size = new Size(204, 144);
            UserLayoutPanel.TabIndex = 2;
            UserLayoutPanel.MouseEnter += UserLayoutPanel_MouseEnter;
            UserLayoutPanel.MouseLeave += UserLayoutPanel_MouseLeave;
            // 
            // UserPictureBox
            // 
            picUser.Dock = DockStyle.Fill;
            picUser.Image = Properties.Resources.user_icon;
            picUser.InitialImage = (Image)resources.GetObject("UserPictureBox.InitialImage");
            picUser.Location = new Point(4, 4);
            picUser.Margin = new Padding(4);
            picUser.Name = "UserPictureBox";
            UserLayoutPanel.SetRowSpan(picUser, 2);
            picUser.Size = new Size(40, 40);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 1;
            picUser.TabStop = false;
            // 
            // UserSlideLayoutPanel
            // 
            UserSlideLayoutPanel.BackColor = SystemColors.ControlDark;
            UserSlideLayoutPanel.ColumnCount = 1;
            UserLayoutPanel.SetColumnSpan(UserSlideLayoutPanel, 2);
            UserSlideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            UserSlideLayoutPanel.Controls.Add(lblChangeProfile, 0, 0);
            UserSlideLayoutPanel.Controls.Add(lblHelp, 0, 1);
            UserSlideLayoutPanel.Controls.Add(lblExit, 0, 2);
            UserSlideLayoutPanel.Location = new Point(0, 48);
            UserSlideLayoutPanel.Margin = new Padding(0);
            UserSlideLayoutPanel.Name = "UserSlideLayoutPanel";
            UserSlideLayoutPanel.Padding = new Padding(24, 0, 24, 0);
            UserSlideLayoutPanel.RowCount = 3;
            UserSlideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            UserSlideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            UserSlideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            UserSlideLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            UserSlideLayoutPanel.Size = new Size(204, 96);
            UserSlideLayoutPanel.TabIndex = 6;
            UserSlideLayoutPanel.Visible = false;
            UserSlideLayoutPanel.MouseLeave += UserSlideLayoutPanel_MouseLeave;
            // 
            // lblChangeProfile
            // 
            lblChangeProfile.Cursor = Cursors.Hand;
            lblChangeProfile.Dock = DockStyle.Fill;
            lblChangeProfile.Location = new Point(32, 4);
            lblChangeProfile.Margin = new Padding(8, 4, 8, 4);
            lblChangeProfile.Name = "lblChangeProfile";
            lblChangeProfile.Size = new Size(140, 24);
            lblChangeProfile.TabIndex = 4;
            lblChangeProfile.Text = "Редактировать профиль";
            lblChangeProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHelp
            // 
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Dock = DockStyle.Fill;
            lblHelp.Location = new Point(32, 36);
            lblHelp.Margin = new Padding(8, 4, 8, 4);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(140, 24);
            lblHelp.TabIndex = 5;
            lblHelp.Text = "Справка";
            lblHelp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExit
            // 
            lblExit.Cursor = Cursors.Hand;
            lblExit.Dock = DockStyle.Fill;
            lblExit.Location = new Point(32, 68);
            lblExit.Margin = new Padding(8, 4, 8, 4);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(140, 24);
            lblExit.TabIndex = 6;
            lblExit.Text = "Выйти";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            lblExit.Click += lblExit_Click;
            // 
            // UserLabel
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Left;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(52, 8);
            lblUser.Margin = new Padding(4, 8, 4, 0);
            lblUser.Name = "UserLabel";
            lblUser.Size = new Size(123, 16);
            lblUser.TabIndex = 0;
            lblUser.Text = "ИМЯ ПОЛЬЗОВАТЕЛЯ";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblShoppingList
            // 
            lblShoppingList.AutoSize = true;
            lblShoppingList.Cursor = Cursors.Hand;
            lblShoppingList.Dock = DockStyle.Left;
            lblShoppingList.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblShoppingList.Location = new Point(52, 24);
            lblShoppingList.Margin = new Padding(4, 0, 4, 8);
            lblShoppingList.Name = "lblShoppingList";
            lblShoppingList.Size = new Size(120, 16);
            lblShoppingList.TabIndex = 0;
            lblShoppingList.Text = "Список покупок";
            lblShoppingList.TextAlign = ContentAlignment.MiddleLeft;
            lblShoppingList.Click += lblShoppingList_Click;
            // 
            // ContentTagPanel
            // 
            ContentTagPanel.AutoSize = true;
            ContentTagPanel.Controls.Add(ContentTagFlowPanel);
            ContentTagPanel.Dock = DockStyle.Fill;
            ContentTagPanel.Location = new Point(2, 52);
            ContentTagPanel.Margin = new Padding(0);
            ContentTagPanel.Name = "ContentTagPanel";
            ContentTagPanel.Size = new Size(837, 48);
            ContentTagPanel.TabIndex = 1;
            // 
            // ContentTagFlowPanel
            // 
            ContentTagFlowPanel.AutoScroll = true;
            ContentTagFlowPanel.AutoSize = true;
            ContentTagFlowPanel.Dock = DockStyle.Fill;
            ContentTagFlowPanel.Location = new Point(0, 0);
            ContentTagFlowPanel.Margin = new Padding(0);
            ContentTagFlowPanel.Name = "ContentTagFlowPanel";
            ContentTagFlowPanel.Size = new Size(837, 48);
            ContentTagFlowPanel.TabIndex = 3;
            ContentTagFlowPanel.WrapContents = false;
            // 
            // ContentLayoutPanel
            // 
            ContentLayoutPanel.AutoSize = true;
            ContentLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            ContentLayoutPanel.ColumnCount = 1;
            ContentLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ContentLayoutPanel.Controls.Add(ContentHeaderPanel, 0, 0);
            ContentLayoutPanel.Controls.Add(ContentTagPanel, 0, 1);
            ContentLayoutPanel.Controls.Add(ContentRecContainer, 0, 4);
            ContentLayoutPanel.Controls.Add(ContentSortPanel, 0, 2);
            ContentLayoutPanel.Dock = DockStyle.Fill;
            ContentLayoutPanel.Location = new Point(0, 0);
            ContentLayoutPanel.Name = "ContentLayoutPanel";
            ContentLayoutPanel.RowCount = 5;
            ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            ContentLayoutPanel.RowStyles.Add(new RowStyle());
            ContentLayoutPanel.RowStyles.Add(new RowStyle());
            ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ContentLayoutPanel.Size = new Size(841, 465);
            ContentLayoutPanel.TabIndex = 2;
            // 
            // ContentRecContainer
            // 
            ContentRecContainer.Controls.Add(btnAddRecipe);
            ContentRecContainer.Controls.Add(ContentRecPanel);
            ContentRecContainer.Dock = DockStyle.Fill;
            ContentRecContainer.Location = new Point(2, 140);
            ContentRecContainer.Margin = new Padding(0);
            ContentRecContainer.Name = "ContentRecContainer";
            ContentRecContainer.Size = new Size(837, 323);
            ContentRecContainer.TabIndex = 13;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRecipe.BackColor = Color.LightGray;
            btnAddRecipe.Cursor = Cursors.Hand;
            btnAddRecipe.FlatAppearance.BorderSize = 0;
            btnAddRecipe.FlatStyle = FlatStyle.Flat;
            btnAddRecipe.Location = new Point(751, 247);
            btnAddRecipe.Margin = new Padding(12);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(64, 64);
            btnAddRecipe.TabIndex = 0;
            btnAddRecipe.Text = "➕";
            btnAddRecipe.UseVisualStyleBackColor = false;
            // 
            // ContentRecPanel
            // 
            ContentRecPanel.AutoScroll = true;
            ContentRecPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContentRecPanel.ColumnCount = 4;
            ContentRecPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ContentRecPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ContentRecPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ContentRecPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ContentRecPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ContentRecPanel.Dock = DockStyle.Fill;
            ContentRecPanel.Location = new Point(0, 0);
            ContentRecPanel.Margin = new Padding(0);
            ContentRecPanel.Name = "ContentRecPanel";
            ContentRecPanel.RowCount = 5;
            ContentRecPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            ContentRecPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            ContentRecPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            ContentRecPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            ContentRecPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            ContentRecPanel.Size = new Size(837, 323);
            ContentRecPanel.TabIndex = 3;
            // 
            // ContentSortPanel
            // 
            ContentSortPanel.AutoSize = true;
            ContentSortPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContentSortPanel.Controls.Add(cboContentSort);
            ContentSortPanel.Controls.Add(ContentSortLabel);
            ContentSortPanel.Dock = DockStyle.Right;
            ContentSortPanel.Location = new Point(565, 102);
            ContentSortPanel.Margin = new Padding(0);
            ContentSortPanel.Name = "ContentSortPanel";
            ContentSortPanel.Size = new Size(274, 34);
            ContentSortPanel.TabIndex = 2;
            // 
            // ContentSortComboBox
            // 
            cboContentSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboContentSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContentSort.Location = new Point(125, 3);
            cboContentSort.Name = "ContentSortComboBox";
            cboContentSort.Size = new Size(146, 28);
            cboContentSort.TabIndex = 1;
            // 
            // ContentSortLabel
            // 
            ContentSortLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContentSortLabel.AutoSize = true;
            ContentSortLabel.Location = new Point(3, 6);
            ContentSortLabel.Name = "ContentSortLabel";
            ContentSortLabel.Size = new Size(124, 20);
            ContentSortLabel.TabIndex = 0;
            ContentSortLabel.Text = "Сортировать по:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(pictureBox4, 0, 1);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.SetColumnSpan(pictureBox4, 2);
            pictureBox4.Location = new Point(1, 22);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(198, 77);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(4, 4);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(103, 14);
            label5.TabIndex = 2;
            label5.Text = "Рецепт 1";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(pictureBox6, 0, 1);
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.SetColumnSpan(pictureBox6, 2);
            pictureBox6.Location = new Point(1, 22);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(198, 77);
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(4, 4);
            label7.Margin = new Padding(3);
            label7.Name = "label7";
            label7.Size = new Size(103, 14);
            label7.TabIndex = 2;
            label7.Text = "Рецепт 1";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(841, 465);
            Controls.Add(UserLayoutPanel);
            Controls.Add(ContentLayoutPanel);
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            MouseLeave += MainForm_MouseLeave;
            ContentHeaderPanel.ResumeLayout(false);
            ContentHeaderPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            UserLayoutPanel.ResumeLayout(false);
            UserLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            UserSlideLayoutPanel.ResumeLayout(false);
            ContentTagPanel.ResumeLayout(false);
            ContentTagPanel.PerformLayout();
            ContentLayoutPanel.ResumeLayout(false);
            ContentLayoutPanel.PerformLayout();
            ContentRecContainer.ResumeLayout(false);
            ContentSortPanel.ResumeLayout(false);
            ContentSortPanel.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ContentHeaderPanel;
        private PictureBox picUser;
        private Label lblUser;
        private TableLayoutPanel UserLayoutPanel;
        private Label lblShoppingList;
        private Panel ContentTagPanel;
        private TableLayoutPanel ContentLayoutPanel;
        private FlowLayoutPanel ContentTagFlowPanel;
        private Panel ContentSortPanel;
        private ComboBox cboContentSort;
        private Label ContentSortLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox6;
        private Label label7;
        private TableLayoutPanel UserSlideLayoutPanel;
        private Label lblExit;
        private Label lblHelp;
        private Label lblChangeProfile;
        private TableLayoutPanel ContentRecPanel;
        private Button btnAddRecipe;
        private Panel ContentRecContainer;
        private TextBox textBox1;
        private Panel panel1;
    }
}
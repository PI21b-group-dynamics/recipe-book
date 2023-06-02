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
            pnlUser = new TableLayoutPanel();
            picUser = new PictureBox();
            pnlSlideMenu = new TableLayoutPanel();
            lblChangeProfile = new Label();
            lblHelp = new Label();
            lblExit = new Label();
            lblUser = new Label();
            ContentTagPanel = new Panel();
            pnlTags = new FlowLayoutPanel();
            pnlFormContent = new TableLayoutPanel();
            ContentRecContainer = new Panel();
            roundButton1 = new RoundButton();
            pnlRecipes = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboContentSort = new ComboBox();
            label1 = new Label();
            btnShoppingList = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            ContentHeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlSlideMenu.SuspendLayout();
            ContentTagPanel.SuspendLayout();
            pnlFormContent.SuspendLayout();
            ContentRecContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            ContentHeaderPanel.Size = new Size(837, 56);
            ContentHeaderPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(563, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 56);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "🔍 Найти...";
            textBox1.Size = new Size(268, 32);
            textBox1.TabIndex = 0;
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
            pnlUser.MouseLeave += pnlUser_MouseLeave;
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
            pnlSlideMenu.MouseLeave += pnlSlideMenu_MouseLeave;
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
            // pnlFormContent
            // 
            pnlFormContent.AutoSize = true;
            pnlFormContent.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            pnlFormContent.ColumnCount = 1;
            pnlFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormContent.Controls.Add(ContentHeaderPanel, 0, 0);
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
            pnlFormContent.Size = new Size(841, 465);
            pnlFormContent.TabIndex = 2;
            // 
            // ContentRecContainer
            // 
            ContentRecContainer.Controls.Add(roundButton1);
            ContentRecContainer.Controls.Add(pnlRecipes);
            ContentRecContainer.Dock = DockStyle.Fill;
            ContentRecContainer.Location = new Point(2, 166);
            ContentRecContainer.Margin = new Padding(0);
            ContentRecContainer.Name = "ContentRecContainer";
            ContentRecContainer.Size = new Size(837, 297);
            ContentRecContainer.TabIndex = 13;
            // 
            // roundButton1
            // 
            roundButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundButton1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            roundButton1.Location = new Point(742, 207);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(70, 70);
            roundButton1.TabIndex = 0;
            roundButton1.Text = "➕";
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
            pnlRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlRecipes.Dock = DockStyle.Fill;
            pnlRecipes.Location = new Point(0, 0);
            pnlRecipes.Margin = new Padding(0);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.RowCount = 5;
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            pnlRecipes.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            pnlRecipes.Size = new Size(837, 297);
            pnlRecipes.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.Controls.Add(cboContentSort, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(526, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 36);
            label1.TabIndex = 2;
            label1.Text = "Сортировать по:";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            Controls.Add(pnlUser);
            Controls.Add(pnlFormContent);
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            MouseLeave += MainForm_MouseLeave;
            ContentHeaderPanel.ResumeLayout(false);
            ContentHeaderPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlSlideMenu.ResumeLayout(false);
            ContentTagPanel.ResumeLayout(false);
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ContentRecContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel pnlUser;
        private Panel ContentTagPanel;
        private TableLayoutPanel pnlFormContent;
        private FlowLayoutPanel pnlTags;
        private ComboBox cboContentSort;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox6;
        private Label label7;
        private TableLayoutPanel pnlSlideMenu;
        private Label lblExit;
        private Label lblHelp;
        private Label lblChangeProfile;
        private Panel ContentRecContainer;
        private TextBox textBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btnShoppingList;
        private RoundButton roundButton1;
        private TableLayoutPanel pnlRecipes;
    }
}
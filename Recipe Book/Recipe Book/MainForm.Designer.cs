namespace Recipe_Book
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
			ContentHeaderSearchPanel = new Panel();
			ContentHeaderSearchPB = new PictureBox();
			ContentHeaderSearchTB = new TextBox();
			UserLayoutPanel = new TableLayoutPanel();
			UserPictureBox = new PictureBox();
			UserSlideLayoutPanel = new TableLayoutPanel();
			LabelChangeProfile = new Label();
			LabelHelp = new Label();
			LabelExit = new Label();
			UserLabel = new Label();
			BuyListLabel = new Label();
			ContentTagPanel = new Panel();
			ContentTagFlowPanel = new FlowLayoutPanel();
			ContentLayoutPanel = new TableLayoutPanel();
			ContentSortPanel = new Panel();
			ContentSortComboBox = new ComboBox();
			ContentSortLabel = new Label();
			ContentRecContainer = new Panel();
			AddRecipeButton = new Button();
			ContentRecPanel = new TableLayoutPanel();
			tableLayoutPanel4 = new TableLayoutPanel();
			pictureBox4 = new PictureBox();
			label5 = new Label();
			tableLayoutPanel7 = new TableLayoutPanel();
			pictureBox6 = new PictureBox();
			label7 = new Label();
			ContentHeaderPanel.SuspendLayout();
			ContentHeaderSearchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ContentHeaderSearchPB).BeginInit();
			UserLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
			UserSlideLayoutPanel.SuspendLayout();
			ContentTagPanel.SuspendLayout();
			ContentLayoutPanel.SuspendLayout();
			ContentSortPanel.SuspendLayout();
			ContentRecContainer.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			tableLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// ContentHeaderPanel
			// 
			ContentHeaderPanel.Controls.Add(ContentHeaderSearchPanel);
			ContentHeaderPanel.Dock = DockStyle.Fill;
			ContentHeaderPanel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			ContentHeaderPanel.Location = new Point(2, 2);
			ContentHeaderPanel.Margin = new Padding(0);
			ContentHeaderPanel.Name = "ContentHeaderPanel";
			ContentHeaderPanel.Size = new Size(580, 48);
			ContentHeaderPanel.TabIndex = 0;
			// 
			// ContentHeaderSearchPanel
			// 
			ContentHeaderSearchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ContentHeaderSearchPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ContentHeaderSearchPanel.BackColor = SystemColors.Window;
			ContentHeaderSearchPanel.BorderStyle = BorderStyle.FixedSingle;
			ContentHeaderSearchPanel.Controls.Add(ContentHeaderSearchPB);
			ContentHeaderSearchPanel.Controls.Add(ContentHeaderSearchTB);
			ContentHeaderSearchPanel.Location = new Point(390, 14);
			ContentHeaderSearchPanel.Margin = new Padding(3, 14, 3, 14);
			ContentHeaderSearchPanel.Name = "ContentHeaderSearchPanel";
			ContentHeaderSearchPanel.Size = new Size(180, 22);
			ContentHeaderSearchPanel.TabIndex = 5;
			// 
			// ContentHeaderSearchPB
			// 
			ContentHeaderSearchPB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			ContentHeaderSearchPB.Image = Properties.Resources.search_icon;
			ContentHeaderSearchPB.InitialImage = (Image)resources.GetObject("ContentHeaderSearchPB.InitialImage");
			ContentHeaderSearchPB.Location = new Point(2, 2);
			ContentHeaderSearchPB.Margin = new Padding(2);
			ContentHeaderSearchPB.Name = "ContentHeaderSearchPB";
			ContentHeaderSearchPB.Size = new Size(16, 16);
			ContentHeaderSearchPB.SizeMode = PictureBoxSizeMode.StretchImage;
			ContentHeaderSearchPB.TabIndex = 4;
			ContentHeaderSearchPB.TabStop = false;
			// 
			// ContentHeaderSearchTB
			// 
			ContentHeaderSearchTB.BorderStyle = BorderStyle.None;
			ContentHeaderSearchTB.Dock = DockStyle.Right;
			ContentHeaderSearchTB.Location = new Point(25, 0);
			ContentHeaderSearchTB.Margin = new Padding(0);
			ContentHeaderSearchTB.Name = "ContentHeaderSearchTB";
			ContentHeaderSearchTB.PlaceholderText = "Найти...";
			ContentHeaderSearchTB.Size = new Size(153, 20);
			ContentHeaderSearchTB.TabIndex = 3;
			// 
			// UserLayoutPanel
			// 
			UserLayoutPanel.AutoSize = true;
			UserLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			UserLayoutPanel.ColumnCount = 2;
			UserLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
			UserLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
			UserLayoutPanel.Controls.Add(UserPictureBox, 0, 0);
			UserLayoutPanel.Controls.Add(UserSlideLayoutPanel, 0, 2);
			UserLayoutPanel.Controls.Add(UserLabel, 1, 0);
			UserLayoutPanel.Controls.Add(BuyListLabel, 0, 1);
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
			UserPictureBox.Dock = DockStyle.Fill;
			UserPictureBox.Image = Properties.Resources.user_icon;
			UserPictureBox.InitialImage = (Image)resources.GetObject("UserPictureBox.InitialImage");
			UserPictureBox.Location = new Point(4, 4);
			UserPictureBox.Margin = new Padding(4);
			UserPictureBox.Name = "UserPictureBox";
			UserLayoutPanel.SetRowSpan(UserPictureBox, 2);
			UserPictureBox.Size = new Size(40, 40);
			UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			UserPictureBox.TabIndex = 1;
			UserPictureBox.TabStop = false;
			// 
			// UserSlideLayoutPanel
			// 
			UserSlideLayoutPanel.BackColor = SystemColors.ControlDark;
			UserSlideLayoutPanel.ColumnCount = 1;
			UserLayoutPanel.SetColumnSpan(UserSlideLayoutPanel, 2);
			UserSlideLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			UserSlideLayoutPanel.Controls.Add(LabelChangeProfile, 0, 0);
			UserSlideLayoutPanel.Controls.Add(LabelHelp, 0, 1);
			UserSlideLayoutPanel.Controls.Add(LabelExit, 0, 2);
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
			// LabelChangeProfile
			// 
			LabelChangeProfile.Cursor = Cursors.Hand;
			LabelChangeProfile.Dock = DockStyle.Fill;
			LabelChangeProfile.Location = new Point(32, 4);
			LabelChangeProfile.Margin = new Padding(8, 4, 8, 4);
			LabelChangeProfile.Name = "LabelChangeProfile";
			LabelChangeProfile.Size = new Size(140, 24);
			LabelChangeProfile.TabIndex = 4;
			LabelChangeProfile.Text = "Редактировать профиль";
			LabelChangeProfile.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LabelHelp
			// 
			LabelHelp.Cursor = Cursors.Hand;
			LabelHelp.Dock = DockStyle.Fill;
			LabelHelp.Location = new Point(32, 36);
			LabelHelp.Margin = new Padding(8, 4, 8, 4);
			LabelHelp.Name = "LabelHelp";
			LabelHelp.Size = new Size(140, 24);
			LabelHelp.TabIndex = 5;
			LabelHelp.Text = "Справка";
			LabelHelp.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LabelExit
			// 
			LabelExit.Cursor = Cursors.Hand;
			LabelExit.Dock = DockStyle.Fill;
			LabelExit.Location = new Point(32, 68);
			LabelExit.Margin = new Padding(8, 4, 8, 4);
			LabelExit.Name = "LabelExit";
			LabelExit.Size = new Size(140, 24);
			LabelExit.TabIndex = 6;
			LabelExit.Text = "Выйти";
			LabelExit.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// UserLabel
			// 
			UserLabel.AutoSize = true;
			UserLabel.Dock = DockStyle.Left;
			UserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			UserLabel.Location = new Point(52, 8);
			UserLabel.Margin = new Padding(4, 8, 4, 0);
			UserLabel.Name = "UserLabel";
			UserLabel.Size = new Size(128, 16);
			UserLabel.TabIndex = 0;
			UserLabel.Text = "ИМЯ ПОЛЬЗОВАТЕЛЯ";
			UserLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// BuyListLabel
			// 
			BuyListLabel.AutoSize = true;
			BuyListLabel.Cursor = Cursors.Hand;
			BuyListLabel.Dock = DockStyle.Left;
			BuyListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
			BuyListLabel.Location = new Point(52, 24);
			BuyListLabel.Margin = new Padding(4, 0, 4, 8);
			BuyListLabel.Name = "BuyListLabel";
			BuyListLabel.Size = new Size(97, 16);
			BuyListLabel.TabIndex = 0;
			BuyListLabel.Text = "Список покупок";
			BuyListLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// ContentTagPanel
			// 
			ContentTagPanel.AutoSize = true;
			ContentTagPanel.Controls.Add(ContentTagFlowPanel);
			ContentTagPanel.Dock = DockStyle.Fill;
			ContentTagPanel.Location = new Point(2, 52);
			ContentTagPanel.Margin = new Padding(0);
			ContentTagPanel.Name = "ContentTagPanel";
			ContentTagPanel.Size = new Size(580, 48);
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
			ContentTagFlowPanel.Size = new Size(580, 48);
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
			ContentLayoutPanel.Controls.Add(ContentSortPanel, 0, 2);
			ContentLayoutPanel.Controls.Add(ContentRecContainer, 0, 4);
			ContentLayoutPanel.Dock = DockStyle.Fill;
			ContentLayoutPanel.Location = new Point(0, 0);
			ContentLayoutPanel.Name = "ContentLayoutPanel";
			ContentLayoutPanel.RowCount = 5;
			ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
			ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
			ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
			ContentLayoutPanel.RowStyles.Add(new RowStyle());
			ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			ContentLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			ContentLayoutPanel.Size = new Size(584, 361);
			ContentLayoutPanel.TabIndex = 2;
			// 
			// ContentSortPanel
			// 
			ContentSortPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ContentSortPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ContentSortPanel.Controls.Add(ContentSortComboBox);
			ContentSortPanel.Controls.Add(ContentSortLabel);
			ContentSortPanel.Location = new Point(345, 102);
			ContentSortPanel.Margin = new Padding(0);
			ContentSortPanel.Name = "ContentSortPanel";
			ContentSortPanel.Size = new Size(237, 29);
			ContentSortPanel.TabIndex = 2;
			// 
			// ContentSortComboBox
			// 
			ContentSortComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ContentSortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			ContentSortComboBox.Location = new Point(113, 3);
			ContentSortComboBox.Name = "ContentSortComboBox";
			ContentSortComboBox.Size = new Size(121, 23);
			ContentSortComboBox.TabIndex = 1;
			// 
			// ContentSortLabel
			// 
			ContentSortLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ContentSortLabel.AutoSize = true;
			ContentSortLabel.Location = new Point(9, 6);
			ContentSortLabel.Name = "ContentSortLabel";
			ContentSortLabel.Size = new Size(98, 15);
			ContentSortLabel.TabIndex = 0;
			ContentSortLabel.Text = "Сортировать по:";
			// 
			// ContentRecContainer
			// 
			ContentRecContainer.Controls.Add(AddRecipeButton);
			ContentRecContainer.Controls.Add(ContentRecPanel);
			ContentRecContainer.Dock = DockStyle.Fill;
			ContentRecContainer.Location = new Point(2, 135);
			ContentRecContainer.Margin = new Padding(0);
			ContentRecContainer.Name = "ContentRecContainer";
			ContentRecContainer.Size = new Size(580, 224);
			ContentRecContainer.TabIndex = 13;
			// 
			// AddRecipeButton
			// 
			AddRecipeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			AddRecipeButton.BackColor = Color.LightGray;
			AddRecipeButton.Cursor = Cursors.Hand;
			AddRecipeButton.FlatAppearance.BorderSize = 0;
			AddRecipeButton.FlatStyle = FlatStyle.Flat;
			AddRecipeButton.Location = new Point(526, 180);
			AddRecipeButton.Margin = new Padding(12);
			AddRecipeButton.Name = "AddRecipeButton";
			AddRecipeButton.Size = new Size(32, 32);
			AddRecipeButton.TabIndex = 0;
			AddRecipeButton.Text = "+";
			AddRecipeButton.UseVisualStyleBackColor = false;
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
			ContentRecPanel.Size = new Size(580, 224);
			ContentRecPanel.TabIndex = 3;
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
			ClientSize = new Size(584, 361);
			Controls.Add(UserLayoutPanel);
			Controls.Add(ContentLayoutPanel);
			MinimumSize = new Size(600, 400);
			Name = "MainForm";
			Text = "Главная форма";
			MouseLeave += MainForm_MouseLeave;
			ContentHeaderPanel.ResumeLayout(false);
			ContentHeaderSearchPanel.ResumeLayout(false);
			ContentHeaderSearchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ContentHeaderSearchPB).EndInit();
			UserLayoutPanel.ResumeLayout(false);
			UserLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
			UserSlideLayoutPanel.ResumeLayout(false);
			ContentTagPanel.ResumeLayout(false);
			ContentTagPanel.PerformLayout();
			ContentLayoutPanel.ResumeLayout(false);
			ContentLayoutPanel.PerformLayout();
			ContentSortPanel.ResumeLayout(false);
			ContentSortPanel.PerformLayout();
			ContentRecContainer.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			tableLayoutPanel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel ContentHeaderPanel;
		private PictureBox UserPictureBox;
		private Label UserLabel;
		private TableLayoutPanel UserLayoutPanel;
		private Label BuyListLabel;
		private Panel ContentHeaderSearchPanel;
		private PictureBox ContentHeaderSearchPB;
		private TextBox ContentHeaderSearchTB;
		private Panel ContentTagPanel;
		private TableLayoutPanel ContentLayoutPanel;
		private FlowLayoutPanel ContentTagFlowPanel;
		private Panel ContentSortPanel;
		private ComboBox ContentSortComboBox;
		private Label ContentSortLabel;
		private TableLayoutPanel tableLayoutPanel4;
		private PictureBox pictureBox4;
		private Label label5;
		private TableLayoutPanel tableLayoutPanel7;
		private PictureBox pictureBox6;
		private Label label7;
		private TableLayoutPanel UserSlideLayoutPanel;
		private Label LabelExit;
		private Label LabelHelp;
		private Label LabelChangeProfile;
		private TableLayoutPanel ContentRecPanel;
		private Button AddRecipeButton;
		private Panel ContentRecContainer;
	}
}
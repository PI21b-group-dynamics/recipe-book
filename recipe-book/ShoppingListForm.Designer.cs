namespace recipe_book
{
    partial class ShoppingListForm
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
            ingredientInp = new TextBox();
            addIngredientBtn = new Button();
            ingredientPanel = new TableLayoutPanel();
            clearShoppingListBtn = new Button();
            shoppingListPanel = new FlowLayoutPanel();
            ingredientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ingredientInp
            // 
            ingredientInp.Dock = DockStyle.Top;
            ingredientInp.Location = new Point(12, 10);
            ingredientInp.Margin = new Padding(3, 2, 3, 2);
            ingredientInp.Name = "ingredientInp";
            ingredientInp.PlaceholderText = "Введите название ингредиента";
            ingredientInp.Size = new Size(258, 23);
            ingredientInp.TabIndex = 0;
            ingredientInp.TextChanged += ingredientInp_TextChanged;
            ingredientInp.KeyPress += ingredientInp_KeyPress;
            // 
            // addIngredientBtn
            // 
            addIngredientBtn.AutoSize = true;
            addIngredientBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addIngredientBtn.Enabled = false;
            addIngredientBtn.Location = new Point(276, 10);
            addIngredientBtn.Margin = new Padding(3, 2, 3, 2);
            addIngredientBtn.Name = "addIngredientBtn";
            addIngredientBtn.Size = new Size(29, 25);
            addIngredientBtn.TabIndex = 1;
            addIngredientBtn.Text = "➕";
            addIngredientBtn.UseVisualStyleBackColor = true;
            addIngredientBtn.Click += addIngredientBtn_Click;
            // 
            // ingredientPanel
            // 
            ingredientPanel.ColumnCount = 2;
            ingredientPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ingredientPanel.ColumnStyles.Add(new ColumnStyle());
            ingredientPanel.Controls.Add(addIngredientBtn, 1, 0);
            ingredientPanel.Controls.Add(ingredientInp, 0, 0);
            ingredientPanel.Controls.Add(clearShoppingListBtn, 0, 2);
            ingredientPanel.Controls.Add(shoppingListPanel, 0, 1);
            ingredientPanel.Dock = DockStyle.Fill;
            ingredientPanel.Location = new Point(0, 0);
            ingredientPanel.Margin = new Padding(3, 2, 3, 2);
            ingredientPanel.Name = "ingredientPanel";
            ingredientPanel.Padding = new Padding(9, 8, 9, 8);
            ingredientPanel.RowCount = 3;
            ingredientPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            ingredientPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ingredientPanel.RowStyles.Add(new RowStyle());
            ingredientPanel.Size = new Size(317, 338);
            ingredientPanel.TabIndex = 2;
            // 
            // clearShoppingListBtn
            // 
            clearShoppingListBtn.AutoSize = true;
            clearShoppingListBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ingredientPanel.SetColumnSpan(clearShoppingListBtn, 2);
            clearShoppingListBtn.Dock = DockStyle.Bottom;
            clearShoppingListBtn.Enabled = false;
            clearShoppingListBtn.Location = new Point(12, 303);
            clearShoppingListBtn.Margin = new Padding(3, 2, 3, 2);
            clearShoppingListBtn.Name = "clearShoppingListBtn";
            clearShoppingListBtn.Size = new Size(293, 25);
            clearShoppingListBtn.TabIndex = 2;
            clearShoppingListBtn.Text = "Очистить список";
            clearShoppingListBtn.UseVisualStyleBackColor = true;
            clearShoppingListBtn.Click += clearShoppingListBtn_Click;
            // 
            // shoppingListPanel
            // 
            shoppingListPanel.AutoScroll = true;
            ingredientPanel.SetColumnSpan(shoppingListPanel, 2);
            shoppingListPanel.Dock = DockStyle.Fill;
            shoppingListPanel.FlowDirection = FlowDirection.TopDown;
            shoppingListPanel.Location = new Point(12, 40);
            shoppingListPanel.Margin = new Padding(3, 2, 3, 2);
            shoppingListPanel.Name = "shoppingListPanel";
            shoppingListPanel.Size = new Size(293, 259);
            shoppingListPanel.TabIndex = 3;
            shoppingListPanel.WrapContents = false;
            // 
            // ShoppingListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 338);
            Controls.Add(ingredientPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShoppingListForm";
            Text = "Список покупок";
            ingredientPanel.ResumeLayout(false);
            ingredientPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox ingredientInp;
        private Button addIngredientBtn;
        private TableLayoutPanel ingredientPanel;
        private Button clearShoppingListBtn;
        private FlowLayoutPanel shoppingListPanel;
    }
}
namespace recipe_book
{
    public partial class ShoppingListForm : Form
    {
        public ShoppingListForm()
        {
            InitializeComponent();
            addIngredientBtn.Select();
        }

        private void addIngredientBtn_Click(object sender, EventArgs e)
        {
            TableLayoutPanel singleBoughtPanel = new() { RowCount = 1, ColumnCount = 2, CellBorderStyle=TableLayoutPanelCellBorderStyle.OutsetDouble };
            singleBoughtPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            singleBoughtPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            singleBoughtPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Control control = new CheckBox() { Text = ingredientInp.Text, Dock = DockStyle.Top };
            singleBoughtPanel.Controls.Add(control);
            control = new Button() { Text = "❌", AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            control.Click += (sender, e) => {
                shoppingListPanel.Controls.Remove(singleBoughtPanel);
                clearShoppingListBtn.Enabled = shoppingListPanel.Controls.Count > 0;
            };
            singleBoughtPanel.Controls.Add(control);
            shoppingListPanel.Controls.Add(singleBoughtPanel);
            ingredientInp.Clear();
            clearShoppingListBtn.Enabled = true;
        }

        private void ingredientInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && addIngredientBtn.Enabled)
                addIngredientBtn_Click(sender, e);
        }

        private void ingredientInp_TextChanged(object sender, EventArgs e)
        {
            addIngredientBtn.Enabled = ingredientInp.Text.Length > 0;
        }

        private void clearShoppingListBtn_Click(object sender, EventArgs e)
        {
            shoppingListPanel.Controls.Clear();
            clearShoppingListBtn.Enabled = false;
        }
    }
}

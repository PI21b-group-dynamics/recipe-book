using recipe_book.Properties;
using System.Data.SQLite;

namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            new ShoppingListForm();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabCreateOrEditRecipe;
            _previousSelectedTab = tabListOfRecipes;
        }

        private void pnlRecipes_DoubleClick(object sender, EventArgs e)
        {
            _previousSelectedTab = tabListOfRecipes;
            tbcMainFormTabs.SelectedTab = tabRecipeView;

            ListViewItem item = pnlRecipes.SelectedItems[0];
            lblRecipeName.Text = item.Text;
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT cooking_time, rating, photo, cooking_method
                FROM Recipes
                WHERE id = $id
                LIMIT 1
                """,
                new SQLiteParameter("id", Convert.ToInt64(item.Name))
            );
            SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            lblCookingTime.Text = rdr.GetString(0);
            lblRating.Text = $"{rdr.GetInt32(1)} / 10";
            picRecipePhoto.Image = rdr.GetImage(2) ?? Resources.UserIcon;
            lblRecipeCookingMethod.Text = rdr.GetString(3);
        }
    }
}

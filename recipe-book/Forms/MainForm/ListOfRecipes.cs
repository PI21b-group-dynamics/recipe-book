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
            SQLiteParameter recipeIdParam = new("id", Convert.ToInt64(item.Name));
            lblRecipeName.Text = item.Text;
            SQLiteCommand cmd = DbModule.CreateCommand("""
                SELECT cooking_time, rating, photo, cooking_method
                FROM Recipes
                WHERE id = $id
                LIMIT 1
                """,
                recipeIdParam
            );
            SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            TimeSpan ts = new(rdr.GetInt64(0));
            lblCookingTime.Text = $"{ts:hh\\:mm\\:ss}, {ts.Days} дней";
            lblRating.Text = $"{rdr.GetInt32(1)} / 10";
            picRecipeViewPhoto.Image = rdr.GetImage(2) ?? Resources.UserIcon;
            lblRecipeCookingMethod.Text = rdr.GetString(3);

            pnlRecipeViewTags.Controls.Clear();
            pnlRecipeViewIngredients.Controls.Clear();

            cmd = DbModule.CreateCommand("""
                SELECT Tags.name
                FROM RecipeTags
                JOIN Tags ON Tags.id = RecipeTags.tag_id
                WHERE RecipeTags.recipe_id = $id
                """,
                recipeIdParam
            );
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                pnlRecipeViewTags.Controls.Add(new Button()
                {
                    Text = rdr.GetString(0),
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                });

            cmd = DbModule.CreateCommand("""
                SELECT Ingredients.name
                FROM RecipeIngredients
                JOIN Ingredients ON Ingredients.id = RecipeIngredients.ingredient_id
                WHERE RecipeIngredients.recipe_id = $id
                """,
                recipeIdParam
            );
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                pnlRecipeViewIngredients.Controls.Add(new Button()
                {
                    Text = rdr.GetString(0),
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                });
        }
    }
}

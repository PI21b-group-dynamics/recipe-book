namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabListOfRecipes;
            _previousSelectedTab = tabRecipeView;
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabCreateOrEditRecipe;
            _previousSelectedTab = tabRecipeView;
        }
    }
}

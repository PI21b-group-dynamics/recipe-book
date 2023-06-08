using recipe_book.Controls;
using System.Data.SQLite;

namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private void btnCancelCreationOrEdition_Click(object sender, EventArgs e)
        {
            tbcMainFormTabs.SelectedTab = tabListOfRecipes;
            _previousSelectedTab = tabCreateOrEditRecipe;
        }

        private void btnLoadRecipePhoto_Click(object sender, EventArgs e)
        {
            if (dlgLoadRecipePhoto.ShowDialog() == DialogResult.OK)
                try
                {
                    picRecipePhoto.ImageLocation = dlgLoadRecipePhoto.FileName;
                    picRecipePhoto.Visible = true;
                    btnDeleteRecipePhoto.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        caption: "Ошибка добавления фотографии",
                        text: ex.Message,
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                    );
                }
        }

        private void btnDeleteRecipePhoto_Click(object sender, EventArgs e)
        {
            picRecipePhoto.Visible = false;
            picRecipePhoto.Image = null;
            btnDeleteRecipePhoto.Enabled = false;
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            string cookingTime = string.Join(' ',
                numWeeks.Value, numDays.Value, numHours.Value, numMinutes.Value, numSeconds.Value
            );
            SQLiteCommand cmd = DbModule.CreateCommand("""
                INSERT INTO Recipes (user_id, name, rating, cooking_time, photo, cooking_method)
                VALUES ($user_id, $name, $rating, $cooking_time, $photo, $cooking_method)
                """,
                new SQLiteParameter("user_id", userId),
                new SQLiteParameter("name", txtRecipeName.Text),
                new SQLiteParameter("rating", numRecipeRating.Value),
                new SQLiteParameter("cooking_time", cookingTime),
                new SQLiteParameter("photo", picRecipePhoto.Image?.ToBytes()),
                new SQLiteParameter("cooking_method", txtCookingMethod.Text)
            );
            cmd.ExecuteNonQuery();

            SQLiteCommand cmdGetLastInsertedId = DbModule.CreateCommand("SELECT last_insert_rowid()");
            long recipeId = (long)cmdGetLastInsertedId.ExecuteScalar();
            long lastElementId;

            var autoFillingPanels = new[]
            {
                ("Tags", pnlTagInput),
                ("Ingredients", pnlIngredientInput)
            };
            foreach ((string tableName, AutoFillingFlowPanel panel) in autoFillingPanels)
                foreach (string value in panel.Values)
                {
                    cmd = DbModule.CreateCommand($"""
                        INSERT INTO {tableName} (name)
                        VALUES ($name)
                        """,
                        new SQLiteParameter("name", value)
                    );
                    cmd.ExecuteNonQuery();

                    lastElementId = (long)cmdGetLastInsertedId.ExecuteScalar();

                    cmd = DbModule.CreateCommand($"""
                        INSERT INTO Recipe{tableName}
                        VALUES ($recipe_id, $element_id)
                        """,
                        new SQLiteParameter("recipe_id", recipeId),
                        new SQLiteParameter("element_id", lastElementId)
                    );
                    cmd.ExecuteNonQuery();
                }
            _previousSelectedTab = tabCreateOrEditRecipe;
            tbcMainFormTabs.SelectedTab = tabListOfRecipes;
        }

        private void ClearRecipeInputFields()
        {
            txtRecipeName.Clear();
            txtCookingMethod.Clear();
            pnlTagInput.Clear();
            pnlIngredientInput.Clear();
            btnDeleteRecipePhoto_Click(new(), new());
            foreach (var numericUpDown in new[] { numHours, numMinutes, numSeconds, numWeeks, numDays, numRecipeRating })
                numericUpDown.Value = numericUpDown.Minimum;
        }

        private TimeSpan CookingTimeToTimeSpan()
        {
            return new TimeSpan(
                7 * (int)(numWeeks.Value + numDays.Value),
                (int)numHours.Value,
                (int)numMinutes.Value,
                (int)numSeconds.Value,
                0,
                0
            );
        }

        private void RecipeInputFieldsChanged(object sender, EventArgs e)
        {
            btnSaveRecipe.Enabled = txtCookingMethod.TextLength > 0
                && txtRecipeName.TextLength > 0
                && pnlIngredientInput.Controls.Count > 0
                && CookingTimeToTimeSpan() > _minimumCookingTime;
        }
    }
}

namespace RecipeBook
{
    public partial class EditRecipeForm : Form
    {
        private Recipe recipe;
        private MainForm mainForm;

        public EditRecipeForm(Recipe recipe, MainForm mainForm)
        {
            this.recipe = recipe;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void EditRecipeForm_Load(object sender, EventArgs e)
        {
            recipeNameBox.Text = recipe.name;
            // Ensure newlines are displayed correctly in the TextBox
            recipeInstructionsBox.Text = recipe.instructions.Replace("\n", Environment.NewLine);
            recipeTypeBox.Text = recipe.type;

            recipeIngredientsBox.Items.Clear();
            foreach (string s in recipe.ingredients)
            {
                recipeIngredientsBox.Items.Add(s);
            }
        }

        private void saveRecipeBtn_Click(object sender, EventArgs e)
        {
            // Update the recipe instance
            recipe.ChangeName(recipeNameBox.Text);
            recipe.ChangeInstructions(recipeInstructionsBox.Text);
            recipe.ChangeType(recipeTypeBox.Text);

            // Update the recipe in the main list
            var mainList = mainForm.GetRecipeList();
            var index = mainList.FindIndex(r => r.name == recipe.name);
            if (index != -1)
            {
                mainList[index] = recipe;
            }

            mainForm.UpdateRecipeListBox();
            mainForm.SaveRecipesToJson();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            mainForm.DeleteRecipeFromList(recipeNameBox.Text);
            this.Close();
        }

        private void recipeIngredientsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipeIngredientsBox.SelectedItem != null && recipeIngredientsBox.SelectedIndex != -1)
            {
                int selectedIndex = recipeIngredientsBox.SelectedIndex;
                string? selectedIngredient = recipeIngredientsBox.SelectedItem?.ToString(); // Use nullable string

                if (selectedIngredient != null) // Ensure selectedIngredient is not null
                {
                    EditIngredientForm newForm = new EditIngredientForm(selectedIngredient, selectedIndex);

                    DialogResult result = newForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        recipe.ingredients[selectedIndex] = newForm.EditedIngredient;
                        recipeIngredientsBox.Items[selectedIndex] = newForm.EditedIngredient;
                    }
                    else if (result == DialogResult.Abort)
                    {
                        recipe.ingredients.RemoveAt(selectedIndex);
                        recipeIngredientsBox.Items.RemoveAt(selectedIndex);
                    }
                }
            }
        }

        private void addIngredientBtn_Click(object sender, EventArgs e)
        {
            AddIngredientForm newForm = new AddIngredientForm(this);
            newForm.ShowDialog();

            if(newForm.DialogResult == DialogResult.OK)
            {
                recipe.AddIngredient(newForm.ingredient);

                recipeIngredientsBox.Items.Add(newForm.ingredient);
            }
        }
    }
}

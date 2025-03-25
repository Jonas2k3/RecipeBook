using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class AddRecipeForm : Form
    {

        public Recipe NewRecipe
        {
            get; set;
        }

        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string recipeName = RecipeNameBox.Text;
                string recipeDesc = RecipeDescBox.Text;
                string recipeIngredients = RecipeIngrBox.Text;
                string recipeType = RecipeTypeBox.Text;

                if (string.IsNullOrWhiteSpace(recipeName) || string.IsNullOrWhiteSpace(recipeDesc) || string.IsNullOrWhiteSpace(recipeIngredients) || string.IsNullOrWhiteSpace(recipeType))
                {
                    throw new ArgumentException("Please enter a value in all fields.");
                }

                List<string> ingredients = recipeIngredients.Split(' ').ToList();
                NewRecipe = new Recipe(recipeName, recipeDesc, ingredients, recipeType);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

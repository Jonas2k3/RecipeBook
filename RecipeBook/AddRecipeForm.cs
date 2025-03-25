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
    
        public Recipe NewRecipe { get; set; }
    
        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            string recipeName = RecipeNameBox.Text;
            string recipeDesc = RecipeDescBox.Text;
            string recipeIngredients = RecipeIngrBox.Text;

            List<string> ingredients = new List<string>();
            string[] ingredientSplit = recipeIngredients.Split(' ');

            foreach (string ingredient in ingredientSplit)
            {
                ingredients.Add(ingredient);
            }

            NewRecipe = new Recipe(recipeName, recipeDesc, ingredients);

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}

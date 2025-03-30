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
            recipeInstructionsBox.Text = recipe.instructions;
            recipeTypeBox.Text = recipe.type;

            foreach (string s in recipe.ingredients)
            {
                recipeIngredientsBox.Items.Add(s);
            }
        }

        private void saveRecipeBtn_Click(object sender, EventArgs e)
        {
            recipe.ChangeName(recipeNameBox.Text);
            recipe.ChangeInstructions(recipeInstructionsBox.Text);
            recipe.ChangeType(recipeTypeBox.Text);

            mainForm.UpdateRecipeListBox();
        }
    }
}

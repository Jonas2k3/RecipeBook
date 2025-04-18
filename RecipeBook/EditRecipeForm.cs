﻿using System;
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
                string selectedIngredient = recipeIngredientsBox.SelectedItem.ToString();

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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace RecipeBook
{
    public partial class MainForm : Form
    {
        private List<Recipe> recipeList = new List<Recipe>();
        private readonly string jsonFilePath = "recipes.json";
        private bool isLoading = false;

        public MainForm()
        {
            InitializeComponent();
            isLoading = true;
            LoadRecipesFromJson();
            isLoading = false;
        }

        private void LoadRecipesFromJson()
        {
            recipeList = RecipeStorage.LoadRecipes(jsonFilePath);
            UpdateRecipeListBox();
        }

        public void SaveRecipesToJson()
        {
            RecipeStorage.SaveRecipes(jsonFilePath, recipeList);
        }

        public void UpdateRecipeListBox()
        {
            isLoading = true;
            recipeListBox.DataSource = null;
            recipeListBox.DataSource = recipeList;
            recipeListBox.DisplayMember = "name";
            isLoading = false;
        }

        private void newRecipeBtn_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm();
            if (addRecipeForm.ShowDialog() == DialogResult.OK)
            {
                Recipe newRecipe = addRecipeForm.NewRecipe;
                recipeList.Add(newRecipe);
                SaveRecipesToJson();
                UpdateRecipeListBox();
            }
        }

        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // Prevent handler during loading

            if (recipeListBox.SelectedItem != null)
            {
                var latestRecipes = RecipeStorage.LoadRecipes(jsonFilePath);
                var selectedName = ((Recipe)recipeListBox.SelectedItem).name;
                var selectedRecipe = latestRecipes.Find(r => r.name == selectedName);

                if (selectedRecipe != null)
                {
                    EditRecipeForm newForm = new EditRecipeForm(selectedRecipe, this);
                    newForm.FormClosed += (s, args) =>
                    {
                        recipeList = RecipeStorage.LoadRecipes(jsonFilePath);
                        UpdateRecipeListBox();
                    };
                    newForm.Show();
                }
            }
        }

        public void DeleteRecipeFromList(string name)
        {
            recipeList.RemoveAll(r => r.name == name);
            SaveRecipesToJson();
            UpdateRecipeListBox();
        }

        private void randomRecipeBtn_Click(object sender, EventArgs e)
        {
            if (recipeList.Count > 0)
            {
                Random random = new Random();
                int rnd = random.Next(recipeList.Count);
                var latestRecipes = RecipeStorage.LoadRecipes(jsonFilePath);
                Recipe recipe = latestRecipes[rnd];
                EditRecipeForm newForm = new EditRecipeForm(recipe, this);
                newForm.FormClosed += (s, args) =>
                {
                    recipeList = RecipeStorage.LoadRecipes(jsonFilePath);
                    UpdateRecipeListBox();
                };
                newForm.Show();
            }
        }

        public List<Recipe> GetRecipeList() => recipeList;
    }
}

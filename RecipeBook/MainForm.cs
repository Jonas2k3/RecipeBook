namespace RecipeBook
{
    public partial class MainForm : Form
    {

        private List<Recipe> recipeList = new List<Recipe>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newRecipeBtn_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm();
            if (addRecipeForm.ShowDialog() == DialogResult.OK)
            {
                Recipe newRecipe = addRecipeForm.NewRecipe;
                AddRecipeToList(newRecipe);
            }

        }

        public void AddRecipeToList(Recipe recipe)
        {
            {
                recipeList.Add(recipe);
                UpdateRecipeListBox();
            }
        }

        public void UpdateRecipeListBox()
        {
            recipeListBox.Items.Clear();
            foreach (Recipe recipe in recipeList)
            {
                recipeListBox.Items.Add(recipe);
            }
        }

        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(recipeListBox.SelectedItem != null)
            {
                Recipe recipe = (Recipe)recipeListBox.SelectedItem;
                EditRecipeForm newForm = new EditRecipeForm(recipe, this);
                newForm.Show();
            }
        }
    }
}

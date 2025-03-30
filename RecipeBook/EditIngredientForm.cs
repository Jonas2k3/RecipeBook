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
    public partial class EditIngredientForm : Form
    {
        public string EditedIngredient {
            get; private set;
        }
        public EditIngredientForm(string ingredient)
        {
            InitializeComponent();
            ingredientBox.Text = ingredient;
        }

        private void EditIngredientForm_Load(object sender, EventArgs e)
        {}

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.EditedIngredient = ingredientBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

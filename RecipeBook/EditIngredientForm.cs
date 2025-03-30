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
        public string EditedIngredient
        {
            get; private set;
        }

        private int ingredientIndex;
        public EditIngredientForm(string ingredient, int index)
        {
            InitializeComponent();
            ingredientBox.Text = ingredient;
            this.ingredientIndex = index;
        }

        private void EditIngredientForm_Load(object sender, EventArgs e)
        {
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.EditedIngredient = ingredientBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.EditedIngredient = null;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}

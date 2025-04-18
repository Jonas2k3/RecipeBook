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
    public partial class AddIngredientForm : Form
    {

        private EditRecipeForm editRecipeForm;
        public string ingredient
        { get; private set;
        }
        public AddIngredientForm(EditRecipeForm editRecipeForm)
        {
            InitializeComponent();
            this.editRecipeForm = editRecipeForm;
        }

        private void addIngredientBtn_Click(object sender, EventArgs e)
        {
            if(addIngredientBox.Text != null)
            {
                ingredient = addIngredientBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

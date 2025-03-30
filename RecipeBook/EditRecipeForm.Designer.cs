namespace RecipeBook
{
    partial class EditRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            recipeNameBox = new TextBox();
            recipeInstructionsBox = new TextBox();
            recipeTypeBox = new TextBox();
            recipeIngredientsBox = new ListBox();
            saveRecipeBtn = new Button();
            deleteBtn = new Button();
            addIngredientBtn = new Button();
            SuspendLayout();
            // 
            // recipeNameBox
            // 
            recipeNameBox.Location = new Point(326, 63);
            recipeNameBox.Name = "recipeNameBox";
            recipeNameBox.Size = new Size(100, 23);
            recipeNameBox.TabIndex = 0;
            // 
            // recipeInstructionsBox
            // 
            recipeInstructionsBox.Location = new Point(326, 92);
            recipeInstructionsBox.Name = "recipeInstructionsBox";
            recipeInstructionsBox.Size = new Size(100, 23);
            recipeInstructionsBox.TabIndex = 1;
            // 
            // recipeTypeBox
            // 
            recipeTypeBox.Location = new Point(326, 121);
            recipeTypeBox.Name = "recipeTypeBox";
            recipeTypeBox.Size = new Size(100, 23);
            recipeTypeBox.TabIndex = 2;
            // 
            // recipeIngredientsBox
            // 
            recipeIngredientsBox.FormattingEnabled = true;
            recipeIngredientsBox.ItemHeight = 15;
            recipeIngredientsBox.Location = new Point(297, 170);
            recipeIngredientsBox.Name = "recipeIngredientsBox";
            recipeIngredientsBox.Size = new Size(159, 94);
            recipeIngredientsBox.TabIndex = 3;
            recipeIngredientsBox.SelectedIndexChanged += recipeIngredientsBox_SelectedIndexChanged;
            // 
            // saveRecipeBtn
            // 
            saveRecipeBtn.BackColor = Color.Lime;
            saveRecipeBtn.Location = new Point(338, 299);
            saveRecipeBtn.Name = "saveRecipeBtn";
            saveRecipeBtn.Size = new Size(75, 23);
            saveRecipeBtn.TabIndex = 4;
            saveRecipeBtn.Text = "Save";
            saveRecipeBtn.UseVisualStyleBackColor = false;
            saveRecipeBtn.Click += saveRecipeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Location = new Point(338, 323);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addIngredientBtn
            // 
            addIngredientBtn.Location = new Point(326, 270);
            addIngredientBtn.Name = "addIngredientBtn";
            addIngredientBtn.Size = new Size(100, 23);
            addIngredientBtn.TabIndex = 6;
            addIngredientBtn.Text = "Add ingredient";
            addIngredientBtn.UseVisualStyleBackColor = true;
            addIngredientBtn.Click += addIngredientBtn_Click;
            // 
            // EditRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addIngredientBtn);
            Controls.Add(deleteBtn);
            Controls.Add(saveRecipeBtn);
            Controls.Add(recipeIngredientsBox);
            Controls.Add(recipeTypeBox);
            Controls.Add(recipeInstructionsBox);
            Controls.Add(recipeNameBox);
            Name = "EditRecipeForm";
            Text = "EditRecipeForm";
            Load += EditRecipeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox recipeNameBox;
        private TextBox recipeInstructionsBox;
        private TextBox recipeTypeBox;
        private ListBox recipeIngredientsBox;
        private Button saveRecipeBtn;
        private Button deleteBtn;
        private Button addIngredientBtn;
    }
}
namespace RecipeBook
{
    partial class AddRecipeForm
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
            RecipeNameBox = new TextBox();
            RecipeDescBox = new TextBox();
            RecipeIngrBox = new TextBox();
            AddRecipeBtn = new Button();
            RecipeTypeBox = new TextBox();
            SuspendLayout();
            // 
            // RecipeNameBox
            // 
            RecipeNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RecipeNameBox.Location = new Point(245, 116);
            RecipeNameBox.Name = "RecipeNameBox";
            RecipeNameBox.PlaceholderText = "Enter recipe name...";
            RecipeNameBox.Size = new Size(166, 23);
            RecipeNameBox.TabIndex = 0;
            // 
            // RecipeDescBox
            // 
            RecipeDescBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RecipeDescBox.Location = new Point(245, 162);
            RecipeDescBox.Name = "RecipeDescBox";
            RecipeDescBox.PlaceholderText = "Enter recipe description..";
            RecipeDescBox.Size = new Size(166, 23);
            RecipeDescBox.TabIndex = 1;
            // 
            // RecipeIngrBox
            // 
            RecipeIngrBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RecipeIngrBox.Location = new Point(245, 208);
            RecipeIngrBox.Multiline = true;
            RecipeIngrBox.Name = "RecipeIngrBox";
            RecipeIngrBox.PlaceholderText = "Enter ingredients... [seperated by spaces[";
            RecipeIngrBox.Size = new Size(166, 126);
            RecipeIngrBox.TabIndex = 2;
            RecipeIngrBox.TextChanged += RecipeIngrBox_TextChanged;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddRecipeBtn.Location = new Point(280, 381);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(86, 23);
            AddRecipeBtn.TabIndex = 4;
            AddRecipeBtn.Text = "Add Recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // RecipeTypeBox
            // 
            RecipeTypeBox.Location = new Point(245, 340);
            RecipeTypeBox.Name = "RecipeTypeBox";
            RecipeTypeBox.PlaceholderText = "Enter type...";
            RecipeTypeBox.Size = new Size(166, 23);
            RecipeTypeBox.TabIndex = 3;
            // 
            // AddRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(RecipeTypeBox);
            Controls.Add(AddRecipeBtn);
            Controls.Add(RecipeIngrBox);
            Controls.Add(RecipeDescBox);
            Controls.Add(RecipeNameBox);
            Name = "AddRecipeForm";
            Text = "AddRecipeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RecipeNameBox;
        private TextBox RecipeDescBox;
        private TextBox RecipeIngrBox;
        private Button AddRecipeBtn;
        private TextBox RecipeTypeBox;
    }
}
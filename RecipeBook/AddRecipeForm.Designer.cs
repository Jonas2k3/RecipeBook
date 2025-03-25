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
            SuspendLayout();
            // 
            // RecipeNameBox
            // 
            RecipeNameBox.Location = new Point(314, 124);
            RecipeNameBox.Name = "RecipeNameBox";
            RecipeNameBox.Size = new Size(166, 23);
            RecipeNameBox.TabIndex = 0;
            // 
            // RecipeDescBox
            // 
            RecipeDescBox.Location = new Point(314, 172);
            RecipeDescBox.Name = "RecipeDescBox";
            RecipeDescBox.Size = new Size(166, 23);
            RecipeDescBox.TabIndex = 1;
            // 
            // RecipeIngrBox
            // 
            RecipeIngrBox.Location = new Point(314, 220);
            RecipeIngrBox.Name = "RecipeIngrBox";
            RecipeIngrBox.Size = new Size(166, 23);
            RecipeIngrBox.TabIndex = 2;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddRecipeBtn.Location = new Point(360, 281);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(75, 23);
            AddRecipeBtn.TabIndex = 3;
            AddRecipeBtn.Text = "Add Recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // AddRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
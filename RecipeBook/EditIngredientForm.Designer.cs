namespace RecipeBook
{
    partial class EditIngredientForm
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
            ingredientBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // ingredientBox
            // 
            ingredientBox.Location = new Point(57, 31);
            ingredientBox.Name = "ingredientBox";
            ingredientBox.Size = new Size(100, 23);
            ingredientBox.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(67, 60);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // EditIngredientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 98);
            Controls.Add(saveBtn);
            Controls.Add(ingredientBox);
            Name = "EditIngredientForm";
            Text = "EditIngredientForm";
            Load += EditIngredientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ingredientBox;
        private Button saveBtn;
    }
}
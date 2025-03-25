namespace RecipeBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            newRecipeBtn = new Button();
            recipeListBox = new ListBox();
            SuspendLayout();
            // 
            // newRecipeBtn
            // 
            newRecipeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newRecipeBtn.Location = new Point(256, 154);
            newRecipeBtn.Name = "newRecipeBtn";
            newRecipeBtn.Size = new Size(160, 23);
            newRecipeBtn.TabIndex = 1;
            newRecipeBtn.Text = "Create new recipe";
            newRecipeBtn.UseVisualStyleBackColor = true;
            newRecipeBtn.Click += newRecipeBtn_Click;
            // 
            // recipeListBox
            // 
            recipeListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            recipeListBox.FormattingEnabled = true;
            recipeListBox.ItemHeight = 15;
            recipeListBox.Location = new Point(275, 229);
            recipeListBox.Name = "recipeListBox";
            recipeListBox.Size = new Size(120, 94);
            recipeListBox.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(684, 461);
            Controls.Add(recipeListBox);
            Controls.Add(newRecipeBtn);
            Name = "MainForm";
            Text = "RecipeBook";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button newRecipeBtn;
        private ListBox recipeListBox;
    }
}
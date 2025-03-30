namespace RecipeBook
{
    partial class AddIngredientForm
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
            addIngredientBox = new TextBox();
            addIngredientBtn = new Button();
            SuspendLayout();
            // 
            // addIngredientBox
            // 
            addIngredientBox.Location = new Point(85, 38);
            addIngredientBox.Name = "addIngredientBox";
            addIngredientBox.Size = new Size(100, 23);
            addIngredientBox.TabIndex = 0;
            // 
            // addIngredientBtn
            // 
            addIngredientBtn.BackColor = Color.Lime;
            addIngredientBtn.Location = new Point(97, 78);
            addIngredientBtn.Name = "addIngredientBtn";
            addIngredientBtn.Size = new Size(75, 23);
            addIngredientBtn.TabIndex = 1;
            addIngredientBtn.Text = "Add";
            addIngredientBtn.UseVisualStyleBackColor = false;
            addIngredientBtn.Click += addIngredientBtn_Click;
            // 
            // AddIngredientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 148);
            Controls.Add(addIngredientBtn);
            Controls.Add(addIngredientBox);
            Name = "AddIngredientForm";
            Text = "AddIngredientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addIngredientBox;
        private Button addIngredientBtn;
    }
}
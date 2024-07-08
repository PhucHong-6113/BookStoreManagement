namespace PresentationObject.Categories
{
    partial class AddCategories
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
            label1 = new Label();
            label2 = new Label();
            lbDescription = new Label();
            addNameCategory = new TextBox();
            addDescriptionCategory = new TextBox();
            submitAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(268, 54);
            label2.TabIndex = 1;
            label2.Text = "Add Category";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(12, 231);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 2;
            lbDescription.Text = "Description";
            // 
            // addNameCategory
            // 
            addNameCategory.Location = new Point(132, 103);
            addNameCategory.Name = "addNameCategory";
            addNameCategory.Size = new Size(347, 27);
            addNameCategory.TabIndex = 3;
            // 
            // addDescriptionCategory
            // 
            addDescriptionCategory.Location = new Point(128, 231);
            addDescriptionCategory.Multiline = true;
            addDescriptionCategory.Name = "addDescriptionCategory";
            addDescriptionCategory.Size = new Size(350, 210);
            addDescriptionCategory.TabIndex = 4;
            // 
            // submitAdd
            // 
            submitAdd.Location = new Point(278, 483);
            submitAdd.Name = "submitAdd";
            submitAdd.Size = new Size(201, 54);
            submitAdd.TabIndex = 5;
            submitAdd.Text = "Add";
            submitAdd.UseVisualStyleBackColor = true;
            submitAdd.Click += submitAdd_Click;
            // 
            // AddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 613);
            Controls.Add(submitAdd);
            Controls.Add(addDescriptionCategory);
            Controls.Add(addNameCategory);
            Controls.Add(lbDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCategories";
            Text = "AddCategories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbDescription;
        private TextBox addNameCategory;
        private TextBox addDescriptionCategory;
        private Button submitAdd;
    }
}
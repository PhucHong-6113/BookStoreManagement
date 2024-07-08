namespace PresentationObject.Categories
{
    partial class UpdateCategory
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
            label3 = new Label();
            updateCategoryName = new TextBox();
            updateCategoryDescription = new TextBox();
            updateSubmit = new Button();
            label4 = new Label();
            label5 = new Label();
            oldName_txt = new TextBox();
            oldDescription_txt = new TextBox();
            categoryId_lb = new Label();
            menu_link = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(290, 46);
            label1.TabIndex = 0;
            label1.Text = "Update Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // updateCategoryName
            // 
            updateCategoryName.Location = new Point(133, 130);
            updateCategoryName.Name = "updateCategoryName";
            updateCategoryName.Size = new Size(293, 27);
            updateCategoryName.TabIndex = 3;
            // 
            // updateCategoryDescription
            // 
            updateCategoryDescription.Location = new Point(133, 287);
            updateCategoryDescription.Multiline = true;
            updateCategoryDescription.Name = "updateCategoryDescription";
            updateCategoryDescription.Size = new Size(293, 224);
            updateCategoryDescription.TabIndex = 4;
            // 
            // updateSubmit
            // 
            updateSubmit.Location = new Point(371, 561);
            updateSubmit.Name = "updateSubmit";
            updateSubmit.Size = new Size(192, 84);
            updateSubmit.TabIndex = 5;
            updateSubmit.Text = "Update";
            updateSubmit.UseVisualStyleBackColor = true;
            updateSubmit.Click += updateSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 133);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Old Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 290);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 7;
            label5.Text = "Old Description";
            // 
            // oldName_txt
            // 
            oldName_txt.Location = new Point(578, 130);
            oldName_txt.Name = "oldName_txt";
            oldName_txt.Size = new Size(324, 27);
            oldName_txt.TabIndex = 8;
            // 
            // oldDescription_txt
            // 
            oldDescription_txt.Location = new Point(578, 283);
            oldDescription_txt.Multiline = true;
            oldDescription_txt.Name = "oldDescription_txt";
            oldDescription_txt.Size = new Size(324, 228);
            oldDescription_txt.TabIndex = 9;
            // 
            // categoryId_lb
            // 
            categoryId_lb.AutoSize = true;
            categoryId_lb.Location = new Point(12, 173);
            categoryId_lb.Name = "categoryId_lb";
            categoryId_lb.Size = new Size(50, 20);
            categoryId_lb.TabIndex = 10;
            categoryId_lb.Text = "label6";
            // 
            // menu_link
            // 
            menu_link.AutoSize = true;
            menu_link.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_link.Location = new Point(133, 573);
            menu_link.Name = "menu_link";
            menu_link.Size = new Size(119, 46);
            menu_link.TabIndex = 11;
            menu_link.TabStop = true;
            menu_link.Text = "Cancel";
            menu_link.LinkClicked += menu_link_LinkClicked;
            // 
            // UpdateCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 674);
            Controls.Add(menu_link);
            Controls.Add(categoryId_lb);
            Controls.Add(oldDescription_txt);
            Controls.Add(oldName_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(updateSubmit);
            Controls.Add(updateCategoryDescription);
            Controls.Add(updateCategoryName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateCategory";
            Text = "UpdateCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox updateCategoryName;
        private TextBox updateCategoryDescription;
        private Button updateSubmit;
        private Label label4;
        private Label label5;
        private TextBox oldName_txt;
        private TextBox oldDescription_txt;
        private Label categoryId_lb;
        private LinkLabel menu_link;
    }
}
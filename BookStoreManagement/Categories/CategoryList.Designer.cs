namespace PresentationObject.Categories
{
    partial class CategoryList
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
            components = new System.ComponentModel.Container();
            dgvCategory = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            addCategory = new Button();
            updateCategory = new Button();
            deleteCategory = new Button();
            tbSearchCategory = new TextBox();
            searchCategory = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(10, 137);
            dgvCategory.Margin = new Padding(3, 2, 3, 2);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(578, 290);
            dgvCategory.TabIndex = 0;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(BusinessObject.Models.Category);
            // 
            // addCategory
            // 
            addCategory.Location = new Point(618, 137);
            addCategory.Margin = new Padding(3, 2, 3, 2);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(130, 64);
            addCategory.TabIndex = 1;
            addCategory.Text = "Add";
            addCategory.UseVisualStyleBackColor = true;
            addCategory.Click += addCategory_Click;
            // 
            // updateCategory
            // 
            updateCategory.Location = new Point(618, 249);
            updateCategory.Margin = new Padding(3, 2, 3, 2);
            updateCategory.Name = "updateCategory";
            updateCategory.Size = new Size(130, 64);
            updateCategory.TabIndex = 2;
            updateCategory.Text = "Update";
            updateCategory.UseVisualStyleBackColor = true;
            updateCategory.Click += updateCategory_Click;
            // 
            // deleteCategory
            // 
            deleteCategory.Location = new Point(618, 363);
            deleteCategory.Margin = new Padding(3, 2, 3, 2);
            deleteCategory.Name = "deleteCategory";
            deleteCategory.Size = new Size(130, 64);
            deleteCategory.TabIndex = 3;
            deleteCategory.Text = "Delete";
            deleteCategory.UseVisualStyleBackColor = true;
            deleteCategory.Click += deleteCategory_Click;
            // 
            // tbSearchCategory
            // 
            tbSearchCategory.Location = new Point(14, 99);
            tbSearchCategory.Margin = new Padding(3, 2, 3, 2);
            tbSearchCategory.Name = "tbSearchCategory";
            tbSearchCategory.Size = new Size(510, 23);
            tbSearchCategory.TabIndex = 4;
            // 
            // searchCategory
            // 
            searchCategory.Location = new Point(538, 98);
            searchCategory.Margin = new Padding(3, 2, 3, 2);
            searchCategory.Name = "searchCategory";
            searchCategory.Size = new Size(49, 25);
            searchCategory.TabIndex = 5;
            searchCategory.Text = "Find";
            searchCategory.UseVisualStyleBackColor = true;
            searchCategory.Click += searchCategory_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(642, 101);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 22);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(426, 51);
            label1.TabIndex = 7;
            label1.Text = "Category Management";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(669, 12);
            button2.Name = "button2";
            button2.Size = new Size(96, 48);
            button2.TabIndex = 8;
            button2.Text = "Return to main Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 436);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(searchCategory);
            Controls.Add(tbSearchCategory);
            Controls.Add(deleteCategory);
            Controls.Add(updateCategory);
            Controls.Add(addCategory);
            Controls.Add(dgvCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryList";
            Text = "CategoryList";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategory;
        private BindingSource categoryBindingSource;
        private Button addCategory;
        private Button updateCategory;
        private Button deleteCategory;
        private TextBox tbSearchCategory;
        private Button searchCategory;
        private Button btnRefresh;
        private Label label1;
        private Button button2;
    }
}
namespace PresentationObject.Authors
{
    partial class FrmManageAuthors
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
            panel1 = new Panel();
            btnMainScreen = new Button();
            label2 = new Label();
            btnUpdateAuthor = new Button();
            btnDeleteAuthor = new Button();
            btnAddAuthor = new Button();
            panel2 = new Panel();
            btnLoad = new Button();
            btnClose = new Button();
            btnSearch = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            dgAuthors = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAuthors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 50, 66);
            panel1.Controls.Add(btnMainScreen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUpdateAuthor);
            panel1.Controls.Add(btnDeleteAuthor);
            panel1.Controls.Add(btnAddAuthor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 411);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnMainScreen
            // 
            btnMainScreen.DialogResult = DialogResult.No;
            btnMainScreen.Location = new Point(-12, 342);
            btnMainScreen.Margin = new Padding(2, 1, 2, 1);
            btnMainScreen.Name = "btnMainScreen";
            btnMainScreen.Size = new Size(180, 22);
            btnMainScreen.TabIndex = 5;
            btnMainScreen.Text = "Main Screen";
            btnMainScreen.UseVisualStyleBackColor = true;
            btnMainScreen.Click += btnMainScreen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(43, 373);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Setting";
            // 
            // btnUpdateAuthor
            // 
            btnUpdateAuthor.BackColor = Color.FromArgb(45, 50, 66);
            btnUpdateAuthor.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnUpdateAuthor.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 80);
            btnUpdateAuthor.ForeColor = SystemColors.ButtonFace;
            btnUpdateAuthor.Location = new Point(-23, 136);
            btnUpdateAuthor.Margin = new Padding(2, 1, 2, 1);
            btnUpdateAuthor.Name = "btnUpdateAuthor";
            btnUpdateAuthor.Size = new Size(203, 30);
            btnUpdateAuthor.TabIndex = 3;
            btnUpdateAuthor.Text = "Update Author";
            btnUpdateAuthor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateAuthor.UseVisualStyleBackColor = false;
            btnUpdateAuthor.Click += btnUpdateAuthor_Click_1;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.BackColor = Color.FromArgb(45, 50, 66);
            btnDeleteAuthor.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnDeleteAuthor.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 80);
            btnDeleteAuthor.ForeColor = SystemColors.ButtonFace;
            btnDeleteAuthor.Location = new Point(-12, 188);
            btnDeleteAuthor.Margin = new Padding(2, 1, 2, 1);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(187, 30);
            btnDeleteAuthor.TabIndex = 2;
            btnDeleteAuthor.Text = "Delete Author";
            btnDeleteAuthor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteAuthor.UseVisualStyleBackColor = false;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.BackgroundImageLayout = ImageLayout.None;
            btnAddAuthor.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnAddAuthor.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 80);
            btnAddAuthor.ForeColor = SystemColors.Window;
            btnAddAuthor.Location = new Point(-12, 82);
            btnAddAuthor.Margin = new Padding(2, 1, 2, 1);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Padding = new Padding(2, 1, 2, 1);
            btnAddAuthor.Size = new Size(180, 30);
            btnAddAuthor.TabIndex = 0;
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.UseVisualStyleBackColor = false;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 50, 66);
            panel2.Controls.Add(btnLoad);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(153, 0);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 37);
            panel2.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(415, 8);
            btnLoad.Margin = new Padding(2, 1, 2, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(81, 22);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(683, 7);
            btnClose.Margin = new Padding(2, 1, 2, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 22);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(310, 8);
            btnSearch.Margin = new Padding(2, 1, 2, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "Find Author";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(45, 50, 66);
            txtSearch.ForeColor = Color.FloralWhite;
            txtSearch.Location = new Point(85, 10);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // dgAuthors
            // 
            dgAuthors.BackgroundColor = Color.FromArgb(45, 50, 66);
            dgAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAuthors.GridColor = SystemColors.MenuHighlight;
            dgAuthors.Location = new Point(228, 68);
            dgAuthors.Margin = new Padding(2, 1, 2, 1);
            dgAuthors.Name = "dgAuthors";
            dgAuthors.RowHeadersWidth = 82;
            dgAuthors.Size = new Size(597, 324);
            dgAuthors.TabIndex = 2;
            dgAuthors.CellContentClick += dgAuthors_CellContentClick;
            // 
            // FrmManageAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(887, 411);
            Controls.Add(dgAuthors);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "FrmManageAuthors";
            Text = "Manage Authors";
            Load += FrmManageAuthors_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgAuthors;
        private Button button4;
        private Button btnDeleteAuthor;
        private Button button2;
        private Button btnAddAuthor;
        private Button btnUpdateAuthor;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Button btnSearch;
        private Button btnClose;
        private Button btnLoad;
        private Button btnMainScreen;
    }
}
namespace PresentationObject
{
    partial class MenuScreen
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
            book = new Button();
            category = new Button();
            publisher = new Button();
            author = new Button();
            Hello = new Label();
            username = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // book
            // 
            book.Font = new Font("Segoe UI", 14.25F);
            book.Location = new Point(130, 180);
            book.Name = "book";
            book.Size = new Size(151, 100);
            book.TabIndex = 0;
            book.Text = "Book Management";
            book.UseVisualStyleBackColor = true;
            book.Click += book_Click;
            // 
            // category
            // 
            category.Font = new Font("Segoe UI", 14.25F);
            category.Location = new Point(365, 338);
            category.Name = "category";
            category.Size = new Size(155, 91);
            category.TabIndex = 1;
            category.Text = "Category Management";
            category.UseVisualStyleBackColor = true;
            category.Click += category_Click;
            // 
            // publisher
            // 
            publisher.Font = new Font("Segoe UI", 14.25F);
            publisher.Location = new Point(130, 338);
            publisher.Name = "publisher";
            publisher.Size = new Size(151, 91);
            publisher.TabIndex = 2;
            publisher.Text = "Publisher Management";
            publisher.UseVisualStyleBackColor = true;
            publisher.Click += publisher_Click;
            // 
            // author
            // 
            author.Font = new Font("Segoe UI", 14.25F);
            author.Location = new Point(365, 180);
            author.Name = "author";
            author.Size = new Size(155, 100);
            author.TabIndex = 3;
            author.Text = "Author Management";
            author.UseVisualStyleBackColor = true;
            author.Click += author_Click;
            // 
            // Hello
            // 
            Hello.AutoSize = true;
            Hello.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hello.Location = new Point(25, 53);
            Hello.Name = "Hello";
            Hello.Size = new Size(139, 65);
            Hello.TabIndex = 4;
            Hello.Text = "Hello";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            username.Location = new Point(155, 53);
            username.Name = "username";
            username.Size = new Size(185, 65);
            username.TabIndex = 5;
            username.Text = "name...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 294);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(535, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 47);
            button1.TabIndex = 7;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 480);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(Hello);
            Controls.Add(author);
            Controls.Add(publisher);
            Controls.Add(category);
            Controls.Add(book);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuScreen";
            Text = "Menu";
            FormClosed += form_close;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button book;
        private Button category;
        private Button publisher;
        private Button author;
        private Label Hello;
        private Label username;
        private Label label1;
        private Button button1;
    }
}
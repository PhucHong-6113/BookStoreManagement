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
            SuspendLayout();
            // 
            // book
            // 
            book.Location = new Point(130, 180);
            book.Name = "book";
            book.Size = new Size(132, 100);
            book.TabIndex = 0;
            book.Text = "Book Management";
            book.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            category.Location = new Point(365, 338);
            category.Name = "category";
            category.Size = new Size(130, 91);
            category.TabIndex = 1;
            category.Text = "Category Management";
            category.UseVisualStyleBackColor = true;
            // 
            // publisher
            // 
            publisher.Location = new Point(130, 338);
            publisher.Name = "publisher";
            publisher.Size = new Size(132, 91);
            publisher.TabIndex = 2;
            publisher.Text = "Publisher Management";
            publisher.UseVisualStyleBackColor = true;
            // 
            // author
            // 
            author.Location = new Point(365, 180);
            author.Name = "author";
            author.Size = new Size(130, 100);
            author.TabIndex = 3;
            author.Text = "Author Management";
            author.UseVisualStyleBackColor = true;
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
            username.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(155, 53);
            username.Name = "username";
            username.Size = new Size(175, 65);
            username.TabIndex = 5;
            username.Text = "name...";
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 480);
            Controls.Add(username);
            Controls.Add(Hello);
            Controls.Add(author);
            Controls.Add(publisher);
            Controls.Add(category);
            Controls.Add(book);
            Name = "MenuScreen";
            Text = "Menu";
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
    }
}
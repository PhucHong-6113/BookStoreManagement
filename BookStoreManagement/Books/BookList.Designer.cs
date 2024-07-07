namespace PresentationObject.Books
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            dgv_books = new DataGridView();
            book_count_label = new Label();
            add_book = new Button();
            button2 = new Button();
            delete_book = new Button();
            update_book = new Button();
            search_txt = new TextBox();
            search_btn = new Button();
            book_banner = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            SuspendLayout();
            // 
            // dgv_books
            // 
            dgv_books.AllowUserToAddRows = false;
            dgv_books.AllowUserToDeleteRows = false;
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_books.Location = new Point(30, 118);
            dgv_books.Name = "dgv_books";
            dgv_books.ReadOnly = true;
            dgv_books.Size = new Size(831, 334);
            dgv_books.TabIndex = 0;
            // 
            // book_count_label
            // 
            book_count_label.AutoSize = true;
            book_count_label.Location = new Point(29, 90);
            book_count_label.Name = "book_count_label";
            book_count_label.Size = new Size(91, 15);
            book_count_label.TabIndex = 1;
            book_count_label.Text = "... books existed";
            // 
            // add_book
            // 
            add_book.BackColor = SystemColors.ActiveCaption;
            add_book.Location = new Point(894, 216);
            add_book.Name = "add_book";
            add_book.Size = new Size(113, 44);
            add_book.TabIndex = 2;
            add_book.Text = "Add Book";
            add_book.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(894, 118);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 3;
            button2.Text = "View Book Detail";
            button2.UseVisualStyleBackColor = false;
            // 
            // delete_book
            // 
            delete_book.BackColor = Color.IndianRed;
            delete_book.Location = new Point(894, 408);
            delete_book.Name = "delete_book";
            delete_book.Size = new Size(113, 44);
            delete_book.TabIndex = 4;
            delete_book.Text = "Delete Book";
            delete_book.UseVisualStyleBackColor = false;
            // 
            // update_book
            // 
            update_book.BackColor = Color.LightGreen;
            update_book.Location = new Point(894, 313);
            update_book.Name = "update_book";
            update_book.Size = new Size(113, 44);
            update_book.TabIndex = 5;
            update_book.Text = "Update Book";
            update_book.UseVisualStyleBackColor = false;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(542, 73);
            search_txt.Name = "search_txt";
            search_txt.PlaceholderText = "search book by Name...";
            search_txt.Size = new Size(266, 29);
            search_txt.TabIndex = 6;
            // 
            // search_btn
            // 
            search_btn.BackgroundImage = (Image)resources.GetObject("search_btn.BackgroundImage");
            search_btn.BackgroundImageLayout = ImageLayout.Stretch;
            search_btn.Location = new Point(814, 73);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(47, 32);
            search_btn.TabIndex = 7;
            search_btn.UseVisualStyleBackColor = true;
            // 
            // book_banner
            // 
            book_banner.AutoSize = true;
            book_banner.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            book_banner.Location = new Point(30, 9);
            book_banner.Name = "book_banner";
            book_banner.Size = new Size(323, 50);
            book_banner.TabIndex = 8;
            book_banner.Text = "Book Management";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(894, 15);
            button1.Name = "button1";
            button1.Size = new Size(113, 65);
            button1.TabIndex = 9;
            button1.Text = "Back to menu";
            button1.UseVisualStyleBackColor = false;
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 473);
            Controls.Add(button1);
            Controls.Add(book_banner);
            Controls.Add(search_btn);
            Controls.Add(search_txt);
            Controls.Add(update_book);
            Controls.Add(delete_book);
            Controls.Add(button2);
            Controls.Add(add_book);
            Controls.Add(book_count_label);
            Controls.Add(dgv_books);
            Name = "BookList";
            Text = "BookList";
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_books;
        private Label book_count_label;
        private Button add_book;
        private Button button2;
        private Button delete_book;
        private Button update_book;
        private TextBox search_txt;
        private Button search_btn;
        private Label book_banner;
        private Button button1;
    }
}
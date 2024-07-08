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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            dgv_books = new DataGridView();
            book_count_label = new Label();
            add_book = new Button();
            book_detail = new Button();
            delete_book = new Button();
            update_book = new Button();
            search_txt = new TextBox();
            search_btn = new Button();
            book_banner = new Label();
            button1 = new Button();
            bookBindingSource = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgv_books
            // 
            dgv_books.AllowUserToAddRows = false;
            dgv_books.AllowUserToDeleteRows = false;
            dgv_books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_books.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_books.Location = new Point(30, 118);
            dgv_books.MultiSelect = false;
            dgv_books.Name = "dgv_books";
            dgv_books.ReadOnly = true;
            dgv_books.RowHeadersVisible = false;
            dgv_books.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_books.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_books.Size = new Size(897, 334);
            dgv_books.TabIndex = 0;
            dgv_books.CellDoubleClick += List_doubleClick;
            // 
            // book_count_label
            // 
            book_count_label.AutoSize = true;
            book_count_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            book_count_label.Location = new Point(30, 85);
            book_count_label.Name = "book_count_label";
            book_count_label.Size = new Size(165, 30);
            book_count_label.TabIndex = 1;
            book_count_label.Text = "... books existed.";
            // 
            // add_book
            // 
            add_book.BackColor = SystemColors.ActiveCaption;
            add_book.Location = new Point(960, 205);
            add_book.Name = "add_book";
            add_book.Size = new Size(113, 64);
            add_book.TabIndex = 2;
            add_book.Text = "Add Book";
            add_book.UseVisualStyleBackColor = false;
            add_book.Click += add_book_Click;
            // 
            // book_detail
            // 
            book_detail.BackColor = SystemColors.Info;
            book_detail.Location = new Point(960, 118);
            book_detail.Name = "book_detail";
            book_detail.Size = new Size(113, 63);
            book_detail.TabIndex = 3;
            book_detail.Text = "View Book Detail";
            book_detail.UseVisualStyleBackColor = false;
            book_detail.Click += book_detail_Click;
            // 
            // delete_book
            // 
            delete_book.BackColor = Color.IndianRed;
            delete_book.Location = new Point(960, 392);
            delete_book.Name = "delete_book";
            delete_book.Size = new Size(113, 60);
            delete_book.TabIndex = 4;
            delete_book.Text = "Delete Book";
            delete_book.UseVisualStyleBackColor = false;
            delete_book.Click += delete_book_Click;
            // 
            // update_book
            // 
            update_book.BackColor = Color.LightGreen;
            update_book.Location = new Point(960, 297);
            update_book.Name = "update_book";
            update_book.Size = new Size(113, 60);
            update_book.TabIndex = 5;
            update_book.Text = "Update Book";
            update_book.UseVisualStyleBackColor = false;
            update_book.Click += update_book_Click;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(604, 69);
            search_txt.Name = "search_txt";
            search_txt.PlaceholderText = "Search book...";
            search_txt.Size = new Size(266, 29);
            search_txt.TabIndex = 6;
            // 
            // search_btn
            // 
            search_btn.BackgroundImage = (Image)resources.GetObject("search_btn.BackgroundImage");
            search_btn.BackgroundImageLayout = ImageLayout.Stretch;
            search_btn.Location = new Point(876, 69);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(47, 32);
            search_btn.TabIndex = 7;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // book_banner
            // 
            book_banner.AutoSize = true;
            book_banner.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            book_banner.Location = new Point(30, 15);
            book_banner.Name = "book_banner";
            book_banner.Size = new Size(347, 50);
            book_banner.TabIndex = 8;
            book_banner.Text = "Book Management";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(960, 17);
            button1.Name = "button1";
            button1.Size = new Size(113, 65);
            button1.TabIndex = 9;
            button1.Text = "Back to menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(BusinessObject.Models.Book);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(BusinessObject.Models.Book);
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 473);
            Controls.Add(button1);
            Controls.Add(book_banner);
            Controls.Add(search_btn);
            Controls.Add(search_txt);
            Controls.Add(update_book);
            Controls.Add(delete_book);
            Controls.Add(book_detail);
            Controls.Add(add_book);
            Controls.Add(book_count_label);
            Controls.Add(dgv_books);
            Name = "BookList";
            Text = "BookList";
            KeyDown += enter;
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_books;
        private Label book_count_label;
        private Button add_book;
        private Button book_detail;
        private Button delete_book;
        private Button update_book;
        private TextBox search_txt;
        private Button search_btn;
        private Label book_banner;
        private Button button1;
        private BindingSource bookBindingSource;
        private BindingSource bookBindingSource1;
    }
}
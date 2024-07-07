namespace PresentationObject
{
    partial class BookDetail
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
            Button update_book;
            bookDetail_banner = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            change_author = new Button();
            change_category = new Button();
            change_publisher = new Button();
            menu_link = new LinkLabel();
            update_book = new Button();
            SuspendLayout();
            // 
            // bookDetail_banner
            // 
            bookDetail_banner.AutoSize = true;
            bookDetail_banner.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bookDetail_banner.Location = new Point(527, 24);
            bookDetail_banner.Name = "bookDetail_banner";
            bookDetail_banner.Size = new Size(226, 50);
            bookDetail_banner.TabIndex = 9;
            bookDetail_banner.Text = "Book Detail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 93);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 10;
            label1.Text = "Book name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 186);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 11;
            label2.Text = "Book Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 136);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 12;
            label3.Text = "In stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 294);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 13;
            label4.Text = "Publisher Description:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 240);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Publisher:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 136);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 399);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 16;
            label7.Text = "Author Description:\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 349);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 17;
            label8.Text = "Author:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(44, 452);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 18;
            label9.Text = "Category:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(44, 511);
            label10.Name = "label10";
            label10.Size = new Size(127, 15);
            label10.TabIndex = 19;
            label10.Text = "Category Description:\r\n";
            // 
            // change_author
            // 
            change_author.Location = new Point(368, 336);
            change_author.Name = "change_author";
            change_author.Size = new Size(122, 41);
            change_author.TabIndex = 20;
            change_author.Text = "Change Author";
            change_author.UseVisualStyleBackColor = true;
            // 
            // change_category
            // 
            change_category.Location = new Point(368, 439);
            change_category.Name = "change_category";
            change_category.Size = new Size(122, 41);
            change_category.TabIndex = 21;
            change_category.Text = "Change Category";
            change_category.UseVisualStyleBackColor = true;
            // 
            // change_publisher
            // 
            change_publisher.Location = new Point(368, 227);
            change_publisher.Name = "change_publisher";
            change_publisher.Size = new Size(122, 41);
            change_publisher.TabIndex = 22;
            change_publisher.Text = "Change Publisher";
            change_publisher.UseVisualStyleBackColor = true;
            // 
            // update_book
            // 
            update_book.BackColor = SystemColors.ActiveCaption;
            update_book.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_book.ForeColor = SystemColors.ControlText;
            update_book.Location = new Point(668, 536);
            update_book.Name = "update_book";
            update_book.Size = new Size(111, 89);
            update_book.TabIndex = 23;
            update_book.Text = "Update Book Detail";
            update_book.UseVisualStyleBackColor = false;
            // 
            // menu_link
            // 
            menu_link.AutoSize = true;
            menu_link.Location = new Point(44, 592);
            menu_link.Name = "menu_link";
            menu_link.Size = new Size(80, 15);
            menu_link.TabIndex = 24;
            menu_link.TabStop = true;
            menu_link.Text = "Back to Menu";
            // 
            // BookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 637);
            Controls.Add(menu_link);
            Controls.Add(update_book);
            Controls.Add(change_publisher);
            Controls.Add(change_category);
            Controls.Add(change_author);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookDetail_banner);
            Name = "BookDetail";
            Text = "Book Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookDetail_banner;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button change_author;
        private Button change_category;
        private Button change_publisher;
        private Button update_book;
        private LinkLabel menu_link;
    }
}
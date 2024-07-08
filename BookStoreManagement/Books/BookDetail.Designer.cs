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
            Button update_book_detail;
            bookDetail_banner = new Label();
            label1 = new Label();
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
            book_name = new Label();
            book_quantity = new Label();
            book_price = new Label();
            publisher_name = new Label();
            publisher_des = new Label();
            author_name = new Label();
            author_des = new Label();
            category_name = new Label();
            category_des = new Label();
            update_alert = new Label();
            publisher_cbb = new ComboBox();
            category_cbb = new ComboBox();
            author_cbb = new ComboBox();
            id_lbl = new Label();
            publisherId_lbl = new Label();
            authorId_lbl = new Label();
            categoryId_lbl = new Label();
            update_book_detail = new Button();
            SuspendLayout();
            // 
            // update_book_detail
            // 
            update_book_detail.BackColor = SystemColors.ActiveCaption;
            update_book_detail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_book_detail.ForeColor = SystemColors.ControlText;
            update_book_detail.Location = new Point(1113, 547);
            update_book_detail.Name = "update_book_detail";
            update_book_detail.Size = new Size(115, 57);
            update_book_detail.TabIndex = 23;
            update_book_detail.Text = "Update Book Detail";
            update_book_detail.UseVisualStyleBackColor = false;
            update_book_detail.Click += update_book_detail_Click;
            // 
            // bookDetail_banner
            // 
            bookDetail_banner.AutoSize = true;
            bookDetail_banner.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bookDetail_banner.Location = new Point(946, 9);
            bookDetail_banner.Name = "bookDetail_banner";
            bookDetail_banner.Size = new Size(292, 65);
            bookDetail_banner.TabIndex = 9;
            bookDetail_banner.Text = "Book Detail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 75);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 10;
            label1.Text = "Book name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(44, 136);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 12;
            label3.Text = "In stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(40, 244);
            label4.Name = "label4";
            label4.Size = new Size(229, 30);
            label4.TabIndex = 13;
            label4.Text = "Publisher Description:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(40, 190);
            label5.Name = "label5";
            label5.Size = new Size(112, 30);
            label5.TabIndex = 14;
            label5.Text = "Publisher:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.Location = new Point(234, 136);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 15;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.Location = new Point(40, 349);
            label7.Name = "label7";
            label7.Size = new Size(207, 30);
            label7.TabIndex = 16;
            label7.Text = "Author Description:\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label8.Location = new Point(40, 299);
            label8.Name = "label8";
            label8.Size = new Size(90, 30);
            label8.TabIndex = 17;
            label8.Text = "Author:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.Location = new Point(40, 402);
            label9.Name = "label9";
            label9.Size = new Size(108, 30);
            label9.TabIndex = 18;
            label9.Text = "Category:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label10.Location = new Point(40, 461);
            label10.Name = "label10";
            label10.Size = new Size(226, 30);
            label10.TabIndex = 19;
            label10.Text = "Category Description:\r\n";
            // 
            // change_author
            // 
            change_author.Font = new Font("Microsoft Sans Serif", 12F);
            change_author.Location = new Point(855, 288);
            change_author.Name = "change_author";
            change_author.Size = new Size(148, 41);
            change_author.TabIndex = 20;
            change_author.Text = "Change Author";
            change_author.UseVisualStyleBackColor = true;
            change_author.Click += change_author_Click;
            // 
            // change_category
            // 
            change_category.Font = new Font("Microsoft Sans Serif", 12F);
            change_category.Location = new Point(855, 404);
            change_category.Name = "change_category";
            change_category.Size = new Size(148, 41);
            change_category.TabIndex = 21;
            change_category.Text = "Change Category";
            change_category.UseVisualStyleBackColor = true;
            change_category.Click += change_category_Click;
            // 
            // change_publisher
            // 
            change_publisher.Font = new Font("Microsoft Sans Serif", 12F);
            change_publisher.Location = new Point(855, 179);
            change_publisher.Name = "change_publisher";
            change_publisher.Size = new Size(148, 41);
            change_publisher.TabIndex = 22;
            change_publisher.Text = "Change Publisher";
            change_publisher.UseVisualStyleBackColor = true;
            change_publisher.Click += change_publisher_Click;
            // 
            // menu_link
            // 
            menu_link.AutoSize = true;
            menu_link.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_link.Location = new Point(966, 574);
            menu_link.Name = "menu_link";
            menu_link.Size = new Size(141, 30);
            menu_link.TabIndex = 24;
            menu_link.TabStop = true;
            menu_link.Text = "Back to Menu";
            menu_link.LinkClicked += menu_link_LinkClicked;
            // 
            // book_name
            // 
            book_name.AutoSize = true;
            book_name.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            book_name.ForeColor = Color.Red;
            book_name.Location = new Point(212, 75);
            book_name.Name = "book_name";
            book_name.Size = new Size(61, 37);
            book_name.TabIndex = 25;
            book_name.Text = "null";
            // 
            // book_quantity
            // 
            book_quantity.AutoSize = true;
            book_quantity.Font = new Font("Segoe UI", 15.75F);
            book_quantity.Location = new Point(148, 136);
            book_quantity.Name = "book_quantity";
            book_quantity.Size = new Size(47, 30);
            book_quantity.TabIndex = 26;
            book_quantity.Text = "null";
            // 
            // book_price
            // 
            book_price.AutoSize = true;
            book_price.Font = new Font("Segoe UI", 15.75F);
            book_price.Location = new Point(307, 136);
            book_price.Name = "book_price";
            book_price.Size = new Size(47, 30);
            book_price.TabIndex = 27;
            book_price.Text = "null";
            // 
            // publisher_name
            // 
            publisher_name.AutoSize = true;
            publisher_name.Font = new Font("Segoe UI", 15.75F);
            publisher_name.Location = new Point(158, 190);
            publisher_name.Name = "publisher_name";
            publisher_name.Size = new Size(47, 30);
            publisher_name.TabIndex = 29;
            publisher_name.Text = "null";
            // 
            // publisher_des
            // 
            publisher_des.AutoSize = true;
            publisher_des.Font = new Font("Segoe UI", 15.75F);
            publisher_des.Location = new Point(275, 244);
            publisher_des.Name = "publisher_des";
            publisher_des.Size = new Size(47, 30);
            publisher_des.TabIndex = 30;
            publisher_des.Text = "null";
            // 
            // author_name
            // 
            author_name.AutoSize = true;
            author_name.Font = new Font("Segoe UI", 15.75F);
            author_name.Location = new Point(136, 299);
            author_name.Name = "author_name";
            author_name.Size = new Size(47, 30);
            author_name.TabIndex = 31;
            author_name.Text = "null";
            // 
            // author_des
            // 
            author_des.AutoSize = true;
            author_des.Font = new Font("Segoe UI", 15.75F);
            author_des.Location = new Point(253, 349);
            author_des.Name = "author_des";
            author_des.Size = new Size(47, 30);
            author_des.TabIndex = 32;
            author_des.Text = "null";
            // 
            // category_name
            // 
            category_name.AutoSize = true;
            category_name.Font = new Font("Segoe UI", 15.75F);
            category_name.Location = new Point(154, 404);
            category_name.Name = "category_name";
            category_name.Size = new Size(47, 30);
            category_name.TabIndex = 33;
            category_name.Text = "null";
            // 
            // category_des
            // 
            category_des.AutoSize = true;
            category_des.Font = new Font("Segoe UI", 15.75F);
            category_des.Location = new Point(272, 461);
            category_des.Name = "category_des";
            category_des.Size = new Size(47, 30);
            category_des.TabIndex = 34;
            category_des.Text = "null";
            // 
            // update_alert
            // 
            update_alert.AutoSize = true;
            update_alert.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            update_alert.ForeColor = Color.DarkRed;
            update_alert.Location = new Point(44, 529);
            update_alert.Name = "update_alert";
            update_alert.Size = new Size(88, 32);
            update_alert.TabIndex = 36;
            update_alert.Text = "label11";
            update_alert.Visible = false;
            // 
            // publisher_cbb
            // 
            publisher_cbb.DisplayMember = "Text";
            publisher_cbb.Font = new Font("Microsoft Sans Serif", 15.75F);
            publisher_cbb.FormattingEnabled = true;
            publisher_cbb.Location = new Point(1068, 185);
            publisher_cbb.Name = "publisher_cbb";
            publisher_cbb.Size = new Size(160, 33);
            publisher_cbb.TabIndex = 37;
            publisher_cbb.ValueMember = "Value";
            publisher_cbb.Visible = false;
            // 
            // category_cbb
            // 
            category_cbb.DisplayMember = "Text";
            category_cbb.Font = new Font("Microsoft Sans Serif", 15.75F);
            category_cbb.FormattingEnabled = true;
            category_cbb.Location = new Point(1068, 412);
            category_cbb.Name = "category_cbb";
            category_cbb.Size = new Size(160, 33);
            category_cbb.TabIndex = 38;
            category_cbb.ValueMember = "Value";
            category_cbb.Visible = false;
            // 
            // author_cbb
            // 
            author_cbb.DisplayMember = "Text";
            author_cbb.Font = new Font("Microsoft Sans Serif", 15.75F);
            author_cbb.FormattingEnabled = true;
            author_cbb.Location = new Point(1068, 294);
            author_cbb.Name = "author_cbb";
            author_cbb.Size = new Size(160, 33);
            author_cbb.TabIndex = 39;
            author_cbb.ValueMember = "Value";
            author_cbb.Visible = false;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id_lbl.ForeColor = Color.Red;
            id_lbl.Location = new Point(44, 31);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(61, 37);
            id_lbl.TabIndex = 41;
            id_lbl.Text = "null";
            id_lbl.Visible = false;
            // 
            // publisherId_lbl
            // 
            publisherId_lbl.AutoSize = true;
            publisherId_lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publisherId_lbl.ForeColor = Color.Red;
            publisherId_lbl.Location = new Point(352, 183);
            publisherId_lbl.Name = "publisherId_lbl";
            publisherId_lbl.Size = new Size(61, 37);
            publisherId_lbl.TabIndex = 43;
            publisherId_lbl.Text = "null";
            publisherId_lbl.Visible = false;
            // 
            // authorId_lbl
            // 
            authorId_lbl.AutoSize = true;
            authorId_lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorId_lbl.ForeColor = Color.Red;
            authorId_lbl.Location = new Point(352, 292);
            authorId_lbl.Name = "authorId_lbl";
            authorId_lbl.Size = new Size(61, 37);
            authorId_lbl.TabIndex = 45;
            authorId_lbl.Text = "null";
            authorId_lbl.Visible = false;
            // 
            // categoryId_lbl
            // 
            categoryId_lbl.AutoSize = true;
            categoryId_lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryId_lbl.ForeColor = Color.Red;
            categoryId_lbl.Location = new Point(352, 399);
            categoryId_lbl.Name = "categoryId_lbl";
            categoryId_lbl.Size = new Size(61, 37);
            categoryId_lbl.TabIndex = 47;
            categoryId_lbl.Text = "null";
            categoryId_lbl.Visible = false;
            // 
            // BookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 616);
            Controls.Add(categoryId_lbl);
            Controls.Add(authorId_lbl);
            Controls.Add(publisherId_lbl);
            Controls.Add(id_lbl);
            Controls.Add(author_cbb);
            Controls.Add(category_cbb);
            Controls.Add(publisher_cbb);
            Controls.Add(update_alert);
            Controls.Add(category_des);
            Controls.Add(category_name);
            Controls.Add(author_des);
            Controls.Add(author_name);
            Controls.Add(publisher_des);
            Controls.Add(publisher_name);
            Controls.Add(book_price);
            Controls.Add(book_quantity);
            Controls.Add(book_name);
            Controls.Add(menu_link);
            Controls.Add(update_book_detail);
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
            Controls.Add(label1);
            Controls.Add(bookDetail_banner);
            Name = "BookDetail";
            Text = "Book Detail";
            FormClosed += detailForm_closing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookDetail_banner;
        private Label label1;
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
        private Button update_book_detail;
        private LinkLabel menu_link;
        private Label book_name;
        private Label book_quantity;
        private Label book_price;
        private Label publisher_name;
        private Label publisher_des;
        private Label author_name;
        private Label author_des;
        private Label category_name;
        private Label category_des;
        private Label update_alert;
        private ComboBox publisher_cbb;
        private ComboBox category_cbb;
        private ComboBox author_cbb;
        private Label id_lbl;
        private Label publisherId_lbl;
        private Label authorId_lbl;
        private Label categoryId_lbl;
    }
}
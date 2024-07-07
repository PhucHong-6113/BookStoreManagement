namespace PresentationObject.Books
{
    partial class AddBook
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
            addBook_banner = new Label();
            bookName_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            name_txt = new TextBox();
            price_txt = new TextBox();
            quantity_txt = new TextBox();
            money_icon = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            publisher_cbb = new ComboBox();
            author_cbb = new ComboBox();
            category_cbb = new ComboBox();
            menu_link = new LinkLabel();
            submit = new Button();
            SuspendLayout();
            // 
            // addBook_banner
            // 
            addBook_banner.AutoSize = true;
            addBook_banner.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addBook_banner.Location = new Point(129, 9);
            addBook_banner.Name = "addBook_banner";
            addBook_banner.Size = new Size(245, 65);
            addBook_banner.TabIndex = 10;
            addBook_banner.Text = "Add Book";
            // 
            // bookName_lbl
            // 
            bookName_lbl.AutoSize = true;
            bookName_lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            bookName_lbl.Location = new Point(40, 104);
            bookName_lbl.Name = "bookName_lbl";
            bookName_lbl.Size = new Size(77, 30);
            bookName_lbl.TabIndex = 13;
            bookName_lbl.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 14;
            label1.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(50, 253);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 15;
            label2.Text = "Price:";
            // 
            // name_txt
            // 
            name_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            name_txt.Location = new Point(141, 105);
            name_txt.Name = "name_txt";
            name_txt.PlaceholderText = "Insert new Book name...";
            name_txt.Size = new Size(329, 31);
            name_txt.TabIndex = 16;
            // 
            // price_txt
            // 
            price_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            price_txt.Location = new Point(141, 254);
            price_txt.Name = "price_txt";
            price_txt.PlaceholderText = "...";
            price_txt.Size = new Size(100, 31);
            price_txt.TabIndex = 17;
            // 
            // quantity_txt
            // 
            quantity_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            quantity_txt.Location = new Point(141, 174);
            quantity_txt.Name = "quantity_txt";
            quantity_txt.PlaceholderText = "insert number...";
            quantity_txt.Size = new Size(161, 31);
            quantity_txt.TabIndex = 18;
            // 
            // money_icon
            // 
            money_icon.AutoSize = true;
            money_icon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            money_icon.Location = new Point(247, 255);
            money_icon.Name = "money_icon";
            money_icon.Size = new Size(25, 30);
            money_icon.TabIndex = 19;
            money_icon.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(27, 417);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 20;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(5, 491);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 21;
            label4.Text = "Publisher:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(12, 334);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 22;
            label5.Text = "Category:";
            // 
            // publisher_cbb
            // 
            publisher_cbb.Font = new Font("Microsoft Sans Serif", 15.75F);
            publisher_cbb.FormattingEnabled = true;
            publisher_cbb.Location = new Point(141, 492);
            publisher_cbb.Name = "publisher_cbb";
            publisher_cbb.Size = new Size(329, 33);
            publisher_cbb.TabIndex = 38;
            publisher_cbb.Visible = false;
            // 
            // author_cbb
            // 
            author_cbb.Font = new Font("Microsoft Sans Serif", 15.75F);
            author_cbb.FormattingEnabled = true;
            author_cbb.Location = new Point(141, 414);
            author_cbb.Name = "author_cbb";
            author_cbb.Size = new Size(329, 33);
            author_cbb.TabIndex = 39;
            author_cbb.Visible = false;
            // 
            // category_cbb
            // 
            category_cbb.DropDownStyle = ComboBoxStyle.Simple;
            category_cbb.DropDownWidth = 328;
            category_cbb.Font = new Font("Microsoft Sans Serif", 15.75F);
            category_cbb.FormattingEnabled = true;
            category_cbb.Location = new Point(141, 335);
            category_cbb.Name = "category_cbb";
            category_cbb.Size = new Size(329, 33);
            category_cbb.TabIndex = 40;
            category_cbb.Visible = false;
            // 
            // menu_link
            // 
            menu_link.AutoSize = true;
            menu_link.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_link.Location = new Point(27, 566);
            menu_link.Name = "menu_link";
            menu_link.Size = new Size(66, 25);
            menu_link.TabIndex = 41;
            menu_link.TabStop = true;
            menu_link.Text = "cancel";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaption;
            submit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit.Location = new Point(349, 551);
            submit.Name = "submit";
            submit.Size = new Size(121, 55);
            submit.TabIndex = 42;
            submit.Text = "Add!!";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 618);
            Controls.Add(submit);
            Controls.Add(menu_link);
            Controls.Add(category_cbb);
            Controls.Add(author_cbb);
            Controls.Add(publisher_cbb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(money_icon);
            Controls.Add(quantity_txt);
            Controls.Add(price_txt);
            Controls.Add(name_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookName_lbl);
            Controls.Add(addBook_banner);
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addBook_banner;
        private Label bookName_lbl;
        private Label label1;
        private Label label2;
        private TextBox name_txt;
        private TextBox price_txt;
        private TextBox quantity_txt;
        private Label money_icon;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox publisher_cbb;
        private ComboBox author_cbb;
        private ComboBox category_cbb;
        private LinkLabel menu_link;
        private Button submit;
    }
}
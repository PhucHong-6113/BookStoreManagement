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
            label2.Location = new Point(40, 253);
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
            price_txt.Size = new Size(100, 31);
            price_txt.TabIndex = 17;
            // 
            // quantity_txt
            // 
            quantity_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            quantity_txt.Location = new Point(141, 174);
            quantity_txt.Name = "quantity_txt";
            quantity_txt.Size = new Size(100, 31);
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
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 590);
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
    }
}
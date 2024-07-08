namespace PresentationObject.Books
{
    partial class UpdateBook
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
            submit = new Button();
            menu_link = new LinkLabel();
            money_icon = new Label();
            quantity_txt = new TextBox();
            price_txt = new TextBox();
            name_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            bookName_lbl = new Label();
            updateBook_banner = new Label();
            label3 = new Label();
            oldName_txt = new TextBox();
            oldQuan_txt = new TextBox();
            oldPrice_txt = new TextBox();
            label4 = new Label();
            bookId_lbl = new Label();
            SuspendLayout();
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaption;
            submit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit.Location = new Point(487, 317);
            submit.Name = "submit";
            submit.Size = new Size(121, 55);
            submit.TabIndex = 58;
            submit.Text = "Add!!";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // menu_link
            // 
            menu_link.AutoSize = true;
            menu_link.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_link.Location = new Point(71, 347);
            menu_link.Name = "menu_link";
            menu_link.Size = new Size(66, 25);
            menu_link.TabIndex = 57;
            menu_link.TabStop = true;
            menu_link.Text = "cancel";
            menu_link.LinkClicked += menu_link_LinkClicked;
            // 
            // money_icon
            // 
            money_icon.AutoSize = true;
            money_icon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            money_icon.Location = new Point(262, 255);
            money_icon.Name = "money_icon";
            money_icon.Size = new Size(25, 30);
            money_icon.TabIndex = 50;
            money_icon.Text = "$";
            // 
            // quantity_txt
            // 
            quantity_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            quantity_txt.Location = new Point(156, 174);
            quantity_txt.Name = "quantity_txt";
            quantity_txt.PlaceholderText = "updated number...";
            quantity_txt.Size = new Size(181, 31);
            quantity_txt.TabIndex = 49;
            // 
            // price_txt
            // 
            price_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            price_txt.Location = new Point(156, 254);
            price_txt.Name = "price_txt";
            price_txt.PlaceholderText = "...";
            price_txt.Size = new Size(100, 31);
            price_txt.TabIndex = 48;
            // 
            // name_txt
            // 
            name_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            name_txt.Location = new Point(156, 105);
            name_txt.Name = "name_txt";
            name_txt.PlaceholderText = "updated Book name...";
            name_txt.Size = new Size(329, 31);
            name_txt.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(65, 253);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 46;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(27, 173);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 45;
            label1.Text = "Quantity:";
            // 
            // bookName_lbl
            // 
            bookName_lbl.AutoSize = true;
            bookName_lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            bookName_lbl.Location = new Point(55, 104);
            bookName_lbl.Name = "bookName_lbl";
            bookName_lbl.Size = new Size(77, 30);
            bookName_lbl.TabIndex = 44;
            bookName_lbl.Text = "Name:";
            // 
            // updateBook_banner
            // 
            updateBook_banner.AutoSize = true;
            updateBook_banner.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateBook_banner.Location = new Point(394, 9);
            updateBook_banner.Name = "updateBook_banner";
            updateBook_banner.Size = new Size(317, 65);
            updateBook_banner.TabIndex = 43;
            updateBook_banner.Text = "Update Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(566, 106);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 59;
            label3.Text = "Old Data:";
            // 
            // oldName_txt
            // 
            oldName_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            oldName_txt.Location = new Point(698, 107);
            oldName_txt.Name = "oldName_txt";
            oldName_txt.PlaceholderText = "...";
            oldName_txt.Size = new Size(329, 31);
            oldName_txt.TabIndex = 60;
            // 
            // oldQuan_txt
            // 
            oldQuan_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            oldQuan_txt.Location = new Point(698, 174);
            oldQuan_txt.Name = "oldQuan_txt";
            oldQuan_txt.PlaceholderText = "...";
            oldQuan_txt.Size = new Size(181, 31);
            oldQuan_txt.TabIndex = 61;
            // 
            // oldPrice_txt
            // 
            oldPrice_txt.Font = new Font("Microsoft Sans Serif", 15.75F);
            oldPrice_txt.Location = new Point(698, 252);
            oldPrice_txt.Name = "oldPrice_txt";
            oldPrice_txt.PlaceholderText = "...";
            oldPrice_txt.Size = new Size(100, 31);
            oldPrice_txt.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(804, 251);
            label4.Name = "label4";
            label4.Size = new Size(25, 30);
            label4.TabIndex = 63;
            label4.Text = "$";
            // 
            // bookId_lbl
            // 
            bookId_lbl.AutoSize = true;
            bookId_lbl.Location = new Point(12, 116);
            bookId_lbl.Name = "bookId_lbl";
            bookId_lbl.Size = new Size(38, 15);
            bookId_lbl.TabIndex = 64;
            bookId_lbl.Text = "label5";
            bookId_lbl.Visible = false;
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 403);
            Controls.Add(bookId_lbl);
            Controls.Add(label4);
            Controls.Add(oldPrice_txt);
            Controls.Add(oldQuan_txt);
            Controls.Add(oldName_txt);
            Controls.Add(label3);
            Controls.Add(submit);
            Controls.Add(menu_link);
            Controls.Add(money_icon);
            Controls.Add(quantity_txt);
            Controls.Add(price_txt);
            Controls.Add(name_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookName_lbl);
            Controls.Add(updateBook_banner);
            Name = "UpdateBook";
            Text = "UpdateBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private LinkLabel menu_link;
        private Label money_icon;
        private TextBox quantity_txt;
        private TextBox price_txt;
        private TextBox name_txt;
        private Label label2;
        private Label label1;
        private Label bookName_lbl;
        private Label updateBook_banner;
        private Label label3;
        private TextBox oldName_txt;
        private TextBox oldQuan_txt;
        private TextBox oldPrice_txt;
        private Label label4;
        private Label bookId_lbl;
    }
}
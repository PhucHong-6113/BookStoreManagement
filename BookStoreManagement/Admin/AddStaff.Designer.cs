namespace PresentationObject.Admin
{
    partial class AddStaff
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
            fullName_txt = new TextBox();
            email_txt = new TextBox();
            password_txt = new TextBox();
            addBook_banner = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            submit = new Button();
            menu_link = new LinkLabel();
            SuspendLayout();
            // 
            // fullName_txt
            // 
            fullName_txt.Location = new Point(161, 137);
            fullName_txt.Name = "fullName_txt";
            fullName_txt.Size = new Size(269, 23);
            fullName_txt.TabIndex = 0;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(161, 197);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(269, 23);
            email_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(161, 261);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(269, 23);
            password_txt.TabIndex = 2;
            // 
            // addBook_banner
            // 
            addBook_banner.AutoSize = true;
            addBook_banner.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addBook_banner.Location = new Point(129, 20);
            addBook_banner.Name = "addBook_banner";
            addBook_banner.Size = new Size(239, 65);
            addBook_banner.TabIndex = 11;
            addBook_banner.Text = "Add Staff";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 143);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 12;
            label1.Text = "FullName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 199);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 13;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 263);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaption;
            submit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit.Location = new Point(195, 334);
            submit.Name = "submit";
            submit.Size = new Size(121, 55);
            submit.TabIndex = 43;
            submit.Text = "Add!!";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // menu_link
            // 
            menu_link.AutoSize = true;
            menu_link.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_link.Location = new Point(42, 349);
            menu_link.Name = "menu_link";
            menu_link.Size = new Size(66, 25);
            menu_link.TabIndex = 44;
            menu_link.TabStop = true;
            menu_link.Text = "cancel";
            menu_link.LinkClicked += menu_link_LinkClicked;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 401);
            Controls.Add(menu_link);
            Controls.Add(submit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addBook_banner);
            Controls.Add(password_txt);
            Controls.Add(email_txt);
            Controls.Add(fullName_txt);
            Name = "AddStaff";
            Text = "AddStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fullName_txt;
        private TextBox email_txt;
        private TextBox password_txt;
        private Label addBook_banner;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button submit;
        private LinkLabel menu_link;
    }
}
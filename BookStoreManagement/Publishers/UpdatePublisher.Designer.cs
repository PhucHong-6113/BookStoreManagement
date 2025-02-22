﻿namespace PresentationObject.Publishers
{
    partial class UpdatePublisher
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            txtDescription = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 40);
            label1.TabIndex = 0;
            label1.Text = "Update Publisher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 293);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 5;
            label6.Text = "PhoneNumber";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(155, 298);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(199, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(155, 239);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(199, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(155, 84);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(199, 23);
            txtID.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(155, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(279, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // UpdatePublisher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 397);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdatePublisher";
            Text = "UpdatePublisher";
            Load += UpdatePublisher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPhoneNumber;
        private TextBox txtDescription;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnSave;
        private Button btnClear;
    }
}
namespace PresentationObject.Authors
{
    partial class AddAuthor
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
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnAdd = new Button();
            label5 = new Label();
            txtAge = new NumericUpDown();
            txtDiscription = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 169);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtDiscription);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(408, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 654);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(320, 546);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 546);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(183, 24);
            label5.Name = "label5";
            label5.Size = new Size(186, 40);
            label5.TabIndex = 7;
            label5.Text = "Add Author";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(260, 290);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(240, 39);
            txtAge.TabIndex = 6;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(260, 203);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(240, 39);
            txtDiscription.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(260, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 39);
            txtName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 290);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 2;
            label4.Text = "Author age: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 206);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 1;
            label3.Text = "Author discription: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 118);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 0;
            label2.Text = "Author name: ";
            // 
            // AddAuthor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 50, 66);
            ClientSize = new Size(1342, 757);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAuthor";
            Text = "AddAuthor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDiscription;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Button btnAdd;
        private Label label5;
        private NumericUpDown txtAge;
    }
}
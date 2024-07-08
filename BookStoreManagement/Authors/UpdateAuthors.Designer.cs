namespace PresentationObject.Authors
{
    partial class UpdateAuthors
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAge = new NumericUpDown();
            txtDescription = new TextBox();
            txtName = new TextBox();
            cbId = new ComboBox();
            btnClose = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 50, 66);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(cbId);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnUpdate);
            panel1.Location = new Point(152, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 680);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(9, 413);
            label4.Name = "label4";
            label4.Size = new Size(68, 40);
            label4.TabIndex = 9;
            label4.Text = "Age";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(9, 282);
            label3.Name = "label3";
            label3.Size = new Size(161, 40);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(9, 169);
            label2.Name = "label2";
            label2.Size = new Size(94, 40);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 53);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(176, 417);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(277, 39);
            txtAge.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(176, 282);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(277, 39);
            txtDescription.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(176, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 39);
            txtName.TabIndex = 3;
            // 
            // cbId
            // 
            cbId.FormattingEnabled = true;
            cbId.Location = new Point(176, 53);
            cbId.Name = "cbId";
            cbId.Size = new Size(277, 40);
            cbId.TabIndex = 2;
            cbId.SelectedIndexChanged += cbId_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(303, 610);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(65, 610);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateAuthors
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(840, 862);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateAuthors";
            Text = "UpdateAuthors";
            Load += UpdateAuthors_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button btnUpdate;
        private Label label2;
        private Label label1;
        private NumericUpDown txtAge;
        private TextBox txtDescription;
        private TextBox txtName;
        private ComboBox cbId;
        private Label label4;
        private Label label3;
    }
}
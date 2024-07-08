namespace PresentationObject.Authors
{
    partial class DeleteAuthor
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
            btnX = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnX
            // 
            btnX.Location = new Point(1069, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(73, 46);
            btnX.TabIndex = 0;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(606, 463);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 46);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(318, 463);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(318, 144);
            txtId.Name = "txtId";
            txtId.Size = new Size(484, 39);
            txtId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(244, 141);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // DeleteAuthor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 50, 66);
            ClientSize = new Size(1142, 645);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnX);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteAuthor";
            Text = "DeleteAuthor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnX;
        private Button btnClose;
        private Button btnDelete;
        private TextBox txtId;
        private Label label1;
    }
}
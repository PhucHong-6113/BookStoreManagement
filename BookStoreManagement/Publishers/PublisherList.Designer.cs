namespace PresentationObject.Publishers
{
    partial class PublisherList
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
            dgvPublisher = new DataGridView();
            label1 = new Label();
            grbSearch = new GroupBox();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            grbTask = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            btnCreate = new Button();
            grbPublisherInfo = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtDescription = new TextBox();
            txtPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).BeginInit();
            grbSearch.SuspendLayout();
            grbTask.SuspendLayout();
            grbPublisherInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPublisher
            // 
            dgvPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublisher.Location = new Point(434, 170);
            dgvPublisher.Name = "dgvPublisher";
            dgvPublisher.Size = new Size(354, 270);
            dgvPublisher.TabIndex = 0;
            dgvPublisher.SelectionChanged += dgvPublisher_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 32);
            label1.TabIndex = 1;
            label1.Text = "Publisher Management";
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(label2);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(txtSearch);
            grbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbSearch.Location = new Point(434, 92);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(354, 69);
            grbSearch.TabIndex = 2;
            grbSearch.TabStop = false;
            grbSearch.Text = " Search ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 34);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Keyword";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(66, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            // 
            // grbTask
            // 
            grbTask.Controls.Add(btnDelete);
            grbTask.Controls.Add(btnUpdate);
            grbTask.Controls.Add(btnRefresh);
            grbTask.Controls.Add(btnCreate);
            grbTask.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbTask.Location = new Point(12, 367);
            grbTask.Name = "grbTask";
            grbTask.Size = new Size(413, 73);
            grbTask.TabIndex = 3;
            grbTask.TabStop = false;
            grbTask.Text = " Tasks ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(108, 28);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 37);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(312, 28);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 37);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(6, 28);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(96, 37);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // grbPublisherInfo
            // 
            grbPublisherInfo.Controls.Add(label7);
            grbPublisherInfo.Controls.Add(label6);
            grbPublisherInfo.Controls.Add(label5);
            grbPublisherInfo.Controls.Add(label4);
            grbPublisherInfo.Controls.Add(label3);
            grbPublisherInfo.Controls.Add(txtID);
            grbPublisherInfo.Controls.Add(txtName);
            grbPublisherInfo.Controls.Add(txtEmail);
            grbPublisherInfo.Controls.Add(txtDescription);
            grbPublisherInfo.Controls.Add(txtPhoneNumber);
            grbPublisherInfo.Location = new Point(9, 87);
            grbPublisherInfo.Name = "grbPublisherInfo";
            grbPublisherInfo.Size = new Size(411, 274);
            grbPublisherInfo.TabIndex = 4;
            grbPublisherInfo.TabStop = false;
            grbPublisherInfo.Text = " Info ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 244);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 14;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 156);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 83);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 54);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 11;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 25);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(251, 23);
            txtID.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 23);
            txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(154, 109);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 130);
            txtDescription.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(154, 245);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(251, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // PublisherList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbPublisherInfo);
            Controls.Add(grbTask);
            Controls.Add(grbSearch);
            Controls.Add(label1);
            Controls.Add(dgvPublisher);
            Name = "PublisherList";
            Text = "PublisherList";
            Load += PublisherList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).EndInit();
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            grbTask.ResumeLayout(false);
            grbPublisherInfo.ResumeLayout(false);
            grbPublisherInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPublisher;
        private Label label1;
        private GroupBox grbSearch;
        private TextBox txtSearch;
        private GroupBox grbTask;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
        private Button btnCreate;
        private Button btnSearch;
        private Label label2;
        private GroupBox grbPublisherInfo;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtDescription;
        private TextBox txtPhoneNumber;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
namespace PresentationObject.Admin
{
    partial class StaffList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffList));
            add_button = new Button();
            status_button = new Button();
            dgv_staff = new DataGridView();
            search_txt = new TextBox();
            search_btn = new Button();
            user_count_label = new Label();
            menu_btn = new Button();
            hello_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_staff).BeginInit();
            SuspendLayout();
            // 
            // add_button
            // 
            add_button.Location = new Point(668, 116);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 67);
            add_button.TabIndex = 1;
            add_button.Text = "Add Staff";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // status_button
            // 
            status_button.Location = new Point(668, 284);
            status_button.Name = "status_button";
            status_button.Size = new Size(75, 67);
            status_button.TabIndex = 2;
            status_button.Text = "Change Status";
            status_button.UseVisualStyleBackColor = true;
            status_button.Click += status_button_Click;
            // 
            // dgv_staff
            // 
            dgv_staff.AllowUserToAddRows = false;
            dgv_staff.AllowUserToDeleteRows = false;
            dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_staff.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_staff.Location = new Point(12, 116);
            dgv_staff.MultiSelect = false;
            dgv_staff.Name = "dgv_staff";
            dgv_staff.ReadOnly = true;
            dgv_staff.RowHeadersVisible = false;
            dgv_staff.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_staff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_staff.Size = new Size(569, 235);
            dgv_staff.TabIndex = 3;
            // 
            // search_txt
            // 
            search_txt.Location = new Point(290, 75);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(229, 23);
            search_txt.TabIndex = 4;
            // 
            // search_btn
            // 
            search_btn.BackgroundImage = (Image)resources.GetObject("search_btn.BackgroundImage");
            search_btn.BackgroundImageLayout = ImageLayout.Stretch;
            search_btn.Location = new Point(534, 66);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(47, 32);
            search_btn.TabIndex = 8;
            search_btn.UseVisualStyleBackColor = true;
            // 
            // user_count_label
            // 
            user_count_label.AutoSize = true;
            user_count_label.Location = new Point(17, 94);
            user_count_label.Name = "user_count_label";
            user_count_label.Size = new Size(16, 15);
            user_count_label.TabIndex = 9;
            user_count_label.Text = "...";
            // 
            // menu_btn
            // 
            menu_btn.BackColor = SystemColors.Highlight;
            menu_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_btn.ForeColor = SystemColors.ButtonHighlight;
            menu_btn.Location = new Point(648, 12);
            menu_btn.Name = "menu_btn";
            menu_btn.Size = new Size(113, 65);
            menu_btn.TabIndex = 10;
            menu_btn.Text = "Back to menu";
            menu_btn.UseVisualStyleBackColor = false;
            menu_btn.Click += menu_btn_Click;
            // 
            // hello_lbl
            // 
            hello_lbl.AutoSize = true;
            hello_lbl.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hello_lbl.Location = new Point(17, 30);
            hello_lbl.Name = "hello_lbl";
            hello_lbl.Size = new Size(120, 47);
            hello_lbl.TabIndex = 11;
            hello_lbl.Text = "label1";
            // 
            // StaffList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 363);
            Controls.Add(hello_lbl);
            Controls.Add(menu_btn);
            Controls.Add(user_count_label);
            Controls.Add(search_btn);
            Controls.Add(search_txt);
            Controls.Add(dgv_staff);
            Controls.Add(status_button);
            Controls.Add(add_button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffList";
            Text = "Library";
            ((System.ComponentModel.ISupportInitialize)dgv_staff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button add_button;
        private Button status_button;
        private DataGridView dgv_staff;
        private TextBox search_txt;
        private Button search_btn;
        private Label user_count_label;
        private Button menu_btn;
        private Label hello_lbl;
    }
}
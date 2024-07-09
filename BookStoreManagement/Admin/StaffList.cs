using DataAccessObject.Repository;
using PresentationObject.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationObject.Admin
{
    public partial class StaffList : Form
    {
        UserRepository _userRepository;
        private Form _loginScreen;
        public StaffList(string name, Form previousForm)
        {
            _userRepository = new UserRepository();
            _loginScreen = previousForm;
            InitializeComponent();
            try
            {
                refreshData();
                dgv_staff.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK);
                dgv_staff.DataSource = null;
                dgv_staff.DataSource = _userRepository.GetUsers(a => a != null);
            }
            hello_lbl.Text = "Hello" + name;
        }

        private void refreshData()
        {
            dgv_staff.DataSource = null;
            dgv_staff.DataSource = _userRepository.GetUsers
                (u => (u.FullName.Contains(search_txt.Text) ||
                       u.Email.Contains(search_txt.Text) ||
                       u.Role.Contains(search_txt.Text) ||
                       u.Status.Contains(search_txt.Text)) &&
                      u.Role != "Admin")
                .Select(u => new
                {
                    u.UserId,
                    u.FullName,
                    u.Email,
                    u.Role,
                    u.Status,
                }).ToList();
            if (search_txt.Text == "")
            {
                user_count_label.Text = (_userRepository.CountUsers() + " users existed!!");
            }
            else
            {
                user_count_label.Text = (dgv_staff.RowCount + " user(s) match your search!!");
            }
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            _loginScreen.Show();
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff(this);
            addStaff.Show();
            addStaff.Closed += delegate
            {
                _userRepository = new();
                refreshData();
            };
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            if (dgv_staff.SelectedRows.Count > 0)
            {
                int selectedBookId = Convert.ToInt32(dgv_staff.CurrentRow.Cells["UserId"].Value);
                try
                {
                    var user = _userRepository.GetUserById(selectedBookId);
                    if (user != null)
                    {
                        string newStatus = user.Status == "Active" ? "Disabled" : "Active";
                        DialogResult result = MessageBox.Show("Are you sure you want to change the status of " + user.FullName + " to " + newStatus + "?"
                    , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _userRepository.UpdateUserStatus(selectedBookId, newStatus);
                            MessageBox.Show($"User status updated to {newStatus}!", "Success");
                            refreshData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}

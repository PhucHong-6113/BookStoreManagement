using BusinessObject.Models;
using DataAccessObject.Repository;
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
    public partial class AddStaff : Form
    {
        private Form _previousform;
        UserRepository _userRepository;
        public AddStaff(Form previousform)
        {
            _previousform = previousform;
            _userRepository = new UserRepository();
            InitializeComponent();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullName_txt.Text) ||
                string.IsNullOrEmpty(password_txt.Text) ||
                string.IsNullOrEmpty(email_txt.Text))
            {
                MessageBox.Show("All fields must be filled!", "Notice!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    _userRepository.AddUser(new User
                    {
                        FullName = fullName_txt.Text,
                        Password = password_txt.Text,
                        Email = email_txt.Text,
                        Role = "Staff",
                        Status = "Active"
                    });
                    MessageBox.Show("Successfully added a new user!", "Success");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void menu_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _previousform.Show();
            this.Close();
        }
    }
}

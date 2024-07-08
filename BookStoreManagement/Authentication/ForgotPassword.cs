using BookStoreManagement;
using BusinessObject.Models;
using BusinessObject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationObject
{
    public partial class ForgotPassword : Form
    {
        protected readonly UserRepository userRepository;
        public ForgotPassword()
        {

            userRepository = new UserRepository();
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userId = textBox1.Text;
            var resultReset = userRepository.GetAll().FirstOrDefault(x => x.UserId == int.Parse(userId));
            if (resultReset != null)
            {
                var newPassword = textBox2.Text;
                var confirmPassword = textBox3.Text;

                if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(confirmPassword))
                {
                    if (newPassword == confirmPassword)
                    {
                        userRepository.UpdateUserPassword(int.Parse(userId), newPassword);
                        MessageBox.Show("Password updated successfully. Please login with your new password.");
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Confirm password does not match.");
                    }
                }
                else
                {
                    MessageBox.Show("You must fill all the required fields.");
                }
            }
            else
            {
                MessageBox.Show("UserId not found!");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

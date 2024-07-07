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
            var newPassword = textBox2.Text;
            var confirmPassword = textBox3.Text;
            var resultReset = userRepository.GetAll().FirstOrDefault();
        }
    }
}

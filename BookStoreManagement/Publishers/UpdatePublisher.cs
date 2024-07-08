using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationObject.Publishers
{
    public partial class UpdatePublisher : Form
    {
        public int? PublisherId { get; set; }
        private PublisherRepository repo = new();

        public UpdatePublisher()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UpdatePublisher_Load(object sender, EventArgs e)
        {
            var publisher = repo.GetPublisher((int)PublisherId);
            txtID.Text = publisher.PublisherId.ToString();
            txtName.Text = publisher.PublisherName;
            txtEmail.Text = publisher.PublisherEmail;
            txtDescription.Text = publisher.PublisherDescription;
            txtPhoneNumber.Text = publisher.PublisherPhoneNo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          
            try
            {
                if (!repo.UpdatePublisher(new Publisher
                {
                    PublisherId = int.Parse(txtID.Text.Trim()),
                    PublisherName = txtName.Text.Trim(),
                    PublisherEmail = txtEmail.Text.Trim(),
                    PublisherDescription = txtEmail.Text.Trim(),
                    PublisherPhoneNo = txtPhoneNumber.Text.Trim(),
                }))
                    MessageBox.Show("Invalid Input");
                Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

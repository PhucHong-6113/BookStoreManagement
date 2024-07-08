using BusinessObject.Models;
using DataAccessObject;

// test commit
namespace PresentationObject.Publishers
{
    public partial class AddPublisher : Form
    {
        public int? PublisherId { get; set; }
        private PublisherRepository repo = new();

        public AddPublisher()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Publisher publisher = new()
                {
                    //PublisherId = int.Parse(txtID.Text.Trim()),
                    PublisherName = txtName.Text.Trim(),
                    PublisherEmail = txtEmail.Text.Trim(),
                    PublisherDescription = txtEmail.Text.Trim(),
                    PublisherPhoneNo = txtPhoneNumber.Text.Trim(),
                };
                //if (repo.PublisherExists(publisher.PublisherId) == false)
                //{
                    repo.AddPublisher(publisher);
                    Close();
                //}
                //else
                //{
                //    MessageBox.Show("The ID is already existed!!", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch
            {
                MessageBox.Show("Invalid input!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

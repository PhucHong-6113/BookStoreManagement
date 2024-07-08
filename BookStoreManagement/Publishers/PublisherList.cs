using BusinessObject;
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
    public partial class PublisherList : Form
    {
        private Form _menuScreen;
        private PublisherRepository repository = new PublisherRepository();

        public PublisherList(Form previousForm)
        {
            InitializeComponent();
            _menuScreen = previousForm;
        }
        private void ClearInfo()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void RefreshData()
        {
            repository = new PublisherRepository();
            var result = repository.GetAllPublishers();
            dgvPublisher.DataSource = null;
            dgvPublisher.DataSource = result;
        }

        private void PublisherList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("The Publisher ID is invalid!\nPlease select a row in the grid to edit", "Invalid Publisher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //open update form
            UpdatePublisher updateForm = new UpdatePublisher();
            updateForm.PublisherId = int.Parse(txtID.Text);
            updateForm.ShowDialog();
            RefreshData();
            ClearInfo();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            //open create form
            AddPublisher addForm = new AddPublisher();
            addForm.PublisherId = null;
            addForm.ShowDialog();
            RefreshData();
            ClearInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) == true)
            {
                MessageBox.Show("The search keyword is required!", "Search keyword required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = repository.Search(txtSearch.Text.Trim());
            dgvPublisher.DataSource = null;
            dgvPublisher.DataSource = result;
        }

        private void dgvPublisher_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPublisher.SelectedRows.Count > 0)
            {
                var selectedPublisher = (Publisher)dgvPublisher.SelectedRows[0].DataBoundItem;
                txtID.Text = selectedPublisher.PublisherId.ToString();
                txtName.Text = selectedPublisher.PublisherName;
                txtEmail.Text = selectedPublisher.PublisherEmail;
                txtDescription.Text = selectedPublisher.PublisherDescription;
                txtPhoneNumber.Text = selectedPublisher.PublisherPhoneNo;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("The Publisher ID is invalid!", "Invalid Publisher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            repository.DeletePublisher(id);
            //refresh
            RefreshData();
            ClearInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _menuScreen.Show();
            this.Close();
        }
    }
}

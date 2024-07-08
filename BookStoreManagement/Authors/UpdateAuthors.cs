using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationObject.Authors
{
    public partial class UpdateAuthors : Form
    {
        DataAccessObject.DAO.AuthorsDAO authorsDAO = new DataAccessObject.DAO.AuthorsDAO();
        private bool isUpdating = false;
        public UpdateAuthors()
        {
            InitializeComponent();
        }

        private void UpdateAuthors_Load(object sender, EventArgs e)
        {
            loadAuthorId();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loadAuthorId()
        {
            var authors = authorsDAO.getListAuthors().Select(x => x.AuthorId).ToList();
            cbId.Items.Clear();
            cbId.Items.AddRange(authors.Cast<object>().ToArray());
          

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbId.SelectedItem == null)
            {
                MessageBox.Show("Please select an author ID.");
                return;
            }

            Author author = new Author();
            try
            {
                author.AuthorName = txtName.Text;
                author.AuthorDescription = txtDescription.Text;
                author.AuthorAge = int.Parse(txtAge.Text);

                int selectedId;
                if (int.TryParse(cbId.SelectedItem.ToString(), out selectedId))
                {
                    authorsDAO.updateAuthor(selectedId, author);
                    MessageBox.Show("Author updated successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid author ID selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the author: " + ex.Message);
            }
        }
        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            try
            {
                if (cbId.SelectedItem != null)
                {
                    int selectedId;
                    if (int.TryParse(cbId.SelectedItem.ToString(), out selectedId))
                    {
                        var author = authorsDAO.getAuthorById(selectedId);

                        if (author != null)
                        {
                            txtName.Text = author.AuthorName;
                            txtDescription.Text = author.AuthorDescription;
                            txtAge.Text = author.AuthorAge.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid author ID selected.");
                    }
                }
            }
            finally
            {
                isUpdating = false;
            }
        }
    }
    
}

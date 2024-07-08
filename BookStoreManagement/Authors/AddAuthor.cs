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
    public partial class AddAuthor : Form
    {
        DataAccessObject.DAO.AuthorsDAO dao = new DataAccessObject.DAO.AuthorsDAO();
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {   Author author = new Author();
                author.AuthorName = txtName.Text;
                author.AuthorDescription = txtDiscription.Text;
                author.AuthorAge = int.Parse(txtAge.Text);

                dao.addAuthor(author);
                MessageBox.Show("Add author successfully");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

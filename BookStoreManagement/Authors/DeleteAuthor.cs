using DataAccessObject.DAO;
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
    public partial class DeleteAuthor : Form
    {
        AuthorsDAO _authorDAO;
        public DeleteAuthor()
        {
            InitializeComponent();
            _authorDAO = new AuthorsDAO();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            try
            {
                if (txtId.Text != null)
                {
                    if (MessageBox.Show("Do you want to delete author " + id + " ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _authorDAO.deleteAuthorById(int.Parse(txtId.Text));
                        MessageBox.Show("Author deleted successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

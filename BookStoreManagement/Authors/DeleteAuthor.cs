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
        public DeleteAuthor()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            DataAccessObject.DAO.AuthorsDAO authorsDAO = new DataAccessObject.DAO.AuthorsDAO();
            try
            {
                if (txtId.Text != null)
                {
                    if (MessageBox.Show("Do you want to delete author " + id + " ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        authorsDAO.deleteAuthorById(id);
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

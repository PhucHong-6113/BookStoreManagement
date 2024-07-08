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

    public partial class FrmManageAuthors : Form
    {
        DataAccessObject.DAO.AuthorsDAO dao = new DataAccessObject.DAO.AuthorsDAO();
        private Form _menuScreen;
        public FrmManageAuthors(Form menuScreen)
        {
            InitializeComponent();
            _menuScreen = menuScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmManageAuthors_Load(object sender, EventArgs e)
        {
            loadAuthors();
        }

        public void loadAuthors()
        {
            try
            {
                var authors = dao.getListAuthors();
                if (authors != null)
                {
                    dgAuthors.DataSource = null; // Reset the data source
                    dgAuthors.DataSource = authors;
                    dgAuthors.Refresh(); // Refresh the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading authors: {ex.Message}");
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.MdiParent = this.MdiParent;
            addAuthor.Show();

        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            DeleteAuthor deleteAuthor = new DeleteAuthor();
            deleteAuthor.MdiParent = this.MdiParent;
            deleteAuthor.Show();

        }

        private void btnUpdateAuthor_Click_1(object sender, EventArgs e)
        {
            UpdateAuthors updateAuthor = new UpdateAuthors();
            updateAuthor.MdiParent = this.MdiParent;
            updateAuthor.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var authors = dao.findAuthorByName(txtSearch.Text);
                dgAuthors.DataSource = authors;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadAuthors();
        }

        private void dgAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var authors = dao.findAuthorByName(txtSearch.Text);
                dgAuthors.DataSource = authors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            _menuScreen.Show();
            this.Close();
        }
    }
}

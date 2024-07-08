using DataAccessObject;
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
using static PresentationObject.Books.BookList;

namespace PresentationObject.Categories
{
    public partial class CategoryList : Form
    {
        private Form _menuScreen;
        CategoryRepository _categoryRepository;
        public CategoryList(Form menuScreen)
        {
            _categoryRepository = new CategoryRepository();
            InitializeComponent();
            dgvCategory.ReadOnly = true;
            this.Load += CategoryList_Load;
            _menuScreen = menuScreen;
        }
        private void RefreshData()
        {
            var searchTerm = tbSearchCategory.Text;
            dgvCategory.DataSource = null;
            dgvCategory.DataSource = _categoryRepository.GetCategories(b => b.CategoryName.Contains(searchTerm))
                .Select(b => new
                {
                    CategoryId = b.CategoryId,
                    CategoryName = b.CategoryName,
                    CategoryDescription = b.CategoryDescription,
                }).ToList();


        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void searchCategory_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            AddCategories addCategories = new AddCategories();
            addCategories.Show();
            addCategories.Closed += delegate
            {
                _categoryRepository = new();
                RefreshData();
            };
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                if (!dgvCategory.Columns.Contains("CategoryId"))
                {
                    MessageBox.Show("The 'BookId' column is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int selectedCategoryId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["CategoryId"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + _categoryRepository.GetCategory(selectedCategoryId).CategoryName + "?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _categoryRepository.DeleteCategory(selectedCategoryId);
                    RefreshData();
                }
            }
        }

        private void updateCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {

                int selectedCategoryId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["CategoryId"].Value);
                UpdateCategory updateCategory = new UpdateCategory(selectedCategoryId, this);
                updateCategory.Show();
                updateCategory.Closed += delegate
                {
                    _categoryRepository = new();
                    RefreshData();
                };
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _menuScreen.Show();
            this.Close();
        }
    }
}

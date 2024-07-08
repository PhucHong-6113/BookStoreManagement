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

namespace PresentationObject.Categories
{
    public partial class UpdateCategory : Form
    {
        private Form _categoryList;
        CategoryRepository _categoryRepository;
        public UpdateCategory(int id, Form previousForm)
        {
            _categoryRepository = new CategoryRepository();
            InitializeComponent();
            categoryId_lb.Text = id.ToString();
            oldName_txt.Text = _categoryRepository.GetCategory(id).CategoryName;
            oldDescription_txt.Text = _categoryRepository.GetCategory(id).CategoryDescription;

            _categoryList = previousForm;
        }

        private void updateSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateCategoryName.Text) ||
                string.IsNullOrEmpty(updateCategoryDescription.Text))
            {
                MessageBox.Show("Invalid Input! All fields are required.", "Notice!", MessageBoxButtons.OK);
                return;
            }

            try
            {
                int categoryId = int.Parse(categoryId_lb.Text);
                Category updateCategory = _categoryRepository.GetCategory(categoryId);

                if (updateCategory != null)
                {
                    updateCategory.CategoryName = updateCategoryName.Text;
                    updateCategory.CategoryDescription = updateCategoryDescription.Text;

                    _categoryRepository.UpdateCategory(updateCategory);
                    MessageBox.Show("successfully update category", "Nice!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK);
            }
        }

        private void menu_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _categoryList.Show();
            this.Close();
        }
    }
}

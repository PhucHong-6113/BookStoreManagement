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
    public partial class AddCategories : Form
    {
        CategoryRepository _categoryRepository;
        public AddCategories()
        {
            _categoryRepository = new CategoryRepository();
            InitializeComponent();
        }

        private void submitAdd_Click(object sender, EventArgs e)
        {
            if (
                addNameCategory.Text == null ||
                addDescriptionCategory.Text == null
                )
            {
                MessageBox.Show("Invalid Input!", "Notice!", MessageBoxButtons.OK);
            }else
            {
                _categoryRepository.AddCategory(new Category
                {
                    CategoryName = addNameCategory.Text,
                    CategoryDescription = addDescriptionCategory.Text
                });
                MessageBox.Show("Successfully add a new Category!", "Cool");
                this.Close();
            }
        }
    }
}

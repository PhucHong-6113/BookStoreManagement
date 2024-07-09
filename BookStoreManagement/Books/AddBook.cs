using BusinessObject.Models;
using DataAccessObject;
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

namespace PresentationObject.Books
{
    public partial class AddBook : Form
    {
        BookRepository _bookRepository;
        CategoryRepository _categoryRepository;
        AuthorsDAO _authorRepository;
        PublisherRepository _publisherRepository;
        Form _bookList;
        public AddBook(Form previousForm)
        {
            _bookRepository = new BookRepository();
            _categoryRepository = new CategoryRepository();
            _publisherRepository = new PublisherRepository();
            _authorRepository = new AuthorsDAO();
            InitializeComponent();

            publisher_cbb.DataSource = _publisherRepository.GetAllPublishers().Select(p => new { Text = p.PublisherName, Value = p.PublisherId }).ToList();
            publisher_cbb.DisplayMember = "Text";
            publisher_cbb.ValueMember = "Value";

            category_cbb.DataSource = _categoryRepository.GetCategories().Select(c => new { Text = c.CategoryName, Value = c.CategoryId }).ToList();
            category_cbb.DisplayMember = "Text";
            category_cbb.ValueMember = "Value";

            author_cbb.DataSource = _authorRepository.getListAuthors().Select(a => new { Text = a.AuthorName, Value = a.AuthorId }).ToList();
            author_cbb.DisplayMember = "Text";
            author_cbb.ValueMember = "Value";

            _bookList = previousForm;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_txt.Text) ||
        string.IsNullOrEmpty(quantity_txt.Text) ||
        string.IsNullOrEmpty(price_txt.Text) ||
        publisher_cbb.SelectedValue == null ||
        category_cbb.SelectedValue == null ||
        author_cbb.SelectedValue == null)
            {
                MessageBox.Show("All Field must be filled!", "Notice!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (int.TryParse(quantity_txt.Text, out int quantity) &&
                        decimal.TryParse(price_txt.Text, out decimal price))
                    {
                        _bookRepository.AddBook(new Book
                        {
                            BookName = name_txt.Text,
                            Quantity = quantity,
                            Price = price,
                            PublisherId = (int)publisher_cbb.SelectedValue,
                            CategoryId = (int)category_cbb.SelectedValue,
                            AuthorId = (int)author_cbb.SelectedValue
                        });
                        MessageBox.Show("Successfully added a new book!", "Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Quantity or Price!", "Error", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

        }

        private void menu_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _bookList.Show();
            this.Close();
        }
    }
}

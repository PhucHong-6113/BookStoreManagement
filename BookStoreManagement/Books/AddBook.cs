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
            if (
                name_txt.Text == null ||
                quantity_txt.Text == null ||
                publisher_cbb.Text == null ||
                category_cbb.Text == null ||
                author_cbb.Text == null ||
                price_txt.Text == null
            )
            {
                MessageBox.Show("Invalid Input!", "Notice!", MessageBoxButtons.OK);
            }
            else
            {
                _bookRepository.AddBook(new Book
                {
                    BookName = name_txt.Text,
                    Quantity = int.Parse(quantity_txt.Text),
                    Price = decimal.Parse(price_txt.Text),
                    PublisherId = (int)publisher_cbb.SelectedValue,
                    CategoryId = (int)category_cbb.SelectedValue,
                    AuthorId = (int)author_cbb.SelectedValue
                });
                MessageBox.Show("Successfully Add a new Book!!", "Yes sir");
                this.Close();
            }

        }

        private void menu_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _bookList.Show();
            this.Close();
        }
    }
}

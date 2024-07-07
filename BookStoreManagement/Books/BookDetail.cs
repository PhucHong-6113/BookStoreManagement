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

namespace PresentationObject
{
    public partial class BookDetail : Form
    {
        BookRepository _bookRepository;
        private Form _bookList;
        public BookDetail(int id, Form previousForm)
        {

            _bookRepository = new BookRepository();
            InitializeComponent();
            _bookList = previousForm;
            refreshData(id);
            update_alert.Visible = true;
        }

        private void refreshData(int id)
        {
            Book selectedBook = _bookRepository.GetBook(id);
            book_name.Text = selectedBook.BookName;
            book_price.Text = selectedBook.Price.ToString();
            book_quantity.Text = selectedBook.Quantity.ToString();
            publisher_name.Text = selectedBook.Publisher.PublisherName;
            publisher_des.Text = selectedBook.Publisher.PublisherDescription;
            author_name.Text = selectedBook.Author.AuthorName;
            author_des.Text = selectedBook.Author.AuthorDescription;
            category_name.Text = selectedBook.Category.CategoryName;
            category_des.Text = selectedBook.Category.CategoryDescription;
        }

        private void change_publisher_Click(object sender, EventArgs e)
        {
            _bookRepository = new BookRepository();
            publisher_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Publisher.PublisherName, Value = b.PublisherId }).ToList();
            publisher_cbb.DisplayMember = "Text";
            publisher_cbb.ValueMember = "Value";
            publisher_cbb.Visible = true;
            //đợi code
        }

        private void change_author_Click(object sender, EventArgs e)
        {
            _bookRepository = new BookRepository();
            author_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Author.AuthorName, Value = b.AuthorId }).ToList();
            author_cbb.DisplayMember = "Text";
            author_cbb.ValueMember = "Value";
            author_cbb.Visible = true;
            //đợi code
        }

        private void change_category_Click(object sender, EventArgs e)
        {
            _bookRepository = new BookRepository();
            category_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Category.CategoryName, Value = b.CategoryId }).ToList();
            category_cbb.DisplayMember = "Text";
            category_cbb.ValueMember = "Value";
            category_cbb.Visible = true;
            //đợi code
        }

        private void menu_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _bookList.Show();
            this.Close();
        }

        private void detailForm_closing(object sender, FormClosedEventArgs e)
        {
            _bookList.Show();
        }

        private void update_book_detail_Click(object sender, EventArgs e)
        {
            update_alert.Text = "Update Successfully!!";
        }
    }
}

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
            id_lbl.Text = selectedBook.BookId.ToString();
            book_name.Text = selectedBook.BookName;
            book_price.Text = selectedBook.Price.ToString();
            book_quantity.Text = selectedBook.Quantity.ToString();
            publisherId_lbl.Text = selectedBook.PublisherId.ToString();
            publisher_name.Text = selectedBook.Publisher.PublisherName;
            publisher_des.Text = selectedBook.Publisher.PublisherDescription;
            authorId_lbl.Text = selectedBook.AuthorId.ToString();
            author_name.Text = selectedBook.Author.AuthorName;
            author_des.Text = selectedBook.Author.AuthorDescription;
            categoryId_lbl.Text = selectedBook.CategoryId.ToString();
            category_name.Text = selectedBook.Category.CategoryName;
            category_des.Text = selectedBook.Category.CategoryDescription;
        }

        private void change_publisher_Click(object sender, EventArgs e)
        {
            update_alert.Visible = false;
            _bookRepository = new BookRepository();
            publisher_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Publisher.PublisherName, Value = b.PublisherId }).Distinct().ToList();
            publisher_cbb.Visible = true;
        }

        private void change_author_Click(object sender, EventArgs e)
        {
            update_alert.Visible = false;
            _bookRepository = new BookRepository();
            author_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Author.AuthorName, Value = b.AuthorId }).Distinct().ToList();
            author_cbb.Visible = true;
        }

        private void change_category_Click(object sender, EventArgs e)
        {
            update_alert.Visible = false;
            _bookRepository = new BookRepository();
            category_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Category.CategoryName, Value = b.CategoryId }).Distinct().ToList();
            category_cbb.Visible = true;
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

            int updatedAuthor = int.Parse(authorId_lbl.Text);
            int updatedPublisher = int.Parse(publisherId_lbl.Text); ;
            int updatedCategory = int.Parse(categoryId_lbl.Text);
            if (author_cbb.Visible)
            {
                if (author_cbb.SelectedValue != null)
                {
                    updatedAuthor = int.Parse(author_cbb.SelectedValue.ToString());
                }
            }

            if (category_cbb.Visible)
            {
                if (category_cbb.SelectedValue != null)
                {
                    updatedCategory = int.Parse(category_cbb.SelectedValue.ToString());
                }
            }

            if (publisher_cbb.Visible)
            {
                if (publisher_cbb.SelectedValue != null)
                {
                    updatedPublisher = int.Parse(publisher_cbb.SelectedValue.ToString());
                }
            }
            Book book = _bookRepository.GetBook(int.Parse(id_lbl.Text));
            book.PublisherId = updatedPublisher;
            book.CategoryId = updatedCategory;
            book.AuthorId = updatedAuthor;

            _bookRepository.UpdateBook(book);
            update_alert.Text = "Update Successfully!!";
            update_alert.Visible = true;
            refreshData(int.Parse(id_lbl.Text));
            this.Refresh();
        }
    }
}

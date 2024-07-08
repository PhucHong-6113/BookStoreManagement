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

namespace PresentationObject.Books
{
    public partial class BookList : Form
    {
        BookRepository _bookRepository;
        private Form _menuScreen;
        public BookList(Form previousForm)
        {
            _bookRepository = new BookRepository();
            InitializeComponent();
            _menuScreen = previousForm;
            try
            {
                refreshData();
                dgv_books.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK);
                dgv_books.DataSource = null;
                dgv_books.DataSource = _bookRepository.GetBooks(a => a != null);
            }
        }

        private void refreshData()
        {
            dgv_books.DataSource = null;
            List<BookViewModel> books = _bookRepository.GetBooks
                (b => b.BookName.Contains(search_txt.Text) ||
                      b.Author.AuthorName.Contains(search_txt.Text) ||
                      b.Category.CategoryName.Contains(search_txt.Text) ||
                      b.Publisher.PublisherName.Contains(search_txt.Text))
                .Select(b => new BookViewModel
                {
                    BookId = b.BookId,
                    BookName = b.BookName,
                    Category = b.Category.CategoryName,
                    Author = b.Author.AuthorName,
                    Publisher = b.Publisher.PublisherName,
                    Quantity = b.Quantity,
                    Price = b.Price,
                }).ToList();
            dgv_books.DataSource = books;
            if (search_txt.Text == "")
            {
                book_count_label.Text = (_bookRepository.CountBooks() + " books existed!!");
            }
            else
            {
                book_count_label.Text = (books.Count() + " book(s) match your search!!");
            }

        }

        private void book_detail_Click(object sender, EventArgs e)
        {
            if (dgv_books.SelectedRows.Count > 0)
            {

                int selectedBookId = Convert.ToInt32(dgv_books.CurrentRow.Cells["BookId"].Value);
                BookDetail bookDetail = new BookDetail(selectedBookId, this);
                bookDetail.Show();
                this.Hide();
                bookDetail.Closed += delegate
                {
                    _bookRepository = new();
                    refreshData();
                };
            }
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this);
            addBook.Show();
            addBook.Closed += delegate
            {
                _bookRepository = new();
                refreshData();
            };
        }

        private void update_book_Click(object sender, EventArgs e)
        {
            if (dgv_books.SelectedRows.Count > 0)
            {
                int selectedBookId = Convert.ToInt32(dgv_books.CurrentRow.Cells["BookId"].Value);
                UpdateBook updateBook = new UpdateBook(selectedBookId, this);
                updateBook.Show();
                updateBook.Closed += delegate
                {
                    _bookRepository = new();
                    refreshData();
                };
            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _menuScreen.Show();
            this.Close();
        }

        private void enter(object sender, KeyEventArgs e)             //No can't do :((
        {
            if (e.KeyCode == Keys.Enter)
            {
                refreshData();
            }
        }

        private void List_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the BookId of the double-clicked row
                int bookId = Convert.ToInt32(dgv_books.Rows[e.RowIndex].Cells["BookId"].Value);

                // Retrieve the selected book details
                Book selectedBook = _bookRepository.GetBook(bookId);

                BookDetail bookDetail = new BookDetail(selectedBook.BookId, this);
                bookDetail.Show();
                this.Hide();
            }
        }

        private void delete_book_Click(object sender, EventArgs e)
        {
            if (dgv_books.SelectedRows.Count > 0)
            {
                int selectedBookId = Convert.ToInt32(dgv_books.CurrentRow.Cells["BookId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + _bookRepository.GetBook(selectedBookId).BookName + "?"
                    , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _bookRepository.DeleteBook(selectedBookId);
                    refreshData();
                }
            }
        }

        public class BookViewModel
        {
            public int BookId { get; set; }
            public string BookName { get; set; }
            public string Category { get; set; } // Assuming CategoryName is a string
            public string Author { get; set; }   // Assuming AuthorName is a string
            public string Publisher { get; set; } // Assuming PublisherName is a string
            public int? Quantity { get; set; }
            public decimal? Price { get; set; }
        }
    }
}

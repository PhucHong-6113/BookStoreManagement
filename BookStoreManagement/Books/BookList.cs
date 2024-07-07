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

        public BookList()
        {
            _bookRepository = new BookRepository();
            InitializeComponent();
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
            dgv_books.DataSource = _bookRepository.GetBooks
                (b => b.BookName.Contains(search_txt.Text) || b.Author.AuthorName.Contains(search_txt.Text) || b.Category.CategoryName.Contains(search_txt.Text) || b.Publisher.PublisherName.Contains(search_txt.Text))
                .Select(b => new
                {
                    b.BookId,
                    b.BookName,
                    Category = b.Category.CategoryName,
                    Author = b.Author.AuthorName,
                    Publisher = b.Publisher.PublisherName,
                    b.Quantity,
                    b.Price,
                }).ToList();
            if (search_txt.Text == "")
            {
                book_count_label.Text = (_bookRepository.CountBooks() + " books existed!!");
            }
            else
            {
                var dataSource = dgv_books.DataSource as IList<object>;
                int count = dataSource?.Count ?? 0;
                book_count_label.Text = (count + " book(s) match your search!!");
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
            }
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuScreen _menuScreen = new MenuScreen();
            //_menuScreen.Show();
            //this.Close();
        }

        private void enter(object sender, KeyEventArgs e)
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
    }
}

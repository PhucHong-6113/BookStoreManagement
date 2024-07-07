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
                (b => b.BookName.Contains(search_txt.Text))
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
            book_count_label.Text = (_bookRepository.CountBooks() + " books existed!!");
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
    }
}

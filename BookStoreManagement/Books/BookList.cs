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
        }
    }
}

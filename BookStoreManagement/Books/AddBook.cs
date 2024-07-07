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
    public partial class AddBook : Form
    {
        BookRepository _bookRepository;
        public AddBook()
        {
            _bookRepository = new BookRepository();
            InitializeComponent();

            publisher_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Publisher.PublisherName, Value = b.PublisherId }).ToList();
            publisher_cbb.DisplayMember = "Text";
            publisher_cbb.ValueMember = "Value";

            category_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Category.CategoryName, Value = b.CategoryId }).ToList();
            category_cbb.DisplayMember = "Text";
            category_cbb.ValueMember = "Value";

            author_cbb.DataSource = _bookRepository.GetBooks().Select(b => new { Text = b.Author.AuthorName, Value = b.AuthorId }).ToList();
            author_cbb.DisplayMember = "Text";
            author_cbb.ValueMember = "Value";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

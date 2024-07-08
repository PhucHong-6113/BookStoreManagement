using PresentationObject.Authors;
using PresentationObject.Books;
using PresentationObject.Categories;
using PresentationObject.Publishers;
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
    public partial class MenuScreen : Form
    {
        private Form _login;
        private string _name;
        public MenuScreen(string name, Form login)
        {
            InitializeComponent();
            _name = name;
            username.Text = _name;
            _login = login;
        }

        private void book_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList(this);
            bookList.FormClosed += new FormClosedEventHandler(form_close);
            bookList.Show();
            this.Hide();

        }

        private void publisher_Click(object sender, EventArgs e)
        {
            PublisherList publisherList = new PublisherList(this);
            publisherList.FormClosed += new FormClosedEventHandler(form_close);
            publisherList.Show();
            this.Hide();
        }

        private void author_Click(object sender, EventArgs e)
        {
            FrmManageAuthors authorList = new FrmManageAuthors(this);
            authorList.FormClosed += new FormClosedEventHandler(form_close);
            authorList.Show();
            this.Hide();
        }

        private void category_Click(object sender, EventArgs e)
        {
            CategoryList categoryList = new CategoryList(this);
            categoryList.FormClosed += new FormClosedEventHandler(form_close);
            categoryList.Show();
            this.Hide();
        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _login.Show();
            this.Close();
        }
    }
}

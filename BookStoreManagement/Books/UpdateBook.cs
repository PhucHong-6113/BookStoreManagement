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
    public partial class UpdateBook : Form
    {
        private Form _bookList;
        protected readonly BookRepository _bookRepository;
        public UpdateBook(int id, Form previousForm)
        {
            _bookRepository = new BookRepository();
            InitializeComponent();
            bookId_lbl.Text = id.ToString();
            oldName_txt.Text = _bookRepository.GetBook(id).BookName;
            oldQuan_txt.Text = _bookRepository.GetBook(id).Quantity.ToString();
            oldPrice_txt.Text = _bookRepository.GetBook(id).Price.ToString();

            _bookList = previousForm;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_txt.Text) ||
        string.IsNullOrEmpty(price_txt.Text) ||
        string.IsNullOrEmpty(quantity_txt.Text))
            {
                MessageBox.Show("Invalid Input! All fields are required.", "Notice!", MessageBoxButtons.OK);
                return;
            }

            // Validate that price and quantity are in correct format
            if (!decimal.TryParse(price_txt.Text, out decimal price) ||
                !int.TryParse(quantity_txt.Text, out int quantity))
            {
                MessageBox.Show("Invalid Input! Price must be a decimal number and Quantity must be an integer.", "Notice!", MessageBoxButtons.OK);
                return;
            }

            try
            {
                // Assuming bookId_lbl.Text is always valid and non-null
                int bookId = int.Parse(bookId_lbl.Text);
                Book updateBook = _bookRepository.GetBook(bookId);

                if (updateBook != null)
                {
                    updateBook.BookName = name_txt.Text;
                    updateBook.Quantity = quantity;
                    updateBook.Price = price;

                    _bookRepository.UpdateBook(updateBook);
                    MessageBox.Show("Successfully Updated Book!", "Success!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void menu_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _bookList.Show();
            this.Close();
        }
    }
}

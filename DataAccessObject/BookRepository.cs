using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class BookRepository : IBookRepository
    {
        BookStoreManagementDbContext _context;

        public BookRepository ()
        {
            _context = new BookStoreManagementDbContext();
        }

        public List<Book> GetBooks(Expression<Func<Book, bool>> predicate)
        {
            return _context.Books
            .Include(b => b.Category)
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .Where(predicate)
            .ToList();
        }

        public List<Book> GetBooks()
        {
            return _context.Books
            .Include(b => b.Category)
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Books
            .Include(b => b.Category)
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefault(b => b.BookId == id);
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public int CountBooks()
        {
            if (_context.Books == null)
            {
                return 0;
            }
            else { return _context.Books.Count(); }
            
        }
    }
}

using BusinessObject.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public interface IBookRepository
    {
        public List<Book> GetBooks(Expression<Func<Book, bool>> predicate);
        public List<Book> GetBooks();
        public Book GetBook(int id);
        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}

using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public partial class AuthorsDAO
    {   BusinessObject.Models.BookStoreManagementDbContext db = new BusinessObject.Models.BookStoreManagementDbContext();
        public List<Author> getListAuthors()
        {

                return db.Authors.ToList();
            
        }

        public Author getAuthorById(int id)
        {
                return db.Authors.Find(id);
        }

        public Boolean deleteAuthorById(int id)
        {
                if(db.Authors.Find(id) == null)
                {
                    throw new Exception("Author not found");
                } else
                {
                    db.Authors.Remove(db.Authors.Find(id));
                    db.SaveChanges();
                    return true;
                }
          
        }

        public Author addAuthor(Author author)
        {
                int id = db.Authors.Max(a => a.AuthorId) + 1;
                author.AuthorId = id;
                db.Authors.Add(author);
                db.SaveChanges();
            return author;
        }

        public Author updateAuthor(int id, Author author)
        {
            var existingAuthor = db.Authors.Find(id);
            if (existingAuthor == null)
            {
                throw new Exception("Author not found");
            }

            try
            {
                existingAuthor.AuthorName = author.AuthorName;
                existingAuthor.AuthorDescription = author.AuthorDescription;
                existingAuthor.AuthorAge = author.AuthorAge;

                db.Authors.Update(existingAuthor);
                db.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception("Error updating author: " + ex.Message);
            }
            return existingAuthor;
        }

        public List<Author> findAuthorByName(string name)
        {
            var authors = db.Authors.Where(a => a.AuthorName.Contains(name)).ToList();
            if (authors.Count == 0)
            {
                throw new Exception("No authors found with the given name.");
            }
            return authors;
        }
    }
}

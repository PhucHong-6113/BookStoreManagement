using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class RepositoryBase<T> where T : class
    {
        BookStoreManagementDbContext _context;
        DbSet<T> _dbSet;

        public RepositoryBase() 
        {
            _context = new BookStoreManagementDbContext();
            _dbSet = _context.Set<T>(); //ko new
        }
        public List<T> GetAll() 
        {
            return _dbSet.ToList();
        }
        public void Add(T item) 
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Update(T item) 
        {
            var tracker = _context.Attach(item);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}

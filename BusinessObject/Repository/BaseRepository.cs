using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Repository
{
    public class BaseRepository<T> where T : class
    {
        protected readonly BookStoreManagementDbContext bookStoreManagementDbContext;
        protected readonly DbSet<T> dbSet;
        public BaseRepository() 
        {
            bookStoreManagementDbContext = new BookStoreManagementDbContext();
            dbSet = bookStoreManagementDbContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return dbSet.ToList();
        }
        public void Delete(T item)
        {
            dbSet.Remove(item);
            bookStoreManagementDbContext.SaveChanges();
        }
        public void Add(T item)
        {
            dbSet.Add(item);
            bookStoreManagementDbContext.SaveChanges();
        }
        public void Update(T item)
        {
            var tracker = bookStoreManagementDbContext.Attach(item);
            tracker.State = EntityState.Modified;
            bookStoreManagementDbContext.SaveChanges();
        }
    }
}

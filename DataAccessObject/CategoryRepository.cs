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
    public class CategoryRepository : ICategoryRepository
    {
        BookStoreManagementDbContext _context;
        public CategoryRepository(BookStoreManagementDbContext context)
        {
            _context = context;
        }
        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(a => a.CategoryId == id);
        }
        public List<Category> GetCategories(Expression<Func<Category, bool>> dele) 
        {
            return _context.Categories.Include(a => a.CategoryId).Where(dele).ToList();
        }
        public bool AddCategory(Category category)
        {
            if(GetCategory(category.CategoryId) == null)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateCategory(Category category)
        {
            var item = _context.Categories.FirstOrDefault(f => f.CategoryId == category.CategoryId);
            if(item != null)
            {
                item.CategoryId = category.CategoryId;
                item.CategoryName = category.CategoryName;
                item.CategoryDescription = category.CategoryDescription;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteCategory(int id)
        {
            Category item = GetCategory(id);
            if(item != null)
            {
                _context.Remove(item);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

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
    public interface ICategoryRepository
    {
        public Category GetCategory(int id);
        public List<Category> GetCategories();
        public List<Category> GetCategories(Expression<Func<Category, bool>> predicate);
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(int id);

    }
}

using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    internal interface ICategoryRepository
    {
        public Category GetCategory(int id);
        public List<Category> GetCategories(Expression<Func<Category, bool>> predicate);
        public bool AddCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int id);

    }
}

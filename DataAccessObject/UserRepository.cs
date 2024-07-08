using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.Repository
{
    public class UserRepository
    {
        protected readonly BookStoreManagementDbContext _context;
        public UserRepository() {
            _context = new BookStoreManagementDbContext();
        }

        public List<User> GetAll()
        {
           return _context.Users.ToList();
        }
        public User GetUserById(int userId)
        {
            return _context.Set<User>().FirstOrDefault(x => x.UserId == userId);
        }
        public void UpdateUserPassword(int userId, string newPassword)
        {
            var user = _context.Set<User>().FirstOrDefault(u => u.UserId == userId);

            if (user != null)
            {
                user.Password = newPassword; // Update the password
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"User with UserId {userId} not found.");
            }
        }
    }
}

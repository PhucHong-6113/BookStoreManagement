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
        public int CountUsers()
        {
            return _context.Users.Count(u => u.Role != "Admin");
        }
        public IEnumerable<User> GetUsers(Func<User, bool> predicate)
        {
            return _context.Users.Where(predicate);
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
        public void UpdateUserStatus(int userId, string status)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                user.Status = status;
                _context.SaveChanges();
            }
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}

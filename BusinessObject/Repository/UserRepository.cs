using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        protected readonly BookStoreManagementDbContext _context;
        public UserRepository() : base() {
            _context = new BookStoreManagementDbContext();
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

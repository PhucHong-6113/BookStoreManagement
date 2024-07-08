using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject
{
    public class PublisherRepository
    {
        private BookStoreManagementDbContext _context;

        public PublisherRepository() 
        { 
            _context = new BookStoreManagementDbContext(); 
        }

        //take all publisher
        public List<Publisher> GetAllPublishers()
        {
            return _context.Publishers.ToList();
        }

        //lấy 1 publisher dựa vào publisherId
        public Publisher? GetPublisher(int publisherId)
        {
            return _context.Publishers.Find(publisherId);
        }

        public void AddPublisher(Publisher publisher) 
        { 
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public bool UpdatePublisher(Publisher publisher) 
        {
            var item = _context.Publishers.FirstOrDefault(p => p.PublisherId == publisher.PublisherId);
            if (item != null)
            {
                item.PublisherName = publisher.PublisherName;
                item.PublisherEmail = publisher.PublisherEmail;
                item.PublisherDescription = publisher.PublisherDescription;
                item.PublisherPhoneNo = publisher.PublisherPhoneNo;
                //_context.Publishers.Update(item);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeletePublisher(int publisherId) 
        { 
            var publisher = _context.Publishers.FirstOrDefault(p => p.PublisherId == publisherId);
            if(publisher != null)
            {
                _context.Publishers.Remove(publisher);
                _context.SaveChanges();
            }
        }

        public List<Publisher> Search(string keyword)
        {
            return GetAllPublishers().Where(p => p.PublisherName.ToLower().Contains(keyword.ToLower()) || p.PublisherDescription.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public bool PublisherExists(int id)
        {
            if (GetPublisher(id) == null)
                return false;
            else return true;
        }
    }
}

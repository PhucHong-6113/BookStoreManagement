using BusinessObject.Models;

namespace DataAccessObject
{
    internal interface IPublisherRepository
    {
        public Publisher GetPublisher(int id);
        public List<Publisher> GetAllPublishers();
        public void AddPublisher(Publisher publisher);
        public bool UpdatePublicsher(Publisher publisher);
        public void DeletePublicsher(int id);
        public List <Publisher> Search(string keyword);
        public bool PublisherExists(int id);
    }
}

using Microsoft.EntityFrameworkCore;
using WebApi_10.Data;
using WebApi_10.Entities;
using WebApi_10.Respositories.Abstract;

namespace WebApi_10.Respositories.Concrete
{
    public class CustomerRepository : ICustomersRepository
    {
        private readonly Store2DBContext _dBContext;

        public CustomerRepository(Store2DBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public void Add(Customers entity)
        {
            _dBContext.Customers.Add(entity);
            _dBContext.SaveChanges();
        }

        public void Delete(Customers entity)
        {
            _dBContext.Customers.Remove(entity);
            _dBContext.SaveChanges();
        }

        public Customers Get(int id)
        {
            var Customer = _dBContext.Customers.SingleOrDefault(x => x.Id == id);
            return Customer;
        }

        public IEnumerable<Customers> GetAll()
        {
            var Customer = _dBContext.Customers;
            return Customer;
        }

        public void Update(Customers entity)
        {
            _dBContext.Update(entity);
            _dBContext.SaveChanges();
        }
    }
}

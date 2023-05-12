using WebApi_10.Data;
using WebApi_10.Entities;
using WebApi_10.Respositories.Abstract;

namespace WebApi_10.Respositories.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Store2DBContext _dBContext;

        public OrderRepository(Store2DBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public void Add(Orders entity)
        {
            _dBContext.Orders.Add(entity);
            _dBContext.SaveChanges();
        }

        public void Delete(Orders entity)
        {
            _dBContext.Orders.Remove(entity);
            _dBContext.SaveChanges();
        }

        public Orders Get(int id)
        {
            var Customer = _dBContext.Orders.SingleOrDefault(x => x.Id == id);
            return Customer;
        }

        public IEnumerable<Orders> GetAll()
        {
            var Customer = _dBContext.Orders;
            return Customer;
        }

        public void Update(Orders entity)
        {
            _dBContext.Update(entity);
            _dBContext.SaveChanges();
        }
    }
}

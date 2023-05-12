using WebApi_10.Entities;
using WebApi_10.Respositories.Abstract;
using WebApi_10.Services.Abstract;

namespace WebApi_10.Services.Concrete
{
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomersRepository _customerservices;
        
        public CustomerService(ICustomersRepository customerservices)
        {
            _customerservices = customerservices;
        }
        
        public void Add(Customers entity)
        {
            _customerservices.Add(entity);
        }

        public void Delete(int id)
        {
           _customerservices.Delete(_customerservices.Get(id));
        }

        public Customers Get(int id) => _customerservices.Get(id);

        public IEnumerable<Customers> GetAll()
        {
            return _customerservices.GetAll();
        }

        public void Update(Customers entity)
        {
           _customerservices.Update(entity);
        }
    }
}

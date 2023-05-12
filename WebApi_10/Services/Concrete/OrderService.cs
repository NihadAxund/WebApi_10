using WebApi_10.Entities;
using WebApi_10.Respositories.Abstract;
using WebApi_10.Services.Abstract;

namespace WebApi_10.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderService;

        public OrderService(IOrderRepository orderService)
        {
            _orderService = orderService;
        }

        public void Add(Orders entity)
        {
          _orderService.Add(entity);
        }

        public void Delete(int id)
        { _orderService.Delete(_orderService.Get(id)); }
        

        public Orders Get(int id) => _orderService.Get(id);

        public IEnumerable<Orders> GetAll()
        {
            return _orderService.GetAll();
        }

        public void Update(Orders entity)
        {
            _orderService.Update(entity);
        }
    }
}

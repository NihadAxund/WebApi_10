using System.ComponentModel.DataAnnotations;
using WebApi_10.Entities;

namespace WebApi_10.Dtos
{
    public class OrderDto
    {
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public OrderDto() { }
        public OrderDto(Orders orders)
        {
            OrderDate = orders.OrderDate;
            ProductId = orders.ProductId;
            CustomerId = orders.CustomerId;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApi_10.Entities
{
    public class Orders
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}

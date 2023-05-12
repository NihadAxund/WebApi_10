using System.ComponentModel.DataAnnotations;

namespace WebApi_10.Entities
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}

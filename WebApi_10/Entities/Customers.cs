using System.ComponentModel.DataAnnotations;

namespace WebApi_10.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Surname { get; set; } = " ";
    }
}

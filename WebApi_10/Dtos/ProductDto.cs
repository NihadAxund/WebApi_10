using WebApi_10.Entities;

namespace WebApi_10.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public ProductDto() { }
        public ProductDto(Products Product) {
            Name = Product.Name;
            Price = Product.Price;
            Discount = Product.Discount;
        }

    }
}

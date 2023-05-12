using Microsoft.EntityFrameworkCore;
using WebApi_10.Entities;

namespace WebApi_10.Data
{
    public class Store2DBContext:DbContext
    {
        public Store2DBContext(DbContextOptions<Store2DBContext> options)
            : base(options)
        {

        }


        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}

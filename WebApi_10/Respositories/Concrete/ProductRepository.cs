using WebApi_10.Data;
using WebApi_10.Entities;
using WebApi_10.Respositories.Abstract;

namespace WebApi_10.Respositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly Store2DBContext _dBContext;

        public ProductRepository(Store2DBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public void Add(Products entity)
        {
            _dBContext.Products.Add(entity);
            _dBContext.SaveChanges();
        }

        public void Delete(Products entity)
        {
            _dBContext.Products.Remove(entity);
            _dBContext.SaveChanges();
        }

        public Products Get(int id)
        {
           var product = _dBContext.Products.SingleOrDefault(x => x.Id == id);
            return product;
        }

        public IEnumerable<Products> GetAll() => _dBContext.Products;

        public void Update(Products entity)
        {
            _dBContext.Update(entity);
            _dBContext.SaveChanges();
        }
    }
}

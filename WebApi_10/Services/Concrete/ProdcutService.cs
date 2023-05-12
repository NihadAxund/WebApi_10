using WebApi_10.Entities;
using WebApi_10.Respositories.Abstract;
using WebApi_10.Services.Abstract;

namespace WebApi_10.Services.Concrete
{
    public class ProdcutService : IProductService
    {
        private readonly IProductRepository _productService;

        public ProdcutService(IProductRepository studentRepository)
        {
            _productService = studentRepository;
        }
        public void Add(Products entity)
        {
            _productService.Add(entity);
        }

        public void Delete(int id)
        {
          var item = _productService.Get(id);
            _productService.Delete(item);
        }

        public Products Get(int id)
        {
           return _productService.Get(id);
        }

        public IEnumerable<Products> GetAll()
        {
            return _productService.GetAll();
        }

        public void Update(Products entity)
        {
            _productService.Update(entity);
        }
    }
}

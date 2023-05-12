using Microsoft.AspNetCore.Mvc;
using WebApi_10.Dtos;
using WebApi_10.Entities;
using WebApi_10.Services.Abstract;

namespace WebApi_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        [HttpGet("Best")]
        public IEnumerable<ProductDto> GetHigherDiscounts()
        {
            var items = _productService.GetAll().OrderByDescending(a => a.Price);
            var dataToReturn = items.Select(a =>
            {
                return new ProductDto(a);
            });
            return dataToReturn;
        }
        [HttpGet("Worst")]
        public IEnumerable<ProductDto> GetLessDiscounts()
        {
            var items = _productService.GetAll().OrderBy(a=>a.Price);
            var dataToReturn = items.Select(a =>
            {
                return new ProductDto(a);
            });
            return dataToReturn;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Products value)
        {
            try
            {
                _productService.Update(value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            var items = _productService.GetAll();
            var ReturnType = items.Select(a =>
            {
                return new ProductDto(a);
            });
            return ReturnType;

        }

        [HttpGet("{id}")]
        public ProductDto Get(int id)
        {
            var item = _productService.Get(id);
            var v = new ProductDto(item);
            return v;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Products value)
        {
            try
            {
                _productService.Add(value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _productService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

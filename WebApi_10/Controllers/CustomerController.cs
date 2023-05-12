using Microsoft.AspNetCore.Mvc;
using WebApi_10.Dtos;
using WebApi_10.Entities;
using WebApi_10.Services.Abstract;

namespace WebApi_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
     

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customers value)
        {
            try
            {
                _customerServices.Update(value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IEnumerable<CustomersDto> Get()
        {
            var items = _customerServices.GetAll();
            var ReturnType = items.Select(a =>
            {
                return new CustomersDto(a);
            });
            return ReturnType;

        }

        [HttpGet("{id}")]
        public CustomersDto Get(int id)
        {
            var item = _customerServices.Get(id);
            var v = new CustomersDto(item);
            return v;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Customers value)
        {
            try
            {
                _customerServices.Add(value);
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
                _customerServices.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


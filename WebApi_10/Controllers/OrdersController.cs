using Microsoft.AspNetCore.Mvc;
using WebApi_10.Dtos;
using WebApi_10.Entities;
using WebApi_10.Services.Abstract;

namespace WebApi_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly IOrderService _OrderServices;

        public OrdersController(IOrderService OrderServices)
        {
            _OrderServices = OrderServices;
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Orders value)
        {
            try
            {
                _OrderServices.Update(value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IEnumerable<OrderDto> Get()
        {
            var items = _OrderServices.GetAll();
            var ReturnType = items.Select(a =>
            {
                return new OrderDto(a);
            });
            return ReturnType;

        }

        [HttpGet("{id}")]
        public OrderDto Get(int id)
        {
            var item = _OrderServices.Get(id);
            var v = new OrderDto(item);
            return v;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Orders value)
        {
            try
            {
                _OrderServices.Add(value);
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
                _OrderServices.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}

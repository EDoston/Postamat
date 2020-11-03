using DeliveryToPostamt.Data;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryToPostamt.Controllers
{
    [ApiController]
    [Route("api/postmat/")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService _orderService)
        {
            this._orderService = _orderService;
        }

        [HttpPost]
        public IActionResult AddOrder(AddOrderDto addOrderDto)
        {
            _orderService.AddOrder(addOrderDto);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOrder([FromBody] UpdateOrderDto updateOrderDto)
        {
            bool state = _orderService.UpdateOrder(updateOrderDto);
            if(state == false) {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _orderService.GetOrderById(id);
            if(order == null) {
                return NotFound();
            }
            return Ok(order);
        }      
    }
}
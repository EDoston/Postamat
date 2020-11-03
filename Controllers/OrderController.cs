using DeliveryToPostamt.Data;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;
using DeliveryToPostamt.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryToPostamt.Controllers
{
    [ApiController]
    [Route("api/order/")]
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
        public IActionResult UpdateOrder(UpdateOrderDto updateOrderDto)
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
        [HttpDelete("{id}")]
        public IActionResult CancelOrder(int id)
        {
            bool state = _orderService.DeleteOrder(id);
            if(state == false)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
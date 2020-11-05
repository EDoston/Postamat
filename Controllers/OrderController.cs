using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryToPostamt.Controllers
{
    [ApiController]
    [Route("api/order/")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IPostmatService _postmatService;
        public OrderController(IOrderService _orderService, IPostmatService _postmatService)
        {
            this._postmatService = _postmatService;
            this._orderService = _orderService;
        }

        [HttpPost]
        public IActionResult Add(AddOrderDto addOrderDto)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var postmat = _postmatService.Get(addOrderDto.PostamatId);
            if (postmat == null) {
                return NotFound();
            }
            
            if(postmat.State == false) {
                ModelState.AddModelError("Postamat registration","запрещено");
                return BadRequest(ModelState);
            }

            _orderService.Add(addOrderDto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateOrderDto updateOrderDto)
        {
            bool state = _orderService.Update(updateOrderDto);
            if(state == false) {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _orderService.GetById(id);
            if(order == null) {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult Cancel(int id)
        {
            bool state = _orderService.Cancel(id);
            if(state == false)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
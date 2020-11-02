using System.Collections.Generic;
using System.Threading.Tasks;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryToPostamt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        
        /// <summary>
        /// Получение заказа по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _orderService.GetOrderById(id));           
        }

        /// <summary>
        /// Добавление нового заказа
        /// </summary>
        /// <param name="newOrder"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOrder(AddOrderDto newOrder)
        {            
            return Ok(await _orderService.AddOrder(newOrder));
        }

        /// <summary>
        /// Обновление заказа
        /// </summary>
        /// <param name="updateOrder"></param>
        /// <returns></returns>
         [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderDto updateOrder)
        {
            ServiceResponse<GetOrderDto> response = await _orderService.UpdateOrder(updateOrder);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponse<List<GetOrderDto>> response = await _orderService.DeleteOrder(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
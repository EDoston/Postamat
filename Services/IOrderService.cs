using System.Collections.Generic;
using System.Threading.Tasks;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Services
{
    public interface IOrderService
    {
        ServiceResponse<GetOrderDto> GetOrderById(int id);
        ServiceResponse<List<GetOrderDto>> AddOrder(AddOrderDto newOrder);
        ServiceResponse<GetOrderDto> UpdateOrder(UpdateOrderDto updateOrder);
        ServiceResponse<List<GetOrderDto>> DeleteOrder(int id);
    }
}
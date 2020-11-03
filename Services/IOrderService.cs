using System.Collections.Generic;
using System.Threading.Tasks;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Services
{
    public interface IOrderService
    {
        GetOrderDto GetOrderById(int id);
        void AddOrder(AddOrderDto newOrder);
        bool UpdateOrder(UpdateOrderDto updateOrder);
        bool DeleteOrder(int id);
    }
}
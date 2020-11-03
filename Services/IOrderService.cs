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
        void UpdateOrder(UpdateOrderDto updateOrder);
        void DeleteOrder(int id);
    }
}
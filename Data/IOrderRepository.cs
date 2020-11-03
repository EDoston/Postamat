using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        bool UpdateOrder(Order order);
        Order GetOrder(int id);
        bool CancelOrder(int id);
    }
}
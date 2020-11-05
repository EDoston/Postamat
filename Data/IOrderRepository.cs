using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public interface IOrderRepository
    {
        void Add(Order order);
        bool Update(Order order);
        Order GetById(int id);
        bool Cancel(int id);
    }
}
using DeliveryToPostamt.Dtos;

namespace DeliveryToPostamt.Services
{
    public interface IOrderService
    {
        GetOrderDto GetById(int id);
        void Add(AddOrderDto newOrder);
        bool Update(UpdateOrderDto updateOrder);
        bool Cancel(int id);
    }
}
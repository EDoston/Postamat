using AutoMapper;
using DeliveryToPostamt.Dtos;

namespace DeliveryToPostamt.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public void AddOrder(AddOrderDto newOrder)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public GetOrderDto GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOrder(UpdateOrderDto updateOrder)
        {
            throw new System.NotImplementedException();
        }
    }
}
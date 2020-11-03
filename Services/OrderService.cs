using AutoMapper;
using DeliveryToPostamt.Data;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository _orderRepository, IMapper _mapper)
        {
            this._orderRepository = _orderRepository;
            this._mapper = _mapper;
        }
        public void AddOrder(AddOrderDto newOrder)
        {
            Order order = _mapper.Map<Order>(newOrder);
            _orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.CancelOrder(id);
        }

        public GetOrderDto GetOrderById(int id)
        {
           return _mapper.Map<GetOrderDto>(_orderRepository.GetOrder(id));
        }
        
        public void UpdateOrder(UpdateOrderDto updateOrder)
        {
            Order order = _mapper.Map<Order>(updateOrder);
        }
    }
}
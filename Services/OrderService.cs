using AutoMapper;
using DeliveryToPostamt.Data;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryToPostamt.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPostmatRepository _postmatRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository _orderRepository, IPostmatRepository _postmatRepository, IMapper _mapper)
        {
            this._orderRepository = _orderRepository;
            this._postmatRepository = _postmatRepository;
            this._mapper = _mapper;
        }
        public void Add(AddOrderDto newOrder)
        {
            Order order = _mapper.Map<Order>(newOrder);        
            _orderRepository.Add(order);
        }
        public bool Update(UpdateOrderDto updateOrder)
        {
            Order order = _mapper.Map<Order>(updateOrder);
            return _orderRepository.Update(order);
        }
        public GetOrderDto GetById(int id)
        {
           Order order = _orderRepository.GetById(id);
           return _mapper.Map<GetOrderDto>(order);
        }
        public bool Cancel(int id)
        {
           return _orderRepository.Cancel(id);
        }
    }
}
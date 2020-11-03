using AutoMapper;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt
{
    public class ApiMappings : Profile
    {
        public ApiMappings()
        {
            this.CreateMap<AddOrderDto, Order>();
            this.CreateMap<Order, GetOrderDto > ();
            this.CreateMap<UpdateOrderDto, Order>();
        }
    }
}
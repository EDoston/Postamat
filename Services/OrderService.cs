using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryToPostamt.Services
{
    /// <summary>
    /// Orders
    /// </summary>
    public class OrderService : IOrderService
    {
         private readonly IMapper _mapper;
         public OrderService(IMapper mapper)
         {
             _mapper = mapper; 
         }
        Repository.repository.IOrderService

         /// <summary>
         /// Добвоение заказа
         /// </summary>
         /// <param name="newOrder"></param>
         /// <returns></returns>
        public  ServiceResponse<List<GetOrderDto>> AddOrder(AddOrderDto newOrder)
        {
            ServiceResponse<List<GetOrderDto>> serviceResponse = new ServiceResponse<List<GetOrderDto>>();
            orders.Add( _mapper.Map<Order>(newOrder));
            serviceResponse.Data = (orders.Select(c => _mapper.Map<GetOrderDto>(c))).ToList();
            return serviceResponse;
        }
        
        /// <summary>
        /// Удаление заказа
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ServiceResponse<List<GetOrderDto>> DeleteOrder(int id)
        {
            ServiceResponse<List<GetOrderDto>> serviceResponse = new ServiceResponse<List<GetOrderDto>>();
            try 
            {
                Order order = orders.FirstOrDefault(c => c.Id == id);
                if(order != null) 
                {
                    orders.Remove(order);

                    serviceResponse.Data = null;
                    serviceResponse.Success = true;
                    serviceResponse.Message = "Successfull";
                }
                else 
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Order not found";
                }
  
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        
        /// <summary>
        /// Получение заказа по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ServiceResponse<GetOrderDto> GetOrderById(int id)
        {
            ServiceResponse<GetOrderDto> serviceResponse = new ServiceResponse<GetOrderDto>();
            serviceResponse.Data =_mapper.Map<GetOrderDto>(orders.FirstOrDefault(c=>c.Id == id));
            return serviceResponse;
        }
        
        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="updateOrder"></param>
        /// <returns></returns>
        public ServiceResponse<GetOrderDto> UpdateOrder(UpdateOrderDto updateOrder)
        {
            ServiceResponse<GetOrderDto> serviceResponse = new ServiceResponse<GetOrderDto>();
            try 
            {
                Order order = orders.FirstOrDefault(c => c.Id == updateOrder.Id);
                order.StateId = updateOrder.StateId;
                order.ContentOrder = updateOrder.ContentOrder;
                order.Price = updateOrder.Price;
                order.PostamatId = updateOrder.PostamatId;
                order.Phone = updateOrder.Phone;
                order.FIO = updateOrder.Phone;

                serviceResponse.Data = _mapper.Map<GetOrderDto>(order);
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
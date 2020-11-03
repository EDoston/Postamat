using System.Collections.Generic;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public class OrderRepository : IOrderRepository
    {
        public static List<Order> orderList = null;
        static OrderRepository() {}
        public void CreateOrder(Order order)
        {
            orderList.Add(order);
        }
        public bool UpdateOrder(Order order)
        {
            var result = orderList.Find(x=> x.Id ==order.Id);
            if(result == null) {
                return false;
            }   
                   
            result.StateId = order.StateId;
            result.ContentOrder = order.ContentOrder;
            result.Price = order.Price;
            result.PostamatId = order.PostamatId;
            result.Phone = order.Phone;
            result.FIO = order.FIO;  

            return false;      
        }
        public Order GetOrder(int id)
        {
            return orderList.Find(x=>x.Id == id);
        }
        public void CancelOrder(int id)
        {
            var result = orderList.Find(x=> x.Id ==id);
            result.StateId = (int)State.Canceled;
        }
    }
}
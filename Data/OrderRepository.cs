using System.Collections.Generic;
using System.Linq;
using DeliveryToPostamt.Dtos;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public class OrderRepository : IOrderRepository
    {
        public static List<Order> orderList = null;
        static OrderRepository() {
            orderList = new List<Order>();
        }
        public void CreateOrder(Order order)
        {
            if (orderList.Count == 0)
            {
                order.Id = 1;
            }   
            else
            {
                order.Id = (orderList[orderList.Count-1].Id) + 1 ;
            }
          
            orderList.Add(order);
        }
        public bool UpdateOrder(Order order)
        {
            var result = orderList.FirstOrDefault(x=> x.Id ==order.Id);
            if(result == null) {
                return false;
            }   

            result.StateId = order.StateId;
            result.ContentOrder = order.ContentOrder;
            result.Price = order.Price;
            result.PostamatId = order.PostamatId;
            result.Phone = order.Phone;
            result.FIO = order.FIO;  

            return true;      
        }      
        public Order GetOrder(int id)
        {
            return orderList.FirstOrDefault(x => x.Id == id);
        }
        public bool CancelOrder(int id)
        {
            var result = orderList.FirstOrDefault(x=> x.Id ==id);
            if(result == null)
            {
                return false;
            }
            result.StateId = (int)State.Canceled;
            return true;
        }
    }
}
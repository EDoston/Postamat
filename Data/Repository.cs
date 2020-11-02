using System.Collections.Generic;
using DeliveryToPostamt.Models;
using System;
using System.Collections;
using System.Text;

namespace DeliveryToPostamt.Data
{
    public class Repository<T> : List<T>
    {
        public static List<Order> repository = null;
        public Repository() {  }
        public static Repository Initialiaze()
        {
            if(repository == null) {
                repository = new Repository();                
            }
            return repository;    
        }
                       
    }
}
//Postamat postamat1 = new Postamat() { Id = 1, Address = "Lermontov st 27", State = true };
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeliveryToPostamt.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public string[] ContentOrder { get; set; }
        public decimal Price { get; set;}
        public int PostamatId { get; set; }
        public Postamat Postamat { get; set; }
        
       
        public string Phone { get; set; }
        public string FIO { get; set; }       
    }
}
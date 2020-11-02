using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Dtos
{
    public class AddOrderDto
    {
        public int StateId { get; set; }
        public State State { get; set; }
        public int[] ContentOrder { get; set; }
        public decimal Price { get; set;}
        public int PostamatId { get; set; }
        public Postamat Postamat { get; set; }
        public string Phone { get; set; }
        public string FIO { get; set; }      
    }
}
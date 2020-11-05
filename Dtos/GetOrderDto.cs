
namespace DeliveryToPostamt.Dtos
{
    public class GetOrderDto
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string[] ContentOrder { get; set; }
        public decimal Price { get; set;}
        public int PostamatId { get; set; }
        public string Phone { get; set; }
        public string FIO { get; set; } 
    }
}
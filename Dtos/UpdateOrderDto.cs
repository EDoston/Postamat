using DeliveryToPostamt.Models;
using System.ComponentModel.DataAnnotations;

namespace DeliveryToPostamt.Dtos
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        [MaxLength(10, ErrorMessage = "ошибка запроса")]
        public string[] ContentOrder { get; set; }
        public decimal Price { get; set;}
        public int PostamatId { get; set; }
        [RegularExpression(@"^\+7\d{3}-\d{3}-\d\d-\d\d$", ErrorMessage = "ошибка запроса")]
        [Phone]
        public string Phone { get; set; }
        public string FIO { get; set; }
    }
}
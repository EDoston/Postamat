using DeliveryToPostamt.Models;
using System.ComponentModel.DataAnnotations;

namespace DeliveryToPostamt.Dtos
{
    public class AddOrderDto
    {
        public int StateId { get; set; }
        public State State { get; set; }
        public string[] ContentOrder { get; set; }
        public decimal Price { get; set;}
        public int PostamatId { get; set; }
        [Required(ErrorMessage = "Поле Phone обязательно для заполнения")]
        [RegularExpression(@"^(?:\+7)\d{10}$", ErrorMessage = "Номер телефона введен неверно")]
        [Phone]
        public string Phone { get; set; }
        public string FIO { get; set; }      
    }
}
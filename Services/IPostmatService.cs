using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Services
{
    public interface IPostmatService
    {
        Postamat Get(string Id);
    }
}
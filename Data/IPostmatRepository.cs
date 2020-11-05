using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public interface IPostmatRepository 
    {
        Postamat GetPostamat(int Id);
    }
}
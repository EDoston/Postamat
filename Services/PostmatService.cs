using DeliveryToPostamt.Data;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Services
{
    public class PostmatService : IPostmatService
    {
        private readonly IPostmatRepository _postmatRepository;
        public PostmatService(IPostmatRepository _postmatRepository)
        {
            this._postmatRepository = _postmatRepository;
        }
        Postamat IPostmatService.Get(int Id)
        {
            return _postmatRepository.GetPostamat(Id);
        }
    }
}
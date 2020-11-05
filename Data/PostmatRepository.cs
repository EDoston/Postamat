using System.Collections.Generic;
using System.Linq;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public class PostmatRepository : IPostmatRepository
    {
         public static List<Postamat> postamatList = null;
                  
         static PostmatRepository() {
             postamatList = new List<Postamat>();
             postamatList.Add(new Postamat(1, "Lermonotov 13", true));
             postamatList.Add(new Postamat(2, "Pushkinskaya 89", false));
         }

         public Postamat GetPostamat(int Id) {
            return postamatList.FirstOrDefault(x=>x.Id == Id);     
         }  
    }
}
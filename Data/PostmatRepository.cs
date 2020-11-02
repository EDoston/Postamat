using System.Collections.Generic;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public class PostmatRepository
    {
         public static List<Postamat> repository = null;
         
         static PostmatRepository() {
             repository = new PostmatRepository();
         }


         
    }
}
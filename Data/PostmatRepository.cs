using System.Collections.Generic;
using DeliveryToPostamt.Models;

namespace DeliveryToPostamt.Data
{
    public class PostmatRepository : IPostmatRepository
    {
        //TODO: Thread Safe list
         public static List<Postamat> postamatList = null;
         
         static PostmatRepository() {
             //TODO: Загрузка из файла
             postamatList = new List<Postamat>();
             postamatList.Add(new Postamat("1", "A 13", true));
             postamatList.Add(new Postamat("2", "B 15", false));
         }
         public Postamat GetPostamat(string Id) {
            return postamatList.Find(x=>x.Id == Id);     
         }  
    }
}
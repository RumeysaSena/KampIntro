using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    
    public class GamerManager : IGamerService
    {
        // Eğer bir sınıfın içerisinde başka bir sınıfı kullanmak istiyorsak asla onu new'leme! 
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız.");
            }            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}

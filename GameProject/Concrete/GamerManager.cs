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
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " Kayıt oldu" + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız." + '\n');
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "'nın kaydı silindi" + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız." + '\n');
            }
        
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "'nın kaydı güncellendi" + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız." + '\n');
            }
            
        }

    }
}

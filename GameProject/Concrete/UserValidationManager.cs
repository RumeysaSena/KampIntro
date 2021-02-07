using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 1994 && gamer.FirstName == "RUMEYSA" && gamer.LastName == "ÖZDEMİR" && gamer.IdentityNumber == 12345)

            {
                return true;
            }
            else if (gamer.Id == 2 && gamer.BirthYear == 2020 && gamer.FirstName == "ZEHRA"&& gamer.LastName == "ZEYREK" && gamer.IdentityNumber == 789456)
            {
                return true;
            }
            else
            {
                return false;
            }
                  
        }
    }
}

          

   


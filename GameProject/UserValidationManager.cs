using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDay==1995 && gamer.FirstName=="MEHMET MESUT" 
                && gamer.LastName=="ATO" && gamer.IndentityNumber==12345678910)
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

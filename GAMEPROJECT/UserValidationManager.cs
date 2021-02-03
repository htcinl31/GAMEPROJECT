using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEPROJECT
{
    class UserValidationManager : IUserValidationService


    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1994 && gamer.FirstName == "HATİCE" && gamer.LastName == "İNAL" && gamer.Id == 1 && gamer.IdentityNumber == 123)
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

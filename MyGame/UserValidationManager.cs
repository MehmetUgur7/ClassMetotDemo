using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear==1987 && player.IdentityNumber==12345 && 
                player.FirstName=="Mehmet" && player.LastName=="Uğur")
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

using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class PlayerManager : IPlayerService
    {
        IUserValidation _userValidation;

        public PlayerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Player player)
        {
            if (_userValidation.Validate(player)==true)
            {
                Console.WriteLine(player.FirstName + " isimli oyuncu kaydı başarıyla oluşturuldu!");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız! Bilgileri kontrol ediniz!");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt başarıyla silindi!");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt başarıyla güncellendi!");
        }

        public bool OrderValidate(Player player)
        {
            if (player.FirstName=="Mehmet")
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

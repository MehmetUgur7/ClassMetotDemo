using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class OrderManager : IOrderservice
    {
        IPlayerService _playerService;

        public OrderManager(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public void AddOrder(Order order, Player player)
        {
            if (_playerService.OrderValidate(player)==true)
            {
                Console.WriteLine(player.FirstName + " isimli oyuncu " + order.GameName + " isimli oyunu satın almıştır.");
            }
        }

        public void DeleteOrder(Order order, Player player)
        {
            if (_playerService.OrderValidate(player) == true)
            {
                Console.WriteLine(player.FirstName + " isimli oyuncu " + order.GameName + " isimli oyunu silmiştir.");
            }
        }

    }
}

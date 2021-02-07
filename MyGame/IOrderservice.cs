using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IOrderservice
    {
        void AddOrder(Order order, Player player);
        void DeleteOrder(Order order, Player player);
    }
}

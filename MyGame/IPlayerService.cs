using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IPlayerService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
        bool OrderValidate(Player player);

    }
}

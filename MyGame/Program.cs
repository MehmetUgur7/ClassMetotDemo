using System;

namespace MyGame
{
    class Program
    {
        public static object CampaignId { get; private set; }

        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Id = 1,
                FirstName = "Mehmet",
                LastName = "Uğur",
                BirthYear = 1987,
                IdentityNumber = 12345
            };

            Order order1 = new Order
            {
                OrderId = 1,
                GameName = "Space Wars",
                Price = 120            
            };

            Campaign campaign1 = new Campaign
            {
                CampaignId = 1,
                CampaignName = "Kış İndirimi",
                DiscountRate = 25
            };
            

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(player1);
            playerManager.Update(player1);
            playerManager.Delete(player1);
                       
            OrderManager orderManager = new OrderManager(new PlayerManager(new UserValidationManager()));
            orderManager.AddOrder(order1, player1);
            orderManager.DeleteOrder(order1, player1);

            CampaignManager campaignManager = new CampaignManager(new OrderManager(new PlayerManager(new UserValidationManager())));
            campaignManager.CampaignAdd(campaign1, order1);
            campaignManager.CampaignUpdate(campaign1, order1);
            campaignManager.CampaignDelete(campaign1, order1);
            
            
        }
    }
}

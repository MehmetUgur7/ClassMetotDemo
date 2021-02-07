using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class CampaignManager : ICampaignService
    {
        IOrderservice _orderService;

        public CampaignManager(IOrderservice orderService)
        {
            _orderService = orderService;
        }

        public void CampaignAdd(Campaign campaign, Order order)
        {
            Console.WriteLine(order.GameName + " isimli oyunda " + campaign.DiscountRate + "% indirimli " + campaign.CampaignName + " başlamıştır!");
        }

        public void CampaignDelete(Campaign campaign, Order order)
        {
            Console.WriteLine(campaign.CampaignName + " başarıyla silindi!");
        }

        public void CampaignUpdate(Campaign campaign, Order order)
        {
            Console.WriteLine(campaign.CampaignName + " başarıyla güncellendi!");
        }
    }
}

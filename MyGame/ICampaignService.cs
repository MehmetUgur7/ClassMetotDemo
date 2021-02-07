using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface ICampaignService
    {
        void CampaignAdd(Campaign campaign, Order order);
        void CampaignDelete(Campaign campaign, Order order);
        void CampaignUpdate(Campaign campaign, Order order);

    }
}

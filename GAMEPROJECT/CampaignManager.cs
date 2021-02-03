using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEPROJECT
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +"Eklendi");

        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Güncellendi");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public class CampaignManager : ICampaignService
    {
        public Campaign Add(Campaign campaign)
        {
            Console.WriteLine("Campaign given below has been added for " + campaign.Gamer.Name + ":\n" + campaign.CampaignId + "\n" +
                campaign.CampaignHeader + "\n" + campaign.CampaignDescription + "\n" + campaign.DiscountRatio + "\n\n");

            return campaign;
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign given below has been updated for " + campaign.Gamer.Name + ":\n" + campaign.CampaignId + "\n" +
                campaign.CampaignHeader + "\n" + campaign.CampaignDescription + "\n" + campaign.DiscountRatio + "\n\n");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign given below has been deleted for " + campaign.Gamer.Name + ":\n" + campaign.CampaignId + "\n" +
                campaign.CampaignHeader + "\n" + campaign.CampaignDescription + "\n" + campaign.DiscountRatio + "\n\n");
        }

    }
}

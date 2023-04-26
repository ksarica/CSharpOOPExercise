using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Exercise.Entities
{
    public class Campaign
    {
        public int CampaignId
        {
            get; set;
        }

        public string CampaignHeader
        {
            get; set;
        }

        public string CampaignDescription
        {
            get; set;
        }

        public double DiscountRatio
        {
            get; set;
        }

        public Gamer Gamer
        {
            get; set;
        }
    }
}

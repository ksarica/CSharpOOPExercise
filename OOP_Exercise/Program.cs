using CSharp_OOP_Exercise.Entities;
using CSharp_OOP_Exercise.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                GamerId = 1,
                IdentificationNumber = "103040",
                Name = "Thomas",
                Surname = "Anderson",
                BirthYear = new DateTime(1971, 9, 13)
            };

            Gamer gamer2 = new Gamer()
            {
                GamerId = 2,
                IdentificationNumber = "203040",
                Name = "Agent",
                Surname = "Smith",
                BirthYear = new DateTime(1972, 6, 25)
            };

            Game game1 = new Game()
            {
                GameId = 1,
                Name = "Call of Duty",
                Price = 100
            };

            Game game2 = new Game()
            {
                GameId = 2,
                Name = "Cyberpunk 2077",
                Price = 250
            };

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = campaignManager.Add(new Campaign()
            {
                CampaignHeader = "Deal up to %70 OFF !!!",
                CampaignDescription = "Until 25 February 2021",
                CampaignId = 1,
                DiscountRatio = 70,
                Gamer = gamer1
            });

            OrderManager orderManager = new OrderManager();
            orderManager.MakeDiscount(campaign1, game2);
            orderManager.MakeDiscount(campaign1, game1);

            GamerManager gamerManagerDevelopment = new GamerManager(new DevelopmentEnvValidationManager());
            GamerManager gamerManagerProduction = new GamerManager(new ProductionEnvValidationManager());

            gamerManagerDevelopment.Add(gamer1);
            gamerManagerProduction.Add(gamer2);


       

        }
    }
}

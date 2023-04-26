using CSharp_OOP_Exercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Exercise.Managers
{
    public class OrderManager : IOrderService
    {
        public void MakeDiscount(Campaign campaign, Game game)
        {
            double newPrice = game.Price * ((100.00 - campaign.DiscountRatio) / 100);
            Console.WriteLine("After the sale, the new price of the game named " + game.Name + " was updated to from $" + game.Price + " to $" + newPrice);
            game.Price = newPrice;
        }
    }
}

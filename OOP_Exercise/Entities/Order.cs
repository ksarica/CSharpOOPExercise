using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Exercise.Entities
{
    public class Order
    {
        public int OrderId
        {
            get; set;
        }

        public Game game
        {
            get; set;
        }

        public Gamer gamer
        {
            get; set;
        }
    }
}

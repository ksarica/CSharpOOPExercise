using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public class ProductionEnvValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return (gamer.Name == "Thomas" && gamer.Surname == "Anderson" && 
                gamer.GamerId == 1 && gamer.IdentificationNumber == "102030") ? true : false;
        }     
    }
}

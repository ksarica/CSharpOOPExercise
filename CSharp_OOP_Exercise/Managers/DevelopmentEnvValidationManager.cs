using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public class DevelopmentEnvValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}

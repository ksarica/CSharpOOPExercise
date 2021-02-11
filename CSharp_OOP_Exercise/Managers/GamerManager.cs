using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public class GamerManager : IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer given below has been added: \n" + gamer.GamerId + "\n" + gamer.IdentificationNumber + "\n" + gamer.Name + "\n"
                    + gamer.Surname + "\n" + gamer.BirthYear + "\n\n");
            }
            else
            {
                Console.WriteLine("Gamer validation given below has been failed: \n" + gamer.GamerId + "\n" + gamer.IdentificationNumber + "\n" + gamer.Name + "\n"
                    + gamer.Surname + "\n" + gamer.BirthYear + "\n\n");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer given below has been updated: \n" + gamer.GamerId + "\n" + gamer.IdentificationNumber + "\n" + gamer.Name + "\n"
                    + gamer.Surname + "\n" + gamer.BirthYear + "\n\n");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer given below has been deleted: \n" + gamer.GamerId + "\n" + gamer.IdentificationNumber + "\n" + gamer.Name + "\n"
                    + gamer.Surname + "\n" + gamer.BirthYear + "\n\n");
        }
    }
}

using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}
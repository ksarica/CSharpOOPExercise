using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public interface IOrderService
    {
        void MakeDiscount(Campaign campaign, Game game);
    }
    

}
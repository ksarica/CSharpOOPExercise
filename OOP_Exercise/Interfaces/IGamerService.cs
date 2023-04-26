using CSharp_OOP_Exercise.Entities;

namespace CSharp_OOP_Exercise.Managers
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
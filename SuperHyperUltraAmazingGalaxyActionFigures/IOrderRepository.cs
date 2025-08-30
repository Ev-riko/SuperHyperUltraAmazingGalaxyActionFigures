using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public interface IOrderRepository
    {
        void Add(Cart cart, User user);
        void Remove(Order order);
        Order? TryGetByUserId(string userId);
    }
}
using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public interface ICartRepository
    {
        void Add(Product product, string userId);
        void Clear(string userId);
        void Remove(Product product, string userId);
        Cart? TryGetByUserId(string userId);
    }
}
using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public interface IUserRepository
    {
        void Add();
        void Remove();
        User? TryGetById(string Id);
    }
}
using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product TryGetById(Guid id);
    }
}

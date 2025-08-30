using SuperHyperUltraAmazingGalaxyActionFigures.Models;
using System.Linq;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> Products = new List<Product>()
        {
            new Product( "Монки Д Луффи", 3000000000, "Даже если весь мир говорит тебе остановиться, ты должен продолжать двигаться вперёд!", "/images/Luffy.png"),
            new Product( "Ророноа Зорро", 1111000000, "Только я могу назвать свою мечту глупой", "/images/Zoro.png"),
            new Product( "Киллер Би", 8, "Пока есть силы, ты сияешь, ты блестишь! Хачиби рулит тусовкой! О да!", "/images/KillerBee.png"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
            new Product("Заглушка", 990, "Lorem ipsum dolor sit amet consectetur adipiscing elit. Dolor sit amet consectetur adipiscing elit quisque faucibus.", "/images/plug.jpg"),
        };

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product TryGetById(Guid id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}

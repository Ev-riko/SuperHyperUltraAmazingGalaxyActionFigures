using Microsoft.AspNetCore.Mvc;

namespace SuperHyperUltraAmazingGalaxyActionFigures.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IActionResult Index(Guid id)
        {
            var product = _productRepository.TryGetById(id);
            if (product == null) 
            {
                //?
            }
            return View(product);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace SuperHyperUltraAmazingGalaxyActionFigures.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;

        public CartController(IProductRepository productRepository, ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(Guid id)
        {
            var product = _productRepository.TryGetById(id);
            _cartRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(Guid id)
        {
            var product = _productRepository.TryGetById(id);
            _cartRepository.Remove(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            _cartRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}

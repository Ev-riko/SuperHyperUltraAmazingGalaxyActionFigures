using Microsoft.AspNetCore.Mvc;
using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartRepository cartRepository;
        private readonly IOrderRepository orderRepository;

        public OrderController(ICartRepository cartRepository, IOrderRepository orderRepository)
        {
            this.cartRepository = cartRepository;
            this.orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(User user)
        {
            var existingCart = cartRepository.TryGetByUserId(user.Id);
            orderRepository.Add(existingCart, user);
            cartRepository.Clear(user.Id);
            return View();
        }
    }
}

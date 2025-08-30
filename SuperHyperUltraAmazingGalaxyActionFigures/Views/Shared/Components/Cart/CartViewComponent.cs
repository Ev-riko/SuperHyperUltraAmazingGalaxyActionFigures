using Microsoft.AspNetCore.Mvc;

namespace SuperHyperUltraAmazingGalaxyActionFigures.Views.Shared.ViewComponents.Cart
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartRepository _cartRepository;

        public CartViewComponent(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public IViewComponentResult Invoke()
        {
            var cart = _cartRepository.TryGetByUserId(Constants.UserId);
            var cartItemsCount = cart?.Amount;
            return View("Cart", cartItemsCount);
        }
    }
}

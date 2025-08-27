using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public class CartsInMemoryRepository : ICartRepository
    {
        private List<Cart> carts = new List<Cart>();

        public Cart? TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            if (existingCart == null)
            {
                var newCart = new Cart
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    CartItems = new List<CartItem> {
                        new CartItem(product)
                    }
                };

                carts.Add(newCart);
            }
            else
            {
                var existingCartItem = existingCart.CartItems.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount++;
                }
                else
                {
                    existingCart.CartItems.Add(new CartItem(product));
                }
            }
        }
        public void Remove(Product product, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            var existingCartItem = existingCart?.CartItems?.FirstOrDefault(x => x.Product.Id == product.Id);
            if (existingCartItem == null)
            {
                return;
            }

            existingCartItem.Amount--;
            if (existingCartItem.Amount == 0)
            {
                existingCart.CartItems.Remove(existingCartItem);
            }
        }

        public void Clear(string userId)
        {
            var existingCart = TryGetByUserId(userId);
            carts.Remove(existingCart);
        }
    }
}

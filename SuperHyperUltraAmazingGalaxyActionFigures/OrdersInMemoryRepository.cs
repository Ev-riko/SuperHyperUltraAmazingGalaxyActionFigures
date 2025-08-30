using SuperHyperUltraAmazingGalaxyActionFigures.Models;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public class OrdersInMemoryRepository : IOrderRepository
    {
        private List<Order> orders = new List<Order>();
        
        public void Add(Cart cart, User user)
        {
            orders.Add(
                new Order(cart, user)
                );
        }

        public void Remove(Order order)
        {
            orders.Remove(order);
        }

        public Order? TryGetByUserId(string userId)
        {
            return orders.FirstOrDefault(x => x.User.Id == userId);
        }
    }
}

namespace SuperHyperUltraAmazingGalaxyActionFigures.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public User User { get; set; }    
        public Cart Cart { get; set; }
        public Order(Cart cart, User user) 
        {
            Id = Guid.NewGuid();
            User = user;
            Cart = cart;
        }
    }
}

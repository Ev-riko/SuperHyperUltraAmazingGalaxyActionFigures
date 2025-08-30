namespace SuperHyperUltraAmazingGalaxyActionFigures.Models
{
    public class User
    {
        public User()
        {
            Id = Constants.UserId;
        }

        public User(string name, string address, string email, string phone)
        {
            Id = Constants.UserId;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

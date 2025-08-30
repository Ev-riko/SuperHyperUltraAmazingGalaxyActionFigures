using SuperHyperUltraAmazingGalaxyActionFigures.Models;
using System.Linq;

namespace SuperHyperUltraAmazingGalaxyActionFigures
{
    public class UsersInMemoryRepository : IUserRepository
    {
        private List<User> Users = new List<User>()
        {
            new User("Erik","Ardon","Gochi@mail.ru", "+79993332222"),
        };

        public void Add()
        {

        }

        public void Remove()
        {
        }

        public User? TryGetById(string Id)
        {
            return Users.FirstOrDefault(x => x.Id == Id);
        }
    }
}

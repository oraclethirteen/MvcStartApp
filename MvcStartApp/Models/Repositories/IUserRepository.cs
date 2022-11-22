using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User newUser);

        Task<User[]> GetUsers();
    }
}

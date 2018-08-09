using System.Threading.Tasks;
using MyWebApp.API.Models;

namespace MyWebApp.API.Repositories
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}
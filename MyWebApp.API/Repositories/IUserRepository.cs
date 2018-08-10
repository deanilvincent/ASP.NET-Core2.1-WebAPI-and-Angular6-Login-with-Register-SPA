using System.Threading.Tasks;
using MyWebApp.API.Models;

namespace MyWebApp.API.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
    }
}
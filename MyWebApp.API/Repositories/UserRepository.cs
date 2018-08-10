using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp.API.Data;
using MyWebApp.API.Models;

namespace MyWebApp.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyAppDbContext context;
        public UserRepository(MyAppDbContext context)
        {
            this.context = context;
        }

        public async Task<User> GetUserById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.UserId == id);
        }
    }
}
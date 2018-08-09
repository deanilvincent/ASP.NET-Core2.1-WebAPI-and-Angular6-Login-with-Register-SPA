using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace MyWebApp.API.Services
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateJwtTokenString(string username, string password);
    }
}
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.API.Dtos;
using MyWebApp.API.Repositories;

namespace MyWebApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository userRepo;
        private readonly IMapper mapper;
        public UsersController(IUserRepository userRepo, IMapper mapper)
        {
            this.mapper = mapper;
            this.userRepo = userRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            if (id == 0)
            {
                return NotFound("Id is empty");
            }

            var user = await userRepo.GetUserById(id);

            if (user != null)
            {
                var userToReturn = mapper.Map<UserToReturnDto>(user);

                return Ok(userToReturn);
            }

            return NotFound();
        }
    }
}
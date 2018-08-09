using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.API.Dtos;
using MyWebApp.API.Models;
using MyWebApp.API.Repositories;
using MyWebApp.API.Services;

namespace MyWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepo;
        private readonly IJwtTokenGenerator jwtTokenGeneratorService;
        private readonly IMapper mapper;

        public AuthController(IAuthRepository authRepo,
        IJwtTokenGenerator jwtTokenGeneratorService,
        IMapper mapper)
        {
            this.mapper = mapper;
            this.jwtTokenGeneratorService = jwtTokenGeneratorService;
            this.authRepo = authRepo;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            return Ok(await jwtTokenGeneratorService.GenerateJwtTokenString(userForLoginDto.Username, userForLoginDto.Password));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            try
            {
                if (await authRepo.UserExists(userForRegisterDto.Username))
                {
                    return BadRequest("User already already exist");
                }

                var user = mapper.Map<User>(userForRegisterDto);
                await authRepo.Register(user, userForRegisterDto.Password);

                return Ok("Successfully register");
            }
            catch (Exception e)
            {
                return Ok($"Something went wrong. {e}");
            }
        }
    }
}
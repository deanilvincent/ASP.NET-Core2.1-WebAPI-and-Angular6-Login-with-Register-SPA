using AutoMapper;
using MyWebApp.API.Dtos;
using MyWebApp.API.Models;

namespace MyWebApp.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserForRegisterDto, User>();

            CreateMap<UserToReturnDto, User>();
        }
    }
}
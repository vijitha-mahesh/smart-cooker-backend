using AutoMapper;
using smartCooker.DTOs.Users;
using smartCooker.Models;

namespace smartCooker.Profiles
{
    public class Users:Profile
    {
        public Users()
        {
            CreateMap<UserReadDTO, UserReadDTO>();
            CreateMap<UserReadDTO, UserReadDTO>();
        }

    }
}

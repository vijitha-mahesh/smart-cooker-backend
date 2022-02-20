using AutoMapper;
using smartCooker.DTOs;
using smartCooker.Models;

namespace smartCooker.Profiles
{
    public class Outlets:Profile
    {
        public Outlets()
        {
            CreateMap<Outlet, CustomerOutletReadDTO>();
        }
    }
}

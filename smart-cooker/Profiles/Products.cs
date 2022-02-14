using AutoMapper;
using smartCooker.DTOs.Products;
using smartCooker.Models;

namespace smartCooker.Profiles
{
    public class Products: Profile
    {
        public Products()
        {
            CreateMap<Product, CustomerProductReadDTO >(); 
            CreateMap<CreateProductDTO, Product>();
        }
    }
}

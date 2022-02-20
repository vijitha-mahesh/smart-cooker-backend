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

            CreateMap<ProductInOutlet, Product>()
                .ForMember(destination => destination.Id,
                option => option.MapFrom(source => source.Product.Id));
        }
    }
}

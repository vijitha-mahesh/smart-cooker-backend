using smartCooker.DTOs.Orders;
using smartCooker.Models;
using AutoMapper;

namespace smartCooker.Profiles
{
    public class Orders: Profile
    { 
      
        public Orders()
        {
            //CreateMap<CreateOrderDTO,Order>().ForMember(
            //    des => des.ProductOrder, option => option.MapFrom(order => );
            //    );


            //CreateMap<ProductCreateDto, Product>()
            //    .ForMember(
            //    dest => dest.Product_Picture,
            //    opt => opt.MapFrom(src => new List<Product_Picture> { new Product_Picture { Product_Picture_Url = src.product_Picture_Url } }));

        }
    }
}

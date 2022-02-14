using smartCooker.DTOs.Products;
using System.Collections.Generic;

namespace smartCooker.Services.IServices
{
    public interface IProductService
    {
        IEnumerable<CustomerProductReadDTO> CustomerGetAllProducts();
        bool CreateProduct(CreateProductDTO productToCreate);

    }
}

using smartCooker.DTOs.Products;
using System.Collections.Generic;

namespace smartCooker.Services.IServices
{
    public interface IProductService
    {
        IEnumerable<CustomerProductReadDTO> CustomerGetAllProducts(int outletId);
        bool CreateProduct(CreateProductDTO productToCreate);
        CustomerProductReadDTO GetProductById(int id);


        int getProductQuentityInOutlet(int productId, int outletId);

    }
}

using smartCooker.DTOs.Products;
using smartCooker.Models;
using System.Collections.Generic;

namespace smartCooker.Repositories.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> CustomerGetAllProducts(int outletId);
        void AddProduct(Product product);

        CustomerProductReadDTO GetProductById(int id);

        int getProductQuentityInOutlet(int productId, int outletId);

    }
}

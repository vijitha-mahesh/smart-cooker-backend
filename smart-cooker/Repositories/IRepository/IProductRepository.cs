using smartCooker.Models;
using System.Collections.Generic;

namespace smartCooker.Repositories.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> CustomerGetAllProducts();
        void AddProduct(Product product);
    }
}

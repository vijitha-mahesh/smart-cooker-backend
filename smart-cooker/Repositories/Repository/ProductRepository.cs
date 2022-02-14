using smartCooker.Data;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace smartCooker.Repositories.Repository
{
    
    public class ProductRepository :IProductRepository
    {
        private readonly ApiDbContext _context;
        public ProductRepository(ApiDbContext context) 
        {
            _context = context; 
        }

        public IEnumerable<Product> CustomerGetAllProducts()
        {
           return _context.Product.ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Product.Add(product);

            _context.SaveChanges();


        }
    }
}

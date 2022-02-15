using Microsoft.EntityFrameworkCore;
using smartCooker.Data;
using smartCooker.DTOs.Products;
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

        public CustomerProductReadDTO GetProductById(int id)
        {
            var item =  _context.Product.FirstOrDefault(x => x.Id == id);

            CustomerProductReadDTO data = new CustomerProductReadDTO();
            if (data != null)
            {
                data.Id = data.Id;
                data.Name = item.Name;
                data.Description = item.Description;
                data.Price = item.Price;
                data.Quentity = item.Quentity;
                data.Url = item.Url;

                return data;
            }
            else
            {
                return null;
            }
            
        }

       public int getProductQuentityInOutlet(int productId, int outletId)
        {

            var quentity = _context.ProductInOutlet.FirstOrDefault(x => x.Product.Id == productId && x.Outlet.Id == outletId).Quentity;

            if (quentity != null)
            {
                return quentity;
            }
            else
            {
                return 0;
            }
            
        }
    }
}

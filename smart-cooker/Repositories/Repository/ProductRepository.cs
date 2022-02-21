using AutoMapper;
using Microsoft.EntityFrameworkCore;
using smartCooker.Data;
using smartCooker.DTOs.Products;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace smartCooker.Repositories.Repository
{
    public class ProductRepository :IProductRepository
    {
        private readonly ApiDbContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(ApiDbContext context, IMapper mapper) 
        {
            _context = context;
        }

        //public IEnumerable<Product> CustomerGetAllProducts(int outletId)
        //{
        //    if(outletId == 0)
        //    {
        //        var result = _context.Product.ToList(); 
        //        return result;
        //    }
        //    else
        //    {
        //        var outletResult = _context.Outlet.Where(p => p.Id == outletId).FirstOrDefault();

        //        if (outletResult == null)
        //            return null;

        //        var result = _context.ProductInOutlet.Where(p => p.Outlet.Id == outletResult.Id).Include(p => p.Product).ToList();

        //        return _mapper.Map<IEnumerable<Product>>(result);

        //    }
        //}

        public IEnumerable<Product> CustomerGetAllProducts(int outletId)
        {
            if (outletId == 0)
            {
                var result = _context.Product.ToList();
                return result;
            }
            else
            {
                var result = (from P in _context.Product
                              from PI in _context.ProductInOutlet
                              where (P.Id == PI.Product.Id && PI.Outlet.Id == outletId )
                              
                              select new Product
                              {
                                  Id = PI.Product.Id,
                                  Name = PI.Product.Name,
                                  Description = PI.Product.Description,
                                  Price = PI.Product.Price,
                                  Url = PI.Product.Url,
                                  Quentity = PI.Quentity
                              }
                        ).ToList();

                return result;
            }
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
            try
            {
                var quentity = _context.ProductInOutlet.FirstOrDefault(x => x.Product.Id == productId && x.Outlet.Id == outletId).Quentity;
                return quentity; 
            }
            catch(Exception e)
            {
                return 0;
            }
        }

    }
}

using AutoMapper;
using smartCooker.DTOs.Products;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using smartCooker.Services.IServices;
using System.Web.Http.ModelBinding;

namespace smartCooker.Services
{
    public class ProductService:IProductService
    {
     // private ModelStateDictionary _modelState;
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService( IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
           // _modelState = modelState;
        }


        private bool ValidateProduct(Product productToValidate)
        {
            //if (productToValidate.Name.Trim().Length == 0)
            //    _modelState.AddModelError("Name", "Name is required.");
            //if (productToValidate.Description.Trim().Length == 0)
            //    _modelState.AddModelError("Description", "Description is required.");
            //if (productToValidate.UnitsInStock < 0)
            //    _modelState.AddModelError("UnitsInStock", "Units in stock cannot be less than zero.");
            //return _modelState.IsValid;

            return true;
        }


        public IEnumerable<CustomerProductReadDTO> CustomerGetAllProducts()
        {
            var products = _repository.CustomerGetAllProducts();
            return _mapper.Map<IEnumerable<CustomerProductReadDTO>>(products);
        }

        public bool CreateProduct(CreateProductDTO productToCreate)
        {

            var Newproduct = _mapper.Map<Product>(productToCreate);

            if (!ValidateProduct(Newproduct))
                return false;
            try
            {
                _repository.AddProduct(Newproduct);
            }
            catch
            {
                return false;
            }
            return true;
        }

       public CustomerProductReadDTO GetProductById(int id)
        {
            return _repository.GetProductById(id);
;        }


        public int getProductQuentityInOutlet(int productId, int outletId)
        {
            return(_repository.getProductQuentityInOutlet(productId, outletId));
        }
    }

}

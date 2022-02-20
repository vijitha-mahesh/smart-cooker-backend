using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartCooker.Data;
using smartCooker.DTOs.Products;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using smartCooker.Services;
using smartCooker.Services.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace smartCooker.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }
        

        [HttpGet("productsinoutlet/{outletId}")]
        public ActionResult<IEnumerable<CustomerProductReadDTO>> GetProducts(int outletId)
        {
            try
            {
                return Ok(_service.CustomerGetAllProducts(outletId));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
 
        [HttpPost]
        public ActionResult CreateItem(CreateProductDTO data)
        {
            try
            {
                _service.CreateProduct(data);
                return Ok("Add Product Successfully");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


        [HttpGet("{id}")]
        public ActionResult GetProduct(int id)
        {
            try
            {
                var item = _service.GetProductById(id);
                return Ok(item);

            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [Route("quentity")]
        [HttpPost]
        public ActionResult getProductQuentityInOutlet(GetProductQuentityInOutletDTO data)
        {
            try 
            {
                var quentity = _service.getProductQuentityInOutlet(int.Parse(data.ProductId), int.Parse(data.OutletId));
                return Ok(quentity);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }


        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateItem(int id, ItemData item)
        //{
        //    if (id != item.Id)
        //        return BadRequest();

        //    var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

        //    if (existItem == null)
        //        return NotFound();

        //    existItem.Title = item.Title;
        //    existItem.Description = item.Description;
        //    existItem.Done = item.Done;

        //    // Implement the changes on the database level
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    var existItem = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);

        //    if (existItem == null)
        //        return NotFound();

        //    _context.Product.Remove(existItem);
        //    await _context.SaveChangesAsync();

        //    return Ok("deleted");
        //}
    }
}

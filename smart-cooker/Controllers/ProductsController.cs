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
       // private readonly ApiDbContext _context;
       private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            // _context = context;
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerProductReadDTO>> GetProducts()
        {
            try
            {
                return Ok(_service.CustomerGetAllProducts());
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateItem(CreateProductDTO data)
        {
            //if (ModelState.IsValid)
            //{

            //    return Ok("Product Successfully Created");
            //}

            //return new JsonResult("Something went wrong") { StatusCode = 500 };

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


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetProduct(int id)
        //{
        //    var item = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);

        //    if (item == null)
        //        return NotFound();

        //    return Ok(item);
        //}


        ////[HttpPut("{id}")]
        ////public async Task<IActionResult> UpdateItem(int id, ItemData item)
        ////{
        ////    if (id != item.Id)
        ////        return BadRequest();

        ////    var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

        ////    if (existItem == null)
        ////        return NotFound();

        ////    existItem.Title = item.Title;
        ////    existItem.Description = item.Description;
        ////    existItem.Done = item.Done;

        ////    // Implement the changes on the database level
        ////    await _context.SaveChangesAsync();

        ////    return NoContent();
        ////}

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

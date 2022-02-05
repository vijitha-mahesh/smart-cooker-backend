using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartCooker.Data;
using smartCooker.Models;
using System.Threading.Tasks;

namespace smartCooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ProductsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Product.ToListAsync();
            return Ok(products);
        }

        [HttpPost]

        public async Task<IActionResult> CreateItem(ProductModel data)
        {
            if (ModelState.IsValid)
            {
                await _context.Product.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProduct", new { data.Id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var item = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return NotFound();

            return Ok(item);
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
        //public async Task<IActionResult> DeleteItem(int id)
        //{
        //    var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

        //    if (existItem == null)
        //        return NotFound();

        //    _context.Items.Remove(existItem);
        //    await _context.SaveChangesAsync();

        //    return Ok(existItem);
        //}
    }
}

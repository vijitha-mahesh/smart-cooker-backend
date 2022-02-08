﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartCooker.Data;
using smartCooker.Models;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smartCooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInformationController : ControllerBase
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly ApiDbContext _context;

        public UserInformationController(UserManager<UserModel> userManager, ApiDbContext context)
        {
            _userManager = userManager;
            
            _context = context;
        
        }
        // GET api/<UserInformationController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var item = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        // POST api/<UserInformationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserInformationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserInformationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
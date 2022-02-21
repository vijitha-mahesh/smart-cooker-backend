using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartCooker.Data;
using smartCooker.DTOs.Users;
using smartCooker.Models;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smartCooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInformationController : ControllerBase
    {
        private readonly UserManager<IdentityUserModel> _userManager;
        private readonly ApiDbContext _context;

        public UserInformationController(UserManager<IdentityUserModel> userManager, ApiDbContext context)
        {
            _userManager = userManager;
            
            _context = context;
        
        }
        // GET api/<UserInformationController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> getUserById(int id)
        {
            var item = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            UserReadDTO data = new UserReadDTO
            {
                Id = item.Id,
                NIC = item.NIC,
                Role = item.Role,
                Email = item.Email,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                ProfilePictureUrl=item.ProfilePictureUrl
            };

        
            if (data == null)
                return NotFound();

          return Ok(data);

       
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

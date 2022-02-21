using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using smartCooker.DTOs.Orders;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smartCooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly UserManager<IdentityUserModel> _userManager;
        private readonly IOrderRepository _orderRepository;

        public OrderController(UserManager<IdentityUserModel> userManager, IOrderRepository orderRepository)
        {
            _userManager = userManager;
            _orderRepository = orderRepository;
        }

        [HttpPost]
        [Route("CreateOrder")]
        public async Task<ActionResult> CreateOrder(CreateOrderDTO createOrderDTO)
        {
            var user = await _userManager.FindByIdAsync(createOrderDTO.UserId.ToString());

            if (user == null)
                return BadRequest();
            var result = _orderRepository.CreateOrder(createOrderDTO, user).Result;
            if (result == false)
                return BadRequest(result);
            return Ok(result);

        }
    }
}

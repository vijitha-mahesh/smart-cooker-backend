using Microsoft.AspNetCore.Mvc;
using smartCooker.DTOs;
using smartCooker.Services.IService;
using System;
using System.Collections.Generic;

namespace smartCooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletController : ControllerBase
    {
        private IOutletService _outletService;

        public OutletController(IOutletService outletService)
        {
            _outletService = outletService;
        }
        // GET: api/<OutletController>
        [HttpGet]
        public ActionResult<IEnumerable<CustomerOutletReadDTO>> GetOutlets()
        {
            try
            {
                return Ok(_outletService.CustomerGetAllOutlets());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

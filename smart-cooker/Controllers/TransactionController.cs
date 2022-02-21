using Microsoft.AspNetCore.Mvc;
using smartCooker.Data;
using smartCooker.DTOs.Orders;
using System.Collections.Generic;

using System.Linq;

namespace smartCooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Transaction : ControllerBase
    {
        private readonly ApiDbContext _context;
        public Transaction(ApiDbContext apiDbContext)
        {
            _context = apiDbContext;
        }
        [HttpGet("{id}")]
        public IEnumerable<TransactionHistoryDTO> getTransactionHistory(int id)
        {

            var result = (from O in _context.Order
                          from Ot in _context.Outlet
                          from PO in _context.ProductOrder
                          from P in _context.Product
                          where(O.Outlet.Id == Ot.Id && PO.Orders.Id == O.Id && O.User.Id == id)
                           select new TransactionHistoryDTO {
                               Id = O.Id,
                               UserId = id,
                               ProductId = P.Id,
                               Amount = O.Amount,
                               OutletId = O.Outlet.Id,
                               dateTime = O.Created,
                               OutletName= O.Outlet.Name,
                               Status = O.Status                             
                           }). ToList();

            return result;

        }
    }
}
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using smartCooker.Data;
using smartCooker.DTOs.Orders;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace smartCooker.Repositories.Repository
{
    public class OrderRepository: IOrderRepository
    {
        private ApiDbContext _context;

        public OrderRepository(ApiDbContext context, UserManager<IdentityUserModel> userManager)
        {
            _context = context;
        }

        public async Task<bool> CreateOrder(CreateOrderDTO orderCreateDto, IdentityUserModel orderUser)
        {


            var productinoutlet = _context.ProductInOutlet.FirstOrDefault(p => p.Outlet.Id == orderCreateDto.OutletID && p.Product.Id == orderCreateDto.ProductId);

            if (productinoutlet == null)
                return false;

            productinoutlet.Quentity = productinoutlet.Quentity - orderCreateDto.Quentity;

            productinoutlet.LastUpdated = DateTime.Now;
            _context.ProductInOutlet.Update(productinoutlet);

            var outlet = _context.Outlet.FirstOrDefault(p=> p.Id == orderCreateDto.OutletID);

            Order order = new Order
            {
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                Amount = orderCreateDto.Amount * orderCreateDto.Quentity,
                Status = "in_progress",
                User = orderUser,
                Outlet = outlet
            };

            _context.Order.Add(order);

            ProductOrder productOrder = new ProductOrder
            {
                Orders = order,
                ProductInOutlet = productinoutlet,
                Product_Order_Qty = orderCreateDto.Quentity
            };


            _context.ProductOrder.Add(productOrder);

            var result = (_context.SaveChanges() > 0);

            return result;
        }
    }
}

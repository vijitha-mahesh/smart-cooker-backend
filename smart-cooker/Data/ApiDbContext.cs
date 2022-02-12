using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using smartCooker.Models;

namespace smartCooker.Data
{
    public class ApiDbContext : IdentityDbContext<IdentityUserModel, IdentityRole<int>, int>
    {
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Outlet> Outlet { get; set; }
        public DbSet<ProductInOutlet> ProductInOutlet { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }



        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
            
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using smartCooker.Models;

namespace smartCooker.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<ProductModel> Product { get;set;}  

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
            
        }
    }
}
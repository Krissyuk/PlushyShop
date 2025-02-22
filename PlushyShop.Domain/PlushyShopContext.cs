using Microsoft.EntityFrameworkCore;
using PlushyShop.Domain.Entities;

namespace PlushyShop.Domain
{
    public class PlushyShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public PlushyShopContext(DbContextOptions options): base(options)
        {
        }
    }
}

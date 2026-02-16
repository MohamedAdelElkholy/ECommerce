using Microsoft.EntityFrameworkCore;
using ECommerce.Domain.Entities;

namespace ECommerce.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Scentinel.Models;

namespace Scentinel.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ScentCategory> ScentCategories { get; set; }

    }
}

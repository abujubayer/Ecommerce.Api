using Microsoft.EntityFrameworkCore;
using ECommerce.API.Models;
using Ecommerce.API.Models;

namespace ECommerce.API.DataContext
{
    public class ECommDbContext:DbContext
    {
        public ECommDbContext(DbContextOptions<ECommDbContext> options):base(options)
        {
            
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}

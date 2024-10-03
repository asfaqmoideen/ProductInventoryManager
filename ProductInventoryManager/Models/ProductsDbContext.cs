using Microsoft.EntityFrameworkCore;

namespace ProductInventoryManager.Models
{
    public class ProductsDbContext : DbContext
    {   
        public DbSet<Product> Products { get; set; }
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options )
            : base( options )
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }

    }
}

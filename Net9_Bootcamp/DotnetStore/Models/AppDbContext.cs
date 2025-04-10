using Microsoft.EntityFrameworkCore;

namespace DotnetStore.Models;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() { Id = 1, Name="Apple Watch 7", Price=10000, IsActive=false},
                new Product() { Id = 2, Name="Apple Watch 8", Price=20000, IsActive=true},
                new Product() { Id = 3, Name="Apple Watch 9", Price=30000, IsActive=true},
                new Product() { Id = 4, Name="Apple Watch 10", Price=40000, IsActive=false},
                new Product() { Id = 5, Name="Apple Watch 11", Price=50000, IsActive=true},
                new Product() { Id = 6, Name="Apple Watch 12", Price=60000, IsActive=true},
            }
        );
    }
}
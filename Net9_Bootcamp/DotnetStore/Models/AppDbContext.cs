using Microsoft.EntityFrameworkCore;

namespace DotnetStore.Models;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
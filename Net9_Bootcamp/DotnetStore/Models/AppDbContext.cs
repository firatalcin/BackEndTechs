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

        modelBuilder.Entity<Category>().HasData(
            new List<Category> {
                new Category() {Id=1, Name= "Telefon", Url="telefon"},
                new Category() {Id=2, Name="Elektronik", Url="elektronik"},
                new Category() {Id=3, Name="Beyaz Eşya", Url="beyaz-esya"},
                new Category() {Id=4, Name="Giyim", Url="giyim"},
                new Category() {Id=5, Name="Kozmetik", Url="kozmetik"},
            }
        );
        
        
        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() {
                    Id = 1, Name="Apple Watch 7", Price=10000, IsActive=false, Image="1.jpeg", MainPage=true,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 1},
                new Product() { Id = 2, Name="Apple Watch 8", Price=20000, IsActive=true, Image="2.jpeg", MainPage=true,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 1},
                new Product() { Id = 3, Name="Apple Watch 9", Price=30000, IsActive=true, Image="3.jpeg", MainPage=true,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 2},
                new Product() { Id = 4, Name="Apple Watch 10", Price=40000, IsActive=false, Image="4.jpeg", MainPage=false,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 2},
                new Product() { Id = 5, Name="Apple Watch 11", Price=50000, IsActive=true, Image="5.jpeg", MainPage=true,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 2},
                new Product() { Id = 6, Name="Apple Watch 12", Price=60000, IsActive=false, Image="6.jpeg", MainPage=false,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 3}
                ,
                new Product() { Id = 7, Name="Apple Watch 14", Price=70000, IsActive=false, Image="7.jpeg", MainPage=false,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 3}
                ,
                new Product() { Id = 8, Name="Apple Watch 15", Price=80000, IsActive=true, Image="8.jpeg", MainPage=true,Description="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", CategoryId = 4},
            }
        );
    }
}
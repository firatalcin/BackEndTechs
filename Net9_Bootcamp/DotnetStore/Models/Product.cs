namespace DotnetStore.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public bool MainPage { get; set; }
}
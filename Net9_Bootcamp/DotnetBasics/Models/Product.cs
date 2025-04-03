namespace DotnetBasics.Models;

public class Product
{
    public string? urunBaslik { get; set; }
    public string urunAciklama { get; set; } = null!;
    public double urunFiyat { get; set; }
    public string? urunResim { get; set; }
    public bool urunSatistami { get; set; }
}
namespace DotnetBasics.Models;

public class Course
{
    public string Title { get; set; } = null!;
    public string? Image { get; set; }
    public bool IsActive { get; set; }
    public bool IsHome { get; set; }
}
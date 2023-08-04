namespace Final.Models
{
    public interface IDish
    {
        string Name { get; set; }
        decimal Price { get; set; }
        string Type { get; set; }
    }
}
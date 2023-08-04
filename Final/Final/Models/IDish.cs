namespace Final.Models
{
    public interface IDish
    {
        string Name { get; set; }
        decimal Price { get; set; }
        DishType Type { get; set; }
    }
}
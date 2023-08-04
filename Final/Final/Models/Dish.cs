namespace Final.Models
{
    public class Dish : IDish
    {
        public string Name { get; set; }

        public DishType Type { get; set; }

        public decimal Price { get; set; }
    }
}

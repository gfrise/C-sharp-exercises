namespace Final.Models
{
    public class Dish : IDish
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }
    }
}

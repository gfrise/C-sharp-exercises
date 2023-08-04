namespace Final.Models
{
    public interface IDishRepo
    {
        Task Create(Dish dish);
        Task<List<Dish>> FilterByType(DishType p);
        Task<List<Dish>> GetAll();
        Task<List<Dish>> ReadAll();
        Task<List<Dish>> ShowCheapest();
        Task WriteAll(List<Dish> d);
    }
}
using System.Text.Json;

namespace Final.Models
{
    public class DishRepo : IDishRepo
    {
        string url = "./Data/menu.json";
        
        JsonSerializerOptions opt = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task Create(Dish dish)
        {
            var i = await GetAll();
            i.Add(dish);
            await WriteAll(i);
        }

        public async Task<List<Dish>> GetAll()
        {
            var i = await ReadAll();
            return i;
        }

        public async Task<List<Dish>> FilterByType(string p)
        {
            var i = await GetAll();

            var filtered = i.Where(i => i.Type == p).ToList();

            return filtered;
        }

        public async Task<List<Dish>> ShowCheapest()
        {
            var i = await GetAll();

            var filtered = i.Where(i => i.Price < 10).ToList();

            return filtered;
        }

        public async Task<List<Dish>> ReadAll()
        {
            var i = await File.ReadAllTextAsync(url);

            var x = JsonSerializer.Deserialize<List<Dish>>(i, opt);

            return x;
        }

        public async Task WriteAll(List<Dish> d)
        {
            var i = JsonSerializer.Serialize(d, opt);

            await File.WriteAllTextAsync(url, i);
        }
    }
}

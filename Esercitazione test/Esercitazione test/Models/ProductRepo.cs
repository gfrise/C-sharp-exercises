using System.Collections.Concurrent;
using System.Text.Json;

namespace Esercitazione_test.Models
{
    public class ProductRepo : IProductRepo
    {

        string ur = "../Data/Product.json";

        JsonSerializerOptions opt = new()
        {
            PropertyNameCaseInsensitive = true
        };

        async Task<List<Product>> IProductRepo.GetAll()
        {
            if (!File.Exists(ur))
            {
                return new List<Product>();
            }

            var x = await File.ReadAllTextAsync(ur);

            return JsonSerializer.Deserialize<List<Product>>(x, opt ) ?? new List<Product>();
            
        }

        async Task IProductRepo.Create(Product i)
        {
            var all = await GetAll();

            all.Add(i);

            var x = JsonSerializer.Serialize(all, opt );

            await File.WriteAllTextAsync(ur, x);
        }
    }
}

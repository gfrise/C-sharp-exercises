namespace Esercitazione_test.Models
{
    public interface IProductRepo
    {
        Task Create(Product product);
        Task<List<Product>> GetAll();
    }
}
using ECommerce.API.Models;

namespace ECommerce.API.interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetProduct(int id);
        bool Add(Product product);
        bool Edit(Product product);
        bool Delete(int id);
    }
}

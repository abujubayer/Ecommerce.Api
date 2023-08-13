using Ecommerce.API.Models;
using ECommerce.API.Models;

namespace Ecommerce.API.interfaces
{
    public interface IStockRepository
    {
        List<Stock> GetAll();
        Stock GetStock(int id);
        bool Add(Stock stock);
        bool Edit(Stock stock);
        bool Delete(int id);
    }
}

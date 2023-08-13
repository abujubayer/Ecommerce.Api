using Microsoft.EntityFrameworkCore;
using ECommerce.API.DataContext;
using ECommerce.API.interfaces;
using ECommerce.API.Models;

namespace ECommerce.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        ECommDbContext _dbContext;
        public ProductRepository(ECommDbContext dbContext)
        { 
            _dbContext = dbContext;
        }
        public bool Add(Product product)
        {
            _dbContext.Products.Add(product);
            return _dbContext.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(c=>c.Id == id);
            if(product != null)
            {
                product.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }

        public bool Edit(Product product)
        {
            _dbContext.Products.Update(product);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.Where(c=>!c.IsDeleted)
                .ToList();
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.FirstOrDefault(c => c.Id == id);
        }
    }
}

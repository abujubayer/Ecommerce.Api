using ECommerce.API.DataContext;
using ECommerce.API.interfaces;
using ECommerce.API.Models;

namespace ECommerce.API.Repository
{
    public class CategoryRepository : ICategroryRepository
    {
        ECommDbContext _dbContext;
        public CategoryRepository(ECommDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Category category)
        {
            
            _dbContext.Categories.Add(category);
            return _dbContext.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
          
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                category.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }

        public bool Edit(Category category)
        {
            _dbContext.Categories.Update(category);
            return _dbContext.SaveChanges()>0;
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.Where(c=>!c.IsDeleted).ToList();
        }

        public Category GetCategory(int id)
        {
            var category=  _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            //if(category==null)
            //{
            //    return new Category();
            //}
            return category;
        }
    }
}

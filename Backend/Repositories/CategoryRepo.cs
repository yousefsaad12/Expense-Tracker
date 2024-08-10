
namespace Backend.Repositories
{
    public class CategoryRepo : ICategoryInterface
    {
        
        public Task<bool> CreateCategory(CategoryCreated category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategory(int? CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategory(int? CategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
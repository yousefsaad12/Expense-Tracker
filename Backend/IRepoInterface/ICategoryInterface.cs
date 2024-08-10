
namespace Backend.IRepoInterface
{
    public interface ICategoryInterface
    {
        public Task<Category>GetCategory(int ? CategoryId);
        public Task<bool>CreateCategory(CategoryCreated category);
        public Task<IEnumerable<Category>>GetCategories();
        public Task<bool> DeleteCategory(int ? CategoryId);
    }
}


namespace Backend.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ExpenseTrackerContext _context;

        public BaseRepository(ExpenseTrackerContext context)
        {
            _context = context;
        }
        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }


}
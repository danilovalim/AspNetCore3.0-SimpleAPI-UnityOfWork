using RepoApp.Context;
using RepoApp.Models;

namespace RepoApp.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(RepoContextDB context) : base(context)
        {
        }
    }
}

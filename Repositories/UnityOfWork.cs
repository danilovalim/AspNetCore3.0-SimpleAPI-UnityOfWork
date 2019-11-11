using RepoApp.Context;

namespace RepoApp.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly RepoContextDB _context;
        private CategoryRepository _categoryRepository;
        private ProductRepository _productRepository;

        public UnityOfWork(RepoContextDB context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository = _productRepository ?? new ProductRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

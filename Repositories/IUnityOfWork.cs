using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoApp.Repositories
{
    public interface IUnityOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }

        void Commit();
    }
}

using System.Collections.Generic;

namespace RepoApp.Repositories
{
    public interface IRepository <T>
    {
        T Get(int id);

        List<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}

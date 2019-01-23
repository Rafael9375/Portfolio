using System.Collections.Generic;

namespace Portfolio.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity obj);
        void Remove(TEntity obj);

    }
}

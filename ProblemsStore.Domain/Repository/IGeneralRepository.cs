using System;
namespace ProblemsStore.Domain.Repository
{
    interface IGeneralRepository<T>
     where T : class, new()
    {
        void Delete(object id);
        void Delete(T entity);
        System.Linq.IQueryable<T> GetALL();
        T GetByID(object Id);
        void insert(T entity);
        void update(T entity);
    }
}

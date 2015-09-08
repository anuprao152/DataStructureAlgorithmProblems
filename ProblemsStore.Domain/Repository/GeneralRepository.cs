using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProblemsStore.Domain.Repository;

namespace ProblemsStore.Domain.Repository
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class, new()
    {
        public DbContext MyDBConext;
        public DbSet<T> MyDbSet;

        //If you want that Derive class can have default constructor, then create default constructor over here
        public GeneralRepository(){}

        //Constructor
        public GeneralRepository(DbContext MyDBConext)
        {
            this.MyDBConext = MyDBConext;
            this.MyDbSet = MyDBConext.Set<T>();
        }

        public T GetByID(object Id)
        {
            return MyDbSet.Find(Id);
        }

        public virtual void insert(T entity)
        {
            MyDbSet.Add(entity);
        }

        public virtual void save()
        {
            MyDBConext.SaveChanges();
        }

        public void update(T entity)
        {
            //Attach to EF is necessory because you detach object to update it
            MyDbSet.Attach(entity);
        }

        public virtual void Delete(object id)
        {
            T entityToDelete = GetByID(id);
            Delete(entityToDelete);
        }
        public virtual void Delete(T entity)
        {
            //Attach to EF is necessory because you detach object to update it
            MyDbSet.Attach(entity);
            MyDbSet.Remove(entity);
        }

        public IQueryable<T> GetALL()
        {
            return MyDbSet;
        }

    }
}
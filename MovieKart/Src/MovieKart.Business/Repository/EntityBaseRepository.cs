using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using MovieKart.Domain;
using MovieKart.Infrastructure;

namespace MovieKart.Business.Repository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new ()
    {
        private readonly HomeCinemaContext _homeCinemaContext;

        public EntityBaseRepository(IDbFactory dbFactory)
        {
            _homeCinemaContext = dbFactory.Init();
        }

        public IQueryable<T> GetAll()
        {
            return _homeCinemaContext.Set<T>();
        }

        public T Get(int id)
        {
            return GetAll().FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _homeCinemaContext.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            _homeCinemaContext.Entry(entity);
            _homeCinemaContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = _homeCinemaContext.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            DbEntityEntry<T> dbEntityEntry = _homeCinemaContext.Entry(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }
    }
}
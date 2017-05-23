using System;
using System.Linq;
using System.Linq.Expressions;
using MovieKart.Domain;

namespace MovieKart.Business.Repository
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        /// <summary>
        /// Gets all the underlying entity objects
        /// </summary>
        /// <returns>Queryable result.</returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// Gets an underlying entity object.
        /// </summary>
        /// <param name="id">The entity identifier</param>
        /// <returns>The entity object.</returns>
        T Get(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}
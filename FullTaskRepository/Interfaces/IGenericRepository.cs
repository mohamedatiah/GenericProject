using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Interfaces
{
    public interface IGenericRepository <T> where T :class, IBaseEntity
    {
        T Add(T entity);

        IEnumerable<T> AddRange(IEnumerable<T> entites);

        void Delete(object id);

        void Delete(T entity);

        void Activate(Guid id);

        void Deactivate(Guid id);

        // void Update(T entity);
        void Update(T entity, params Expression<Func<T, object>>[] updatedProperties);

        // ================================================ //

        IEnumerable<T> List { get; }

        //change param from id to guid
        T Single(Guid id);

        T Single(Expression<Func<T, bool>> predicate);

        T Single(Guid id, Expression<Func<T, object>>[] includeProperties);


        T Single(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[] includeProperties);


        IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> GetBySqlQuery(string query, params object[] parameters);

    }
}

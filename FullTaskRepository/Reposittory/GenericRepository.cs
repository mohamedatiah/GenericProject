using FullTaskRepository.Interfaces;
using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Reposittory
{
   public class GenericRepository <TEntity> : IGenericRepository<TEntity>  where TEntity:class,IBaseEntity
    {
        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        IEnumerable<TEntity> IGenericRepository<TEntity>.List => throw new NotImplementedException();

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        TEntity IGenericRepository<TEntity>.Add(TEntity entity)
        {
            context.Entry<IBaseEntity>(entity).State = EntityState.Added;
            var AddedEntity=dbSet.Add(entity);
            return AddedEntity;
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.AddRange(IEnumerable<TEntity> entites)
        {
            throw new NotImplementedException();

        }

        void IGenericRepository<TEntity>.Activate(Guid id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<TEntity>.Deactivate(Guid id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<TEntity>.Update(TEntity entity, params Expression<Func<TEntity, object>>[] updatedProperties)
        {
            throw new NotImplementedException();
        }

        TEntity IGenericRepository<TEntity>.Single(Guid id)
        {
            throw new NotImplementedException();
        }

        TEntity IGenericRepository<TEntity>.Single(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        TEntity IGenericRepository<TEntity>.Single(Guid id, Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        TEntity IGenericRepository<TEntity>.Single(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IGenericRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IGenericRepository<TEntity>.GetAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IGenericRepository<TEntity>.GetBySqlQuery(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}

using FullTaskRepository.Interfaces;
using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Reposittory
{
    public class TestRepo : IGenericRepository<Test>
    {
        public IEnumerable<Test> List => throw new NotImplementedException();

        public void Activate(Guid id)
        {
            throw new NotImplementedException();
        }

        public Test Add(Test entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Test> AddRange(IEnumerable<Test> entites)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Test entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Test> Find(Expression<Func<Test, bool>> predicate, params Expression<Func<Test, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Test> GetAll(params Expression<Func<Test, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Test> GetBySqlQuery(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Test Single(Guid id)
        {
            throw new NotImplementedException();
        }

        public Test Single(Expression<Func<Test, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Test Single(Guid id, Expression<Func<Test, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Test Single(Expression<Func<Test, bool>> predicate, Expression<Func<Test, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Update(Test entity, params Expression<Func<Test, object>>[] updatedProperties)
        {
            throw new NotImplementedException();
        }
    }
}

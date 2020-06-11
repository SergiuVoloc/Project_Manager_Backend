using Evidenta.Context;
using Evidenta.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Evidenta.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
       

        protected DefaultContext RepositoryContext { get; set; }
        public RepositoryBase(DefaultContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }


        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
        public Task LogOut()
        {
            throw new NotImplementedException();
        }
    }
}

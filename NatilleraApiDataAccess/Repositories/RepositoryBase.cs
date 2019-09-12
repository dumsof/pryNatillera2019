﻿namespace NatilleraApiDataAccess.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using NatilleraApiDataAccessContract.IRepositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected NatilleraDBContext RepositoryContext { get; set; }

        public RepositoryBase(NatilleraDBContext repositoryContext)
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


        public Task<T> AddAsync(T datosActualizar)
        {
            throw new NotImplementedException();
        }

       

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }   
       

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }       

        public Task<T> UpdateAsync(int id, T datosActualizar)
        {
            throw new NotImplementedException();
        }
    }
}

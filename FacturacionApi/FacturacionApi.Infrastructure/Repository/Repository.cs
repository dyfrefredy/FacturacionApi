using FacturacionApi.Model.Base;
using FacturacionApi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FacturacionApi.Infrastructure.Repository
{
    public class Repository<T,U> : IRepository<T,U> where T : EntityBase<U>
    {
        private readonly FacturacionContext _dbContext;

        public Repository(FacturacionContext dbContext)            
        {
            _dbContext = dbContext;
        }
       

        public T Add(T entity)
        {
            T entityResult =_dbContext.Set<T>().Add(entity).Entity;
            _dbContext.SaveChanges();
            return entityResult;
        }

        public Expression<Func<T, bool>> Criteria(T entyty)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
             _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChanges();            
        }

        public int Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public virtual T GetById(U id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IIncludableQueryable<T, object> Include(Expression<Func<T, object>> entyty)
        {
            return _dbContext.Set<T>().Include(entyty);
        }

        public List<string> IncludeStrings(string include)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> List()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public virtual IQueryable<T> List(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>()
                   .Where(predicate)
                   .AsQueryable();
        }
    }
}
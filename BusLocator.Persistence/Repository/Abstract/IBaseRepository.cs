﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusLocator.Persistence.Repository.Abstract
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
        bool Any(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        void Delete(T entity);
        void Edit(T entity);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        int Count(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}

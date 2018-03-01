using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using System.Linq.Expressions;

namespace Repository.Framework
{
    public interface IRepository<T> where T : class
    {
        DataResult GetAll();
        DataResult GetAll(Expression<Func<T, bool>> query);
        DataResult GetById(int id);
        DataResult Insert(T entity);
        DataResult Update(T entity);
        DataResult Delete(T entity);
        DataResult SaveChanges();
    }
}

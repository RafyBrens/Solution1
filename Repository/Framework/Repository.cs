using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Data;
using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository.Framework
{
    class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> dbSet;

        public Repository(ApplicationContext context)
        {
            if(context == null)
            {
                throw new Exception("You must specify the context to the application");
            }

            this.context = context;
            dbSet = context.Set<T>();
        }

        public DataResult GetAll()
        {
            DataResult result = new DataResult();
            try
            {
                result.Success = true;

                //Select * from Table
                result.Data = dbSet.ToList();
            }
            catch(Exception ex)
            {
                result.Success = false;
                result.LogError(ex);
            }
            return result;
        }

        public DataResult GetAll(Expression<Func<T, bool>> query)
        {
            DataResult result = new DataResult();
            try
            {
                result.Success = true;

                //Select * from Table where ...
                result.Data = dbSet.Where(query).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.LogError(ex);
            }
            return result;
        }

        public DataResult GetById(int id)
        {
            DataResult result = new DataResult();
            try
            {
                result.Success = true;

                //Select * from Table where id = x
                result.Data = dbSet.Find(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.LogError(ex);
            }
            return result;
        }

        public DataResult Insert(T entity)
        {
            DataResult result = new DataResult();
            try
            {
                result.Success = true;

                //Insert into TABLE (field, field1, field2) values (value, value1, value2)
                dbSet.Add(entity);
                context.SaveChanges();
                result.Data = entity;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.LogError(ex);
            }
            return result;
        }

        public DataResult SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DataResult Update(T entity)
        {
            DataResult result = new DataResult();
            try
            {
                result.Success = true;

                //update TABLE set(field = value) where ... id = var
                context.SaveChanges();
                result.Data = entity;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.LogError(ex);
            }
            return result;
        }

        public DataResult Delete(T entity)
        {
            DataResult result = new DataResult();
            try
            {
                result.Success = true;

                //update TABLE set(field = value) where ... id = var
                dbSet.Remove(entity);
                context.SaveChanges();
                result.Data = entity;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.LogError(ex);
            }
            return result;
        }

    }
}

using System.Data.Entity;
using System;
using UnitOfWork.Data.Database;
using System.Collections.Generic;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWork.Transactions
{
    internal class Request<TEntity> where TEntity : class
    {
        internal UnitOfWorkDevelopmentEntities context;
        internal DbSet<TEntity> dbSet;

        internal TEntity GetById(object id)
        {
            context = new UnitOfWorkDevelopmentEntities();
            dbSet = context.Set<TEntity>();            
            return dbSet.Find(id);
        }
        public virtual TEntity Insert(TEntity entity)
        {
            context = new UnitOfWorkDevelopmentEntities();
            dbSet = context.Set<TEntity>();
            var response = dbSet.Add(entity);
            context.SaveChanges();
            return response;
            //return new Response
            //{
            //    Success = (output == 0) ? true : false,
            //    Result = output,
            //    Exception = (output != 0) ? "Error Inserting into database" : string.Empty
            //};
        }
        public virtual TEntity Update(TEntity entity)
        {
            try
            {
                context = new UnitOfWorkDevelopmentEntities();
                dbSet = context.Set<TEntity>();
                var result = dbSet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return result;
            }
            catch (Exception )
            {
                return null;
            }
        }
        public virtual void Delete(TEntity entity)
        {
            try
            {
                //context = new UnitOfWorkDevelopmentEntities();
                //dbSet = context.Set<TEntity>();                
                if (context.Entry(entity).State == EntityState.Detached)
                {
                    dbSet.Attach(entity);
                }                
                dbSet.Remove(entity);
                var results = context.SaveChanges();
            }
            catch (Exception )
            {

            }
        }
        public virtual void Delete(object id)
        {
            try
            {
                context = new UnitOfWorkDevelopmentEntities();
                dbSet = context.Set<TEntity>();
                TEntity entityToDelete = dbSet.Find(id);                
                Delete(entityToDelete);
                
            }
            catch (Exception )
            {

            }
        }
        public virtual IEnumerable<TEntity> ExecuteQuery(string query)
        {
            try
            {
                context = new UnitOfWorkDevelopmentEntities();
                dbSet = context.Set<TEntity>();
                return dbSet.SqlQuery(query);
            }
            catch (Exception )
            {
                return null;
            }
        }

    }
}

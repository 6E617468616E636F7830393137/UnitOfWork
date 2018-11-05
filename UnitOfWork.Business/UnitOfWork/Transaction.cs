using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWork
{
    public class Transaction<TEntity> where TEntity : class
    {
        public class ExecuteDb : IGenericRequest<TEntity> 
        {
            public TEntity GetById(object id)
            {
                return new Transactions.Request<TEntity>().GetById(id);
            }
            public TEntity Insert(TEntity entity)
            {
                return new Transactions.Request<TEntity>().Insert(entity);
            }
            public TEntity Update(TEntity entity)
            {
                return new Transactions.Request<TEntity>().Update(entity);
            }
            public void Delete(object id)
            {
                new Transactions.Request<TEntity>().Delete(id);
            }

            public IEnumerable<TEntity> ExecuteQuery(string query)
            {
                return new Transactions.Request<TEntity>().ExecuteQuery(query);
            }            
        }
    }
}

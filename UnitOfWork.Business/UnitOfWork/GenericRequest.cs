using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWork
{
    public class GenericRequest<TEntity> where TEntity : class
    {
        // Initialize variables
        private readonly IGenericRequest<TEntity> genericRequest;
        // Constructor
        public GenericRequest(IGenericRequest<TEntity> concreteImplementation)
        {
            genericRequest = concreteImplementation;
        }
        // Implementation
        public virtual TEntity GetById(object id)
        {
            return genericRequest.GetById(id);
        }
        public virtual TEntity Insert(TEntity entity)
        {
            return genericRequest.Insert(entity);
        }
        public virtual TEntity Update(TEntity entity)
        {
            return genericRequest.Update(entity);
        }
        public virtual void Delete(object id)
        {
            genericRequest.Delete(id);
        }
        public virtual IEnumerable<TEntity> ExecuteQuery(string query)
        {
            return genericRequest.ExecuteQuery(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Data.Database;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWorkResponse
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
        public virtual Response GetById(object id)
        {
            return genericRequest.GetById(id);
        }
        public virtual Response Insert(Properties model)
        {
            return genericRequest.Insert(model);
        }
    }
}

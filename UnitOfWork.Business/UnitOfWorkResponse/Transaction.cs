using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Data.Database;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWorkResponse
{
    public class Transaction<TEntity> where TEntity : class
    {
        public class ExecuteRequest : IGenericRequest<TEntity>
        {
            public Response GetById(object id)
            {
                return new Transactions.Request<TEntity>().GetById(id);
            }

            public Response Insert(Properties model)
            {
                return new Transactions.Request<TEntity>().Insert(model);
            }
        }
    }
}

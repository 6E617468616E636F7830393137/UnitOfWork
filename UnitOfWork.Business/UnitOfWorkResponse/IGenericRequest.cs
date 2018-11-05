using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Data.Database;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWorkResponse
{
    public interface IGenericRequest<TEntity> where TEntity : class
    {
        Response GetById(object id);
        Response Insert(Properties model);
    }
}

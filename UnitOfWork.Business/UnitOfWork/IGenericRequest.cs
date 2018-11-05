using System.Collections.Generic;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWork
{
    public interface IGenericRequest<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(object id);
        IEnumerable<TEntity> ExecuteQuery(string query);

    }
}

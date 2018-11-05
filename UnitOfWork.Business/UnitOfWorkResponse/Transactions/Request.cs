using System.Data.Entity;
using System;
using UnitOfWork.Data.Database;
using System.Collections.Generic;
using UnitOfWork.Entities.Models.Response;

namespace UnitOfWork.Business.UnitOfWorkResponse.Transactions
{
    public class Request<TEntity> where TEntity : class
    {
        internal Response GetById(object id)
        {           
            try
            {
                return new Response
                {
                    Result = new Business.UnitOfWork.GenericRequest<Properties>(new Business.UnitOfWork.Transaction<Properties>.ExecuteDb()).GetById(id),
                    Success = true
                };
                                
            }
            catch (Exception ex)
            {
                return new Response
                {
                    Result = null,
                    Success = false,
                    ExceptionMessage = ex.ToString()
                };
            }
        }
        internal virtual Response Insert(Properties model)
        {
            try
            {
                return new Response
                {
                    Result = new Business.UnitOfWork.GenericRequest<Properties>(new Business.UnitOfWork.Transaction<Properties>.ExecuteDb()).Insert(model),
                    Success = true
                };

            }
            catch (Exception ex)
            {
                return new Response
                {
                    Result = null,
                    Success = false,
                    ExceptionMessage = ex.ToString()
                };
            }
        }
    }
}

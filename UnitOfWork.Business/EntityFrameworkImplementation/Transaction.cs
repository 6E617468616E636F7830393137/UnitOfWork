using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Data;
using UnitOfWork.Data.Database;

namespace UnitOfWork.Business.EntityFrameworkImplementation
{
    public class Transaction
    {
        public class Execute : IGenericRequest
        {
            public Properties CreateUpdate(Properties model)
            {
                return new Transactions.Query().CreateUpdate(model);
            }
        }
    }
}

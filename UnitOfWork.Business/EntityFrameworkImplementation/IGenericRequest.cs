using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Data;
using UnitOfWork.Data.Database;

namespace UnitOfWork.Business.EntityFrameworkImplementation
{
    public interface IGenericRequest
    {
        Properties CreateUpdate(Properties model);
    }
}

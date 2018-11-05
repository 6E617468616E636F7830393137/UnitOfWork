using UnitOfWork.Data;
using UnitOfWork.Data.Database;

namespace UnitOfWork.Business.EntityFrameworkImplementation
{
    public class GenericRequest
    {
        // Declaration
        private readonly IGenericRequest _genericRequest;
        // Constructor
        public GenericRequest(IGenericRequest concreteImplementation)
        {
            _genericRequest = concreteImplementation;
        }
        // Implementation
        public Properties Execute(Properties model)
        {
            return _genericRequest.CreateUpdate(model);
        }
    }
}

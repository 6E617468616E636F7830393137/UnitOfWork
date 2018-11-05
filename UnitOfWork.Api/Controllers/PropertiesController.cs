using System;
using System.Web.Http;
using UnitOfWork.Data.Database;

namespace UnitOfWork.Api.Controllers
{
    [RoutePrefix("api")]
    public class PropertiesController : ApiController 
    {
        [Route("Add")]
        public IHttpActionResult Insert([FromBody] UnitOfWork.Data.Database.Properties model) 
        {
            // Create new request insert
            var requestData = new Request
            {
                Id = 0,
                Type = "Properties",
                DateCreated = DateTime.UtcNow,
                MemberId = model.MemberId,
                AccountNumber = model.AccountNumber,
                Success = true,
                Message = string.Empty
            };
            var request = new Business.UnitOfWork.GenericRequest<Request>(new Business.UnitOfWork.Transaction<Request>.ExecuteDb()).Insert(requestData);           
            model.RequestId = request.Id;

            // Create new insert for change
            var properties = new Business.UnitOfWorkResponse.GenericRequest<Properties>(new Business.UnitOfWorkResponse.Transaction<Properties>.ExecuteRequest()).Insert(model);

            return Ok(properties);

        }
        [Route("Update")]
        [HttpPut]
        public IHttpActionResult Update([FromBody] Properties model)
        {
            new Business.UnitOfWork.GenericRequest<Properties>(new Business.UnitOfWork.Transaction<Properties>.ExecuteDb()).Update(model);
            return Ok();
        }
        [Route("Delete")]
        public IHttpActionResult Delete([FromBody] object id)
        {
            new Business.UnitOfWork.GenericRequest<Properties>(new Business.UnitOfWork.Transaction<Properties>.ExecuteDb()).Delete(id);
            return Ok();
        }
        [Route("GetById")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {   
            return Ok(new Business.UnitOfWorkResponse.GenericRequest<Properties>(new Business.UnitOfWorkResponse.Transaction<Properties>.ExecuteRequest()).GetById(id));
        }
        [Route("Query")]
        [HttpPost]
        public IHttpActionResult Query([FromBody] object id)
        {
            var data = new Business.UnitOfWork.GenericRequest<Properties>(new Business.UnitOfWork.Transaction<Properties>.ExecuteDb()).ExecuteQuery(id.ToString());
            return Ok(data);
        }
    }
}

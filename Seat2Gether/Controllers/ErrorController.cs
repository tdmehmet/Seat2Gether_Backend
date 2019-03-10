using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Error")]
    public class ErrorController : BaseController
    {
        private ErrorService ErrorService = null;

        public ErrorController()
        {
            ErrorService = new ErrorService();
        }

        [Route("FindErrorById/{ErrorId}")]
        [HttpPost]
        public IHttpActionResult FindErrorById(string ErrorId)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(ErrorService.FindErrorById(ErrorId));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ErrorController", "FindErrorById", E);
            }
            return result;
        }
    }
}

    
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/PartOneSpecialChair")]
    public class SpecialChairPartOneController : BaseController
    {
        private SpecialChairService SpecialChairService = null;

        public SpecialChairPartOneController()
        {
            SpecialChairService = new SpecialChairService();
        }


        [Route("reportSpecialChairOne/{orderID}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ReportSpecialChairOne(string orderID)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(SpecialChairService.SP_BBNR_UA_Special_Chair_List(orderID));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "SpecialChairPartOneController", "reportSpecialChairOne", E);
            }
            return result;
        }

    }
}
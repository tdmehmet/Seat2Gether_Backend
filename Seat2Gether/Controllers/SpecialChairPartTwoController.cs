using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/PartTwoSpecialChair")]
    public class SpecialChairPartTwoController : BaseController
    {
        private SpecialChairService SpecialChairService = null;

        public SpecialChairPartTwoController()
        {
            SpecialChairService = new SpecialChairService();
        }


        [Route("reportSpecialChairTwo/{orderID}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ReportSpecialChairTwo(string orderID)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(SpecialChairService.SP_BBNR_UA_Special_Chair_Part_List(orderID));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "SpecialChairPartTwoController", "reportSpecialChairTwo", E);
            }
            return result;
        }

    }
}
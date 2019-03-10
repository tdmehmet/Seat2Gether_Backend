using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/EBBelt")]
    public class MasterDataEBBeltController : BaseController
    {
        private MasterDataEBBeltService EBBeltButtonService = null;

        public MasterDataEBBeltController()
        {
            EBBeltButtonService = new MasterDataEBBeltService();
        }


        [Route("EBBeltList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult EBBeltList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(EBBeltButtonService.EBBeltList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataEBBeltController", "EBBeltList", E);
            }

            return result;
        }

        [Route("addEBBelt")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddEBBelt(MasterDataEBBelt eBBelt)
        {
            try
            {
                EBBeltButtonService.AddEBBelt(eBBelt);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataEBBeltController", "addEBBelt", E);
            }

            return Ok("EB-Belt Successfully Created");

        }

        [Route("updateEBBelt")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateEBBelt(MasterDataEBBelt eBBelt)
        {
            try
            {
                EBBeltButtonService.UpdateEBBelt(eBBelt);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataEBBeltController", "updateEBBelt", E);
            }

            return Ok("EB-Belt Successfully Updated");
        }

        [Route("deleteEBBelt")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteEBBelt(MasterDataEBBelt eBBelt)
        {
            try
            {
                EBBeltButtonService.DeleteEBBelt(eBBelt);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataEBBeltController", "deleteEBBelt", E);
            }

            return Ok("Eb-Belt Type Successfully Deleted");
        }
    }
}
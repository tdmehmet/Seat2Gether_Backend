using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/SideCover")]
    public class MasterDataSideCoverController : BaseController
    {
        private MasterDataSideCoverService SideCoverButtonService = null;

        public MasterDataSideCoverController()
        {
            SideCoverButtonService = new MasterDataSideCoverService();
        }

        [Route("SideCoverList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult SideCoverList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(SideCoverButtonService.SideCoverList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSideCoverController", "SideCoverList", E);
            }

            return result;
        }

        [Route("addSideCover")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddSideCover(MasterDataSideCoverDto sideCover)
        {
            try
            {
                SideCoverButtonService.AddSideCover(sideCover);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSideCoverController", "addSideCover", E);
            }
            return Ok("Side Cover Successfully Created");

        }
        [Route("updateSideCover")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateSideCover(MasterDataSideCoverDto sideCover)
        {
            try
            {
                SideCoverButtonService.UpdateSideCover(sideCover);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSideCoverController", "updateSideCover", E);
            }

            return Ok("Side Cover successfully Updated");
        }

        [Route("deleteSideCover")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteSideCover(MasterDataSideCoverDto sideCover)
        {
            try
            {
                SideCoverButtonService.DeleteSideCover(sideCover);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSideCoverController", "deleteSideCover", E);
            }

            return Ok("Side Cover Successfully Deleted");
        }
    }

}
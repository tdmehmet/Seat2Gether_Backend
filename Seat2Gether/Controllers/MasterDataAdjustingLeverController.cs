using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/AdjustingLever")]
    public class MasterDataAdjustingLeverController : BaseController
    {
        private MasterDataAdjustingLeverService AdjustingLeverButtonService = null;

        public MasterDataAdjustingLeverController()
        {
            AdjustingLeverButtonService = new MasterDataAdjustingLeverService();
        }


        [Route("AdjustingLeverList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AdjustingLeverList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(AdjustingLeverButtonService.AdjustingLeverList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdjustingLeverController", "AdjustingLeverList", E);
            }

            return result;
        }

        [Route("addAdjustingLever")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddAdjustingLever(MasterDataAdjustingLeverDto adjustingLever)
        {
            try
            {
                AdjustingLeverButtonService.AddAdjustingLever(adjustingLever);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdjustingLeverController", "addAdjustingLever", E);
            }
            
            return Ok("Adjusting Lever Successfully Created");

        }

        [Route("updateAdjustingLever")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateAdjustingLever(MasterDataAdjustingLeverDto adjustingLever)
        {
            try
            {
                AdjustingLeverButtonService.UpdateAdjustingLever(adjustingLever);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdjustingLeverController", "updateAdjustingLever", E);
            }
            
            return Ok("Adjusting Lever Successfully Updated");
        }

        [Route("deleteAdjustingLever")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteAdjustingLever(MasterDataAdjustingLeverDto adjustingLever)
        {
            try
            {
                AdjustingLeverButtonService.DeleteAdjustingLever(adjustingLever);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdjustingLeverController", "deleteAdjustingLever", E);
            }
            
            return Ok("Adjusting Lever Type Successfully Deleted");
        }
    }

}
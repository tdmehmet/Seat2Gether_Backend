using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/LateralAdjustment")]
    public class MasterDataLateralAdjustmentController : BaseController
    {
        private MasterDataLateralAdjustmentService LateralAdjustmentButtonService = null;

        public MasterDataLateralAdjustmentController()
        {
            LateralAdjustmentButtonService = new MasterDataLateralAdjustmentService();
        }


        [Route("LateralAdjustmentList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult LateralAdjustmentList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(LateralAdjustmentButtonService.LateralAdjustmentList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataLateralAdjustmentController", "LateralAdjustmentList", E);
            }

            return result;
        }

        [Route("addLateralAdjustment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            try
            {
                LateralAdjustmentButtonService.AddLateralAdjustment(lateralAdjustment);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataLateralAdjustmentController", "addLateralAdjustment", E);
            }

            return Ok("Lateral Adjustment Successfully Created");

        }

        [Route("updateLateralAdjustment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            try
            {
                LateralAdjustmentButtonService.UpdateLateralAdjustment(lateralAdjustment);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataLateralAdjustmentController", "updateLateralAdjustment", E);
            }

            return Ok("Lateral Adjustment Successfully Updated");
        }

        [Route("deleteLateralAdjustment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            try
            {
                LateralAdjustmentButtonService.DeleteLateralAdjustment(lateralAdjustment);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataLateralAdjustmentController", "deleteLateralAdjustment", E);
            }
            
            return Ok("Lateral Adjustment Type Successfully Deleted");
        }
    }

}
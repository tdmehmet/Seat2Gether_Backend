using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/RearSeatPan")]
    public class MasterDataRearSeatPanController : BaseController
    {
        private MasterDataRearSeatPanService RearSeatPanButtonService = null;

        public MasterDataRearSeatPanController()
        {
            RearSeatPanButtonService = new MasterDataRearSeatPanService();
        }


        [Route("RearSeatPanList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult RearSeatPanList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(RearSeatPanButtonService.RearSeatPanList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRearSeatPanController", "RearSeatPanList", E);
            }

            return result;
        }

        [Route("addRearSeatPan")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddRearSeatPan(MasterDataRearSeatPanDto rearSeatPan)
        {
            try
            {
                RearSeatPanButtonService.AddRearSeatPan(rearSeatPan);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRearSeatPanController", "addRearSeatPan", E);
            }

            return Ok("Rear Seat Pan Successfully Created");
        }

        [Route("updateRearSeatPan")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateRearSeatPan(MasterDataRearSeatPanDto rearSeatPan)
        {
            try
            {
                RearSeatPanButtonService.UpdateRearSeatPan(rearSeatPan);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRearSeatPanController", "updateRearSeatPan", E);
            }

            return Ok("Rear Seat Pan Successfully Updated");
        }

        [Route("deleteRearSeatPan")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteRearSeatPan(MasterDataRearSeatPanDto rearSeatPan)
        {
            try
            {
                RearSeatPanButtonService.DeleteRearSeatPan(rearSeatPan);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRearSeatPanController", "deleteRearSeatPan", E);
            }

            return Ok("Rear Seat Pan Type Successfully Deleted");
        }

    }
}
using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/Status")]
    public class MasterDataStatusController : BaseController
    {
        private MasterDataStatusService StatusButtonService = null;

        public MasterDataStatusController()
        {
            StatusButtonService = new MasterDataStatusService();
        }


        [Route("StatusList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult StatusList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(StatusButtonService.StatusList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStatusController", "StatusList", E);
            }

            return result;
        }

        [Route("addStatus")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddStatus(MasterDataStatus status)
        {
            try
            {
                StatusButtonService.AddStatus(status);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStatusController", "addStatus", E);
            }

            return Ok("Status Successfully Created");

        }

        [Route("deleteStatus")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteStatus(MasterDataStatus status)
        {
            try
            {
                StatusButtonService.DeleteStatus(status);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStatusController", "deleteStatus", E);
            }

            return Ok("Status Successfully Deleted");
        }

        [Route("updateStatus")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateStatus(MasterDataStatus status)
        {
            try
            {
                StatusButtonService.UpdateStatus(status);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStatusController", "updateStatus", E);
            }

            return Ok("Status Successfully Updated");
        }


    }
}
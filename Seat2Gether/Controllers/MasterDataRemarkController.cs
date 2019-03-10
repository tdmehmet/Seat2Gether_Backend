using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/Remark")]
    public class MasterDataRemarkController : BaseController
    {
        private MasterDataRemarkService RemarkButtonService = null;

        public MasterDataRemarkController()
        {
            RemarkButtonService = new MasterDataRemarkService();
        }


        [Route("RemarkList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult RemarkList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(RemarkButtonService.RemarkList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRemarkController", "RemarkList", E);
            }

            return result;
        }

        [Route("addRemark")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddRemark(RemarkDto remark)
        {
            try
            {
                RemarkButtonService.AddRemark(remark);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRemarkController", "addRemark", E);
            }

            return Ok("Remark Successfully Created");

        }

        [Route("deleteRemark")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteRemark(RemarkDto remark)
        {
            try
            {
                RemarkButtonService.DeleteRemark(remark);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataRemarkController", "deleteRemark", E);
            }

            return Ok("Remark Type Successfully Deleted");
        }

    }

}
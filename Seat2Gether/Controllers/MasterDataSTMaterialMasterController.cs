using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/STMaterialMaster")]
    public class MasterDataSTMaterialMasterController : BaseController
    {
        private MasterDataSTMaterialMasterService STMaterialMasterButtonService = null;

        public MasterDataSTMaterialMasterController()
        {
            STMaterialMasterButtonService = new MasterDataSTMaterialMasterService();
        }

        [Route("STMaterialMasterList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult STMaterialMasterList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(STMaterialMasterButtonService.STMaterialMasterList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSTMaterialMasterController", "STMaterialMasterList", E);
            }

            return result;
        }

        [Route("addSTMaterialMaster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddSTMaterialMaster(MasterDataSTMaterialMasterDto sTMaterialMaster)
        {
            try
            {
                STMaterialMasterButtonService.AddSTMaterialMaster(sTMaterialMaster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSTMaterialMasterController", "addSTMaterialMaster", E);
            }

            return Ok("ST Material Master Successfully Created");

        }

        [Route("updateSTMaterialMaster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateSTMaterialMaster(MasterDataSTMaterialMasterDto sTMaterialMaster)
        {
            try
            {
                STMaterialMasterButtonService.UpdateSTMaterialMaster(sTMaterialMaster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSTMaterialMasterController", "updateSTMaterialMaster", E);
            }

            return Ok("ST Material Master Successfully Updated");
        }

        [Route("deleteSTMaterialMaster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteSTMaterialMaster(MasterDataSTMaterialMasterDto sTMaterialMaster)
        {
            try
            {
                STMaterialMasterButtonService.DeleteSTMaterialMaster(sTMaterialMaster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSTMaterialMasterController", "deleteSTMaterialMaster", E);
            }

            return Ok("ST Material Master Type Successfully Deleted");
        }
    }

}
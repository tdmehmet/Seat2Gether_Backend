using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/ChairType")]
    public class MasterDataChairTypeController : BaseController
    {
        private MasterDataChairTypeService ChairTypeButtonService = null;

        public MasterDataChairTypeController()
        {
            ChairTypeButtonService = new MasterDataChairTypeService();
        }


        [Route("ChairTypeList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ChairTypeList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(ChairTypeButtonService.ChairTypeList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairTypeController", "ChairTypeList", E);
            }

            return result;
        }

        [Route("addChairType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddChairType(MasterDataChairType chairType)
        {
            try
            {
                ChairTypeButtonService.AddChairType(chairType);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairTypeController", "addChairType", E);
            }
            
            return Ok("Chair Type Successfully Created");
        }

        [Route("updateChairType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateChairType(MasterDataChairType chairType)
        {
            try
            {
                ChairTypeButtonService.UpdateChairType(chairType);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairTypeController", "updateChairType", E);
            }
            
            return Ok("Chair Type Successfully Updated");
        }

        [Route("deleteChairType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteChairType(MasterDataChairType chairType)
        {
            try
            {
                ChairTypeButtonService.DeleteChairType(chairType);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairTypeController", "deleteChairType", E);
            }
            
            return Ok("Chair Type Successfully Deleted");
        }




    }
}
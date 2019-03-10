using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using Seat2Gether.services.ExternalServices;
using System;
using System.Linq;
using System.Web.Http;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/ExMasterDataSeatFabricType")]
    public class MasterDataSeatFabricTypeController : ApiController
    {
        private ExMasterDataSeatFabricTypeService ExMasterDataSeatFabricTypeService = null;

        public MasterDataSeatFabricTypeController()
        {
            ExMasterDataSeatFabricTypeService = new ExMasterDataSeatFabricTypeService();
        }

        [Route("GetExMasterDataSeatFabricTypeList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult GetExMasterDataSeatFabricTypeList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(ExMasterDataSeatFabricTypeService.ExMasterDataSeatFabricTypeFindList());
                return result;
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ExMasterDataSeatFabricTypeController", "GetExMasterDataSeatFabricTypeList", E);
            }
        }

        [Route("AddExMasterDataSeatFabricType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddExMasterDataSeatFabricType(ExMasterDataSeatFabricTypeDto exMasterDataSeatFabricType)
        {
            try
            {
                ExMasterDataSeatFabricTypeService.AddExMasterDataSeatFabricType(exMasterDataSeatFabricType);
                return Ok("Vehicle Seat Type Successfully Created");
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ExMasterDataSeatFabricTypeController", "AddExMasterDataSeatFabricType", E);
            }
        }

        [Route("DeleteExMasterDataSeatFabricType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteExMasterDataSeatFabricType(ExMasterDataSeatFabricTypeDto exMasterDataSeatFabricType)
        {
            try
            {
                ExMasterDataSeatFabricTypeService.DeleteExMasterDataSeatFabricType(exMasterDataSeatFabricType);
                return Ok("Vehicle Seat Type Successfully Deleted");
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ExMasterDataSeatFabricTypeController", "DeleteExMasterDataSeatFabricType", E);
            }
        }

        [Route("UpdateExMasterDataSeatFabricType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateExMasterDataSeatFabricType(ExMasterDataSeatFabricTypeDto exMasterDataSeatFabricType)
        {
            try
            {
                ExMasterDataSeatFabricTypeService.UpdateExMasterDataSeatFabricType(exMasterDataSeatFabricType);
                return Ok("Vehicle Seat Type Successfully Updated");
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ExMasterDataSeatFabricTypeController", "UpdateExMasterDataSeatFabricType", E);
            }
        }
    }
}
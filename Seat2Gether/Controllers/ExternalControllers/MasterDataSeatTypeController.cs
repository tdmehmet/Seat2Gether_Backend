using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using Seat2Gether.services.ExternalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/MasterDataSeatType")]
    public class MasterDataSeatTypeController : ApiController
    {
        private MasterDataSeatTypeService masterDataSeatTypeService;
        public MasterDataSeatTypeController()
        {
            masterDataSeatTypeService = new MasterDataSeatTypeService();
        }

        [HttpPost]
        [Route("UpdateMasterDataSeatType")]
        [Authorize]
        public IHttpActionResult UpdateMasterDataSeatType(ExMasterDataSeatTypeDto masterDataSeatType)
        {
            try
            {
                masterDataSeatTypeService.Update(masterDataSeatType);
                return Ok(masterDataSeatType);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatTypeController", "UpdateMasterDataSeatType", E);
            }
        }

        [HttpPost]
        [Route("GetMasterDataSeatTypeList")]
        [Authorize]
        public IHttpActionResult GetMasterDataSeatTypeList()
        {
            try
            {
                var masterDataSeatTypeList = masterDataSeatTypeService.GetList();
                return Ok(masterDataSeatTypeList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatTypeController", "GetMasterDataSeatTypeList", E);
            }
        }

        [HttpPost]
        [Route("DeleteMasterDataSeatType")]
        [Authorize]
        public IHttpActionResult AddMasterDataSeatType(ExMasterDataSeatTypeDto masterDataSeatType)
        {
            try
            {
                masterDataSeatTypeService.Add(masterDataSeatType);
                return Ok(masterDataSeatType);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatTypeController", "DeleteMasterDataSeatType", E);
            }
        }

        [HttpPost]
        [Route("DeleteMasterDataSeatType")]
        [Authorize]
        public IHttpActionResult DeleteMasterDataSeatType(ExMasterDataSeatTypeDto masterDataSeatType)
        {
            try
            {
                masterDataSeatTypeService.Delete(masterDataSeatType);
                return Ok(masterDataSeatType.Id);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatTypeController", "DeleteMasterDataSeatType", E);
            }
        }
    }
}

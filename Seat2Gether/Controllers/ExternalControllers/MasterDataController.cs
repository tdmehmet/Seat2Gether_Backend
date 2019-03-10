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
    [RoutePrefix("api/MasterData")]
    public class MasterDataController : ApiController
    {
        private MasterDataService masterDataService;
        public MasterDataController()
        {
            masterDataService = new MasterDataService();
        }

        [HttpPost]
        [Route("UpdateMasterData/{masterDataTypeId}")]
        [Authorize]
        public IHttpActionResult UpdateMasterData(int masterDataTypeId, ExMasterDataDto masterData)
        {
            try
            {
                masterData.MasterDataTypeId = masterDataTypeId;
                masterDataService.Update(masterData);
                return Ok(masterData);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataController", "UpdateMasterData", E);
            }
        }

        [HttpPost]
        [Route("GetMasterDataList")]
        [Authorize]
        public IHttpActionResult GetMasterDataList()
        {
            try
            {
                var masterDataList = masterDataService.GetList();
                return Ok(masterDataList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataController", "GetMasterDataList", E);
            }
        }
        [HttpPost]
        [Route("GetMasterDataListByType/{masterDataTypeId}")]
        [Authorize]
        public IHttpActionResult GetMasterDataListByType(int masterDataTypeId)
        {
            try
            {
                var masterDataList = masterDataService.GetByTypeList(masterDataTypeId);
                return Ok(masterDataList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataController", "GetByTypeMasterDataList", E);
            }
        }
        [HttpPost]
        [Route("AddMasterData/{masterDataTypeId}")]
        [Authorize]
        public IHttpActionResult AddMasterData(int masterDataTypeId,ExMasterDataDto masterData)
        {
            try
            {
                masterData.MasterDataTypeId = masterDataTypeId;
                masterDataService.Add(masterData);
                return Ok(masterData);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataController", "AddMasterData", E);
            }
        }

        [HttpPost]
        [Route("DeleteMasterData")]
        [Authorize]
        public IHttpActionResult DeleteMasterData(ExMasterDataDto masterData)
        {
            try
            {
                masterDataService.Delete(masterData);
                return Ok(masterData.Id);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataController", "DeleteMasterData", E);
            }
        }
    }
}

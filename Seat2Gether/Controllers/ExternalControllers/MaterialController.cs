using System.Web.Http;
using Seat2Gether.services.ExternalServices;
using Seat2Gether.dto.ExternalDto;
using System;
using Seat2Gether.Exceptions;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/ExMaterial")]
    public class MaterialController : ApiController
    {

        MaterialService materialService;
        public MaterialController()
        {
            materialService = new MaterialService();
        }

        [HttpDelete]
        [Route("DeleteMaterialByBBNumber/{bbNumber}")]
        [Authorize]
        public IHttpActionResult DeleteMaterialByBBNumber(string bbNumber)
        {
            try
            {
                materialService.DeleteByBbNumber(bbNumber);
                return Ok(bbNumber);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MaterialController", "DeleteMaterialByBBNumber", E);
            }
        }

        [HttpGet]
        [Route("GetMaterialList/{bbNumber}")]
        [Authorize]
        public IHttpActionResult GetMaterialList(string bbNumber)
        {
            try
            {
                var materialList = materialService.MaterialList(bbNumber);
                return Ok(materialList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MaterialController", "GetMaterialList", E);
            }
        }

        [HttpGet]
        [Route("GetMaterialListGroupedByStation/{bbNumber}")]
        [Authorize]
        public IHttpActionResult GetMaterialListGroupedByStation(string bbNumber)
        {
            try
            {
                var materialList = materialService.MaterialListGroupByStation(bbNumber);
                return Ok(materialList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MaterialController", "GetMaterialListGroupedByStation", E);
            }
        }

        [HttpPost]
        [Route("AddMaterial")]
        [Authorize]
        public IHttpActionResult AddMaterial(ExMaterialDto model)
        {
            try
            {
                materialService.Add(model);
                return Ok(model);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MaterialController", "AddMaterial", E);
            }
        }

        [HttpPut]
        [Route("UpdateMaterial")]
        [Authorize]
        public IHttpActionResult UpdateMaterial(ExMaterialDto model)
        {
            try
            {
                materialService.Update(model);
                return Ok(model);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MaterialController", "UpdateMaterial", E);
            }
        }

        [HttpDelete]
        [Route("DeleteMaterial/{Id}")]
        [Authorize]
        public IHttpActionResult DeleteMaterial(int Id)
        {
            try
            {
                materialService.Delete(Id);
                return Ok(Id);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MaterialController", "DeleteMaterial", E);
            }

        }

    }
}

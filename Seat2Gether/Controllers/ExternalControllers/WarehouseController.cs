using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using Seat2Gether.services.ExternalServices;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/Warehouse")]
    public class WarehouseController : ApiController
    {
        private MaterialWarehouseService materialWarehouseService;
        public WarehouseController()
        {
            materialWarehouseService = new MaterialWarehouseService();
        }

        [HttpPost]
        [Route("GetWarehouseList")]
        [Authorize]
        public IHttpActionResult GetWarehouseList()
        {
            try
            {
                var warehouseList = materialWarehouseService.GetNamedList();
                return Ok(warehouseList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "WarehouseController", "GetWarehouseList", E);
            }
        }

        [HttpPost]
        [Route("AddWarehouse")]
        [Authorize]
        public IHttpActionResult AddWarehouse(ExMaterialWarehouseDto materialWarehouse)
        {
            try
            {
                materialWarehouseService.Add(materialWarehouse);
                return Ok(materialWarehouse);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "WarehouseController", "AddWarehouse", E);
            }
        }

        [HttpPost]
        [Route("DeleteWarehouse")]
        [Authorize]
        public IHttpActionResult DeleteWarehouse(ExMaterialWarehouseDto materialWarehouse)
        {
            try
            {
                materialWarehouseService.Delete(materialWarehouse);
                return Ok(materialWarehouse.MaterialNumber);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "WarehouseController", "DeleteWarehouse", E);
            }
        }

        [HttpPost]
        [Route("UpdateWarehouse")]
        [Authorize]
        public IHttpActionResult UpdateWarehouse(ExMaterialWarehouseDto materialWarehouse)
        {
            try
            {
                materialWarehouseService.Update(materialWarehouse);
                return Ok(materialWarehouse);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "WarehouseController", "UpdateWarehouse", E);
            }
        }
    }
}

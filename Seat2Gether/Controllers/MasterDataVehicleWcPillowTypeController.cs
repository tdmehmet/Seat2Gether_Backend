using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Seat2Gether.Controllers
{   [RoutePrefix("api/VehicleWcPillowType")]
    public class MasterDataVehicleWcPillowTypeController:BaseController
    {
        private MasterDataVehicleWcPillowTypeService MasterDataVehicleWcPillowTypeService = null;

        public MasterDataVehicleWcPillowTypeController()
        {
            MasterDataVehicleWcPillowTypeService = new MasterDataVehicleWcPillowTypeService();
        }

        [Route("VehicleWcPillowTypeList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleWcPillowTypeList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehicleWcPillowTypeService.VehicleWcPillowTypeList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcPillowTypeController", "VehicleWcPillowTypeList", E);
            }
            return result;
        }

        [Route("AddVehicleWcPillowType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleWcPillowType(MasterDataVehicleWcPillowTypeDto vehicleWcPillowType)
        {
            try
            {
                MasterDataVehicleWcPillowTypeService.AddVehicleWcPillowType(vehicleWcPillowType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcPillowTypeController", "AddVehicleWcPillowType", E);
            }
            return Ok("Vehicle Wc Pillow Type Successfully Created");
        }

        [Route("UpdateVehicleWcPillowType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleWcPillowType(MasterDataVehicleWcPillowTypeDto vehicleWcPillowType)
        {
            try
            {
                MasterDataVehicleWcPillowTypeService.UpdateVehicleWcPillowType(vehicleWcPillowType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcTypeController", "UpdateVehicleWcPillowType", E);

            }
            return Ok("Vehicle Wc Pillow Type Successfully Updated");
        }

        [Route("DeleteVehicleWcPillowType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleWcPillowType(MasterDataVehicleWcPillowTypeDto vehicleWcPillowType)
        {
            try
            {
                MasterDataVehicleWcPillowTypeService.DeleteVehicleWcPillowType(vehicleWcPillowType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcPillowTypeController", "DeleteVehicleWcPillowType", E);
            }
            return Ok("Vehicle Wc Pillow Type Successfully Deleted");
        }
    }
}
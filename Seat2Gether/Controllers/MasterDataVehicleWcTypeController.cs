using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/VehicleWcType")]
    public class MasterDataVehicleWcTypeController:BaseController
    {
        private MasterDataVehicleWcTypeService MasterDataVehicleWcTypeService = null;

        public MasterDataVehicleWcTypeController()
        {
            MasterDataVehicleWcTypeService = new MasterDataVehicleWcTypeService();
        }

        [Route("VehicleWcTypeList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleWcTypeList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehicleWcTypeService.VehicleWcTypeList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcTypeController", "VehicleWcTypeList", E);

            }
            return result;
        }

        [Route("AddVehicleWcType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleWcType(MasterDataVehicleWcTypeDto vehicleWcType)
        {
            try
            {
                MasterDataVehicleWcTypeService.AddVehicleWcType(vehicleWcType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcType", "AddVehicleWcType", E);
            }
            return Ok("Vehicle Successfully Created");
        }


        [Route("UpdateVehicleWcType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleWcType(MasterDataVehicleWcTypeDto vehicleWcType)
        {
            try
            {
                MasterDataVehicleWcTypeService.UpdateVehicleWcType(vehicleWcType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcType", "UpdateVehicleWcType", E);
            }
            return Ok("Vehicle Successfully Updated");
        }


        [Route("DeleteVehicleWcType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleWcType(MasterDataVehicleWcTypeDto vehicleWcType)
        {
            try
            {
                MasterDataVehicleWcTypeService.DeleteVehicleWcType(vehicleWcType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleWcType", "DeleteVehicleWcType", E);
            }
            return Ok("Vehicle Successfully Deleted");
        }

    }
}
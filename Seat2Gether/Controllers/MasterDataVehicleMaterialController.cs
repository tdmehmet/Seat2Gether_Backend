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
    [RoutePrefix("api/VehicleMaterial")]
    public class MasterDataVehicleMaterialController : BaseController
    {
        private MasterDataVehicleMaterialService vehicleMaterialService = null;

        public MasterDataVehicleMaterialController()
        {
            vehicleMaterialService = new MasterDataVehicleMaterialService();
        }


        [Route("VehicleMaterialList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleMaterialList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleMaterialService.VehicleMaterialList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleMaterialController", "VehicleMaterialList", E);
            }

            return result;
        }

        [Route("addVehicleMaterial")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleMaterial(MasterDataVehicleMaterialDto vehicleMaterial)
        {
            try
            {
                vehicleMaterialService.AddVehicleMaterial(vehicleMaterial);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleMaterialController", "AddVehicleMaterial", E);
            }

            return Ok("Vehicle Material Successfully Created");

        }

        [Route("updateVehicleMaterial")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleMaterial(MasterDataVehicleMaterialDto vehicleMaterial)
        {
            try
            {
                vehicleMaterialService.UpdateVehicleMaterial(vehicleMaterial);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleMaterialController", "UpdateVehicleMaterial", E);
            }

            return Ok("Vehicle Material Successfully Updated");
        }

        [Route("deleteVehicleMaterial")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleMaterial(MasterDataVehicleMaterialDto vehicleMaterial)
        {
            try
            {
                vehicleMaterialService.DeleteVehicleMaterial(vehicleMaterial);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleMaterialController", "DeleteVehicleMaterial", E);
            }

            return Ok("Vehicle Material Type Successfully Deleted");
        }
    }
}

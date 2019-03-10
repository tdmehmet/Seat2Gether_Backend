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


    [RoutePrefix("api/VehicleSeatFabric")]
    public class MasterDataVehicleSeatFabricController : BaseController
    {
        private MasterDataVehicleSeatFabricService vehicleSeatFabricService = null;

        public MasterDataVehicleSeatFabricController()
        {
            vehicleSeatFabricService = new MasterDataVehicleSeatFabricService();
        }


        [Route("VehicleSeatFabricList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleSeatFabricList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleSeatFabricService.VehicleSeatFabricList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatFabricController", "VehicleSeatFabricList", E);
            }

            return result;
        }

        [Route("addVehicleSeatFabric")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleSeatFabric(MasterDataVehicleSeatFabricDto vehicleSeatFabric)
        {
            try
            {
                vehicleSeatFabricService.AddVehicleSeatFabric(vehicleSeatFabric);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatFabricController", "AddVehicleSeatFabric", E);
            }

            return Ok("Vehicle Seat Fabric Successfully Created");

        }

        [Route("updateVehicleSeatFabric")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleSeatFabric(MasterDataVehicleSeatFabricDto vehicleSeatFabric)
        {
            try
            {
                vehicleSeatFabricService.UpdateVehicleSeatFabric(vehicleSeatFabric);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatFabricController", "UpdateVehicleSeatFabric", E);
            }

            return Ok("Vehicle Seat Fabric Successfully Updated");
        }

        [Route("deleteVehicleSeatFabric")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleSeatFabric(MasterDataVehicleSeatFabricDto vehicleSeatFabric)
        {
            try
            {
                vehicleSeatFabricService.DeleteVehicleSeatFabric(vehicleSeatFabric);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatFabricController", "DeleteVehicleSeatFabric", E);
            }

            return Ok("Vehicle Seat Fabric Type Successfully Deleted");
        }

        [Route("FindVehicleSeatFabricByVehicleId/{vehicleId}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindVehicleSeatFabricByID(decimal vehicleId)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleSeatFabricService.FindVehicleSeatFabricByVehicleId(vehicleId));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatFabricController", "DeleteVehicleSeatFabric", E);
            }
            return result;
        }
    }
}

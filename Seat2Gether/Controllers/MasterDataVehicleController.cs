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


    [RoutePrefix("api/Vehicle")]
    public class MasterDataVehicleController : BaseController
    {
        private MasterDataVehicleService vehicleService = null;

        public MasterDataVehicleController()
        {
            vehicleService = new MasterDataVehicleService();
        }


        [Route("VehicleList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleService.VehicleList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleController", "VehicleList", E);
            }

            return result;
        }

        [Route("addVehicle")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicle(MasterDataVehicleDto vehicle)
        {
            try
            {
                vehicleService.AddVehicle(vehicle);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleController", "AddVehicle", E);
            }

            return Ok("Vehicle Successfully Created");

        }

        [Route("updateVehicle")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicle(MasterDataVehicleDto vehicle)
        {
            try
            {
                vehicleService.UpdateVehicle(vehicle);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleController", "UpdateVehicle", E);
            }

            return Ok("Vehicle  Successfully Updated");
        }

        [Route("deleteVehicle")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicle(MasterDataVehicleDto vehicle)
        {
            try
            {
                vehicleService.DeleteVehicle(vehicle);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleController", "DeleteVehicle", E);
            }

            return Ok("Vehicle Type Successfully Deleted");
        }

        [Route("FindVehicleByBody")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindVehicleByBody(MasterDataVehicleDto masterDataVehicleDto)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleService.FindVehicleByBody(masterDataVehicleDto));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleController", "FindVehicleByBody", E);
            }

            return result;
        }

        [Route("FindVehicleByID/{vehicleID}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindVehicleByID(decimal vehicleID)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleService.FindVehicleByID(vehicleID));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleController", "FindVehicleByID", E);
            }
            return result;
        }
    }
}
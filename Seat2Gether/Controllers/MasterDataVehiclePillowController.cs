using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Seat2Gether.Controllers
{   [RoutePrefix("api/VehiclePillow")]
    public class MasterDataVehiclePillowController:BaseController
    {
        private MasterDataVehiclePillowService MasterDataVehiclePillowService = null;

        public MasterDataVehiclePillowController()
        {
            MasterDataVehiclePillowService = new MasterDataVehiclePillowService();
        }

        [Route("VehiclePillowList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehiclePillowList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehiclePillowService.VehiclePillowList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehiclePillowController", "VehiclePillowList", E);
            }
            return result;
        }


        [Route("AddVehiclePillow")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehiclePillow(MasterDataVehiclePillowDto vehiclePillow)
        {
            try
            {
                MasterDataVehiclePillowService.AddVehiclePillow(vehiclePillow);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehiclePillowController", "AddVehiclePillow", E);
            }
            return Ok("Vehicle Pillow Successfully Created");
        }

        [Route("UpdateVehiclePillow")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehiclePillow(MasterDataVehiclePillowDto vehiclePillow)
        {
            try
            {
                MasterDataVehiclePillowService.UpdateVehiclePillow(vehiclePillow);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehiclePillowController", "UpdateVehiclePillow",E);
            }
            return Ok("Vehicle Pillow Successfully Updated");
        }

        [Route("DeleteVehiclePillow")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehiclePillow(MasterDataVehiclePillowDto vehiclePillow)
        {
            try
            {
                MasterDataVehiclePillowService.DeleteVehiclePillow(vehiclePillow);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehiclePillowController", "DeleteVehiclePillow", E);
            }
            return Ok("Vehicle Pillow Successfully Deleted");
        }

    }
}
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
    [RoutePrefix("api/VehicleBackRowPillow")]
    public class MasterDataVehicleBackRowPillowController : BaseController
    {
        private MasterDataVehicleBackRowPillowService MasterDataVehicleBackRowPillowServices = null;

        public MasterDataVehicleBackRowPillowController()
        {
            MasterDataVehicleBackRowPillowServices = new MasterDataVehicleBackRowPillowService();
        }

        [Route("VehicleBackRowPillowList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleBackRowPillowList()
        {
            IHttpActionResult result = null;

            try
            {
                result = Ok(MasterDataVehicleBackRowPillowServices.VehicleBackRowPillowList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleBackRowPillowController", "VehicleBackRowPillowList", E);
            }
            return result;
        }

        [Route("AddVehicleBackRowPillow")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleBackRowPillow(MasterDataVehicleBackRowPillowDto vehicleBackRowPillow)
        {
            try
            {
                MasterDataVehicleBackRowPillowServices.AddVehicleBackRowPillow(vehicleBackRowPillow);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleBackRowPillowController", "AddVehicleBackRowPillow", E);
            }
            return Ok("Vehicle Back Row Pillow Successfully Created");
        }

        [Route("UpdateVehicleBackRowPillow")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleBackRowPillow(MasterDataVehicleBackRowPillowDto vehicleBackRowPillow)
        {
            try
            {
                MasterDataVehicleBackRowPillowServices.UpdateVehicleBackRowPillow(vehicleBackRowPillow);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleBackRowPillowController", "UpdateVehicleBackRowPillow", E);
            }
            return Ok("Vehicle Back Row Pillow Successfully Updated");
        }

        [Route("DeleteVehicleBackRowPillow")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleBackRowPillow(MasterDataVehicleBackRowPillowDto vehicleBackRowPillow)
        {
            try
            {
                MasterDataVehicleBackRowPillowServices.DeleteVehicleBackRowPillow(vehicleBackRowPillow);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleBackRowPillowController", "DeleteVehicleBackRowPillow", E);
            }
            return Ok("Vehicle Back Row Pillow Successfully Deleted");
        }
    }
}
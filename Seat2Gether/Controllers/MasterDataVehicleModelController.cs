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
    [RoutePrefix("api/VehicleModel")]
    public class MasterDataVehicleModelController:BaseController
    {
        private MasterDataVehicleModelService MasterDataVehicleService = null;

        public MasterDataVehicleModelController()
        {
            MasterDataVehicleService = new MasterDataVehicleModelService();
        }

        [Route("VehicleModelList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleModelFindList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehicleService.VehicleModelFindList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleModelController", "VehicleModelFindList", E);
                
            }
            return result;
        }

        [Route("AddVehicleModel")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleModel(MasterDataVehicleModelDto vehicleModel)
        {
            try
            {
                MasterDataVehicleService.AddVehicleModel(vehicleModel);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleModelController", "AddVehicleModel", E);
            }
            return Ok("Vehicle Model Successfully Created");
        }

        [Route("DeleteVehicleModel")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleModel(MasterDataVehicleModelDto vehicleModel)
        {
            try
            {
                MasterDataVehicleService.DeleteVehicleModel(vehicleModel);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleModelController", "DeleteVehicleModel", E);
            }
            return Ok("Vehicle Model Successfully Deleted");
        }

        [Route("UpdateVehicleModel")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleModel(MasterDataVehicleModelDto vehicleModel)
        {
            try
            {
                MasterDataVehicleService.UpdateVehicleModel(vehicleModel);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleModelController", "UpdateVehicleModel", E);
            }
            return Ok("Vehicle Model Successfully Updated");
        }
    }
}
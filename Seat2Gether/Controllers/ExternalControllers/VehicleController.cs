using System.Web.Http;
using System;
using Seat2Gether.services.ExternalServices;
using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using System.Security.Claims;
using System.Linq;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/VehicleExternal")]
    public class VehicleController : ApiController
    {
        VehicleService vehicleService;
        public VehicleController()
        {
            vehicleService = new VehicleService();
        }

        [HttpPost]
        [Route("AddVehicle")]
        [Authorize]
        public IHttpActionResult AddVehicle(ExVehicleDto model)
        {
            try
            {
                var user = (User as ClaimsPrincipal).Claims.FirstOrDefault(k => k.Type == "sub").Value;
                model.InsertUser = user;
                model.UpdateUser = user;
                vehicleService.Add(model);
                return Ok(model);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "VehicleController", "AddVehicle", E);
            }
        }

        [HttpPut]
        [Route("UpdateVehicle")]
        [Authorize]
        public IHttpActionResult UpdateVehicle(ExVehicleDto model)
        {
            try
            {
                var user = (User as ClaimsPrincipal).Claims.FirstOrDefault(k => k.Type == "sub").Value;
                model.UpdateUser = user;
                vehicleService.Update(model);
                return Ok(model);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "VehicleController", "UpdateVehicle", E);
            }
        }

        [HttpDelete]
        [Route("DeleteVehicle/{bbNumber}")]
        [Authorize]
        public IHttpActionResult DeleteVehicle(string bbNumber)
        {
            try
            {
                vehicleService.Delete(bbNumber);
                return Ok(bbNumber);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "VehicleController", "DeleteVehicle", E);
            }

        }

        [HttpGet]
        [Route("GetVehicleList")]
        [Authorize]
        public IHttpActionResult GetVehicleList()
        {

            try
            {
                var vehicleList = vehicleService.GetList();
                return Ok(vehicleList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "VehicleController", "GetVehicleList", E);
            }
        }

        [HttpPost]
        [Route("GetFilteredVehicleList")]
        [Authorize]
        public IHttpActionResult GetFilteredVehicleList(ExVehicleFilterDto vehicleFilterDto)
        {
            try
            {
                var vehicleList = vehicleService.GetFilteredList(vehicleFilterDto);
                return Ok(vehicleList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "VehicleController", "GetFilteredVehicleList", E);
            }
        }

        [HttpGet]
        [Route("GetVehicle/{bbNumber}")]
        [Authorize]
        public IHttpActionResult GetVehicle(string bbNumber)
        {
            try
            {
                var vehicle = vehicleService.Find(bbNumber);
                return Ok(vehicle);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "VehicleController", "GetVehicle", E);
            }
        }
    }
}

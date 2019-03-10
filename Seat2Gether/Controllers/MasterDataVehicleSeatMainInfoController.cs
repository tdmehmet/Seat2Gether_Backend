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
    

        [RoutePrefix("api/VehicleSeatMainInfo")]
        public class MasterDataVehicleSeatMainInfoController : BaseController
        {
            private MasterDataVehicleSeatMainInfoService vehicleSeatMainInfoService = null;

            public MasterDataVehicleSeatMainInfoController()
            {
            vehicleSeatMainInfoService = new MasterDataVehicleSeatMainInfoService();
            }


            [Route("VehicleSeatMainInfoList")]
            [HttpPost]
            [Authorize]
            public IHttpActionResult VehicleSeatMainInfoList()
            {
                IHttpActionResult result = null;
                try
                {
                    result = Ok(vehicleSeatMainInfoService.VehicleSeatMainInfoList());
                }
                catch (Exception E)
                {
                    throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatMainInfoController", "VehicleSeatMainInfoList", E);
                }

                return result;
            }

            [Route("addVehicleSeatMainInfo")]
            [HttpPost]
            [Authorize]
            public IHttpActionResult AddVehicleSeatMainInfo(MasterDataVehicleSeatMainInfoDto vehicleSeatMainInfo)
            {
                try
                {
                vehicleSeatMainInfoService.AddVehicleSeatMainInfo(vehicleSeatMainInfo);
                }
                catch (Exception E)
                {
                    throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatMainInfoController", "AddVehicleSeatMainInfo", E);
                }

                return Ok("Vehicle Seat Main Info Successfully Created");

            }

            [Route("updateVehicleSeatMainInfo")]
            [HttpPost]
            [Authorize]
            public IHttpActionResult UpdateVehicleSeatMainInfo(MasterDataVehicleSeatMainInfoDto vehicleSeatMainInfo)
            {
                try
                {
                vehicleSeatMainInfoService.UpdateVehicleSeatMainInfo(vehicleSeatMainInfo);
                }
                catch (Exception E)
                {
                    throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatMainInfoController", "UpdateVehicleSeatMainInfo", E);
                }

                return Ok("Vehicle Seat Main Info  Successfully Updated");
            }

            [Route("deleteVehicleSeatMainInfo")]
            [HttpPost]
            [Authorize]
            public IHttpActionResult DeleteVehicleSeatMainInfo(MasterDataVehicleSeatMainInfoDto vehicleSeatMainInfo)
            {
                try
                {
                vehicleSeatMainInfoService.DeleteVehicleSeatMainInfo(vehicleSeatMainInfo);
                }
                catch (Exception E)
                {
                    throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatMainInfoController", "DeleteVehicleSeatMainInfo", E);
                }

                return Ok("Vehicle Seat Main Info  Successfully Deleted");
            }


        [Route("FindVehicleSeatById/{vehicleId}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindVehicleSeatMainInfoByVehicleId(decimal vehicleId)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(vehicleSeatMainInfoService.FindVehicleSeatMainInfoByVehicleId(vehicleId));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatMainInfoController", "FindVehicleSeatMainInfoByID", E);
            }
            return result;
        }
    }
    }

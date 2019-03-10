using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Seat2Gether.services;
using Seat2Gether.Exceptions;
using Seat2Gether.dto;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/VehicleSeatHeaderFastenerType")]
    public class MasterDataVehicleSeatHeaderFastenerTypeController:BaseController
    {
        private MasterDataVehicleSeatHeaderFastenerTypeService MasterDataVehicleSeatHeaderFastenerTypeService = null;

        public MasterDataVehicleSeatHeaderFastenerTypeController()
        {
            MasterDataVehicleSeatHeaderFastenerTypeService = new MasterDataVehicleSeatHeaderFastenerTypeService();
        }
        
        [Route("FindVehicleSeatHeaderFastenerType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindVehicleSeatHeaderFastenerType()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehicleSeatHeaderFastenerTypeService.FindVehicleSeatHeaderFastenerType());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatHeaderFastenerTypeController", "FindVehicleSeatHeaderFastenerType",E);
            }
            return result;
        }

        [Route("AddVehicleSeatHeaderFastenerType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerTypeDto vehicleSeatHeaderFastenerType)
        {
            try
            {
                MasterDataVehicleSeatHeaderFastenerTypeService.AddVehicleSeatHeaderFastenerType(vehicleSeatHeaderFastenerType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatHeaderFastenerTypeController", "AddVehicleSeatHeaderFastenerType", E);
            }
            return Ok("Vehicle Seat Header Fastener Type Successfully Created");
        }

        [Route("UpdateVehicleSeatHeaderFastenerType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerTypeDto vehicleSeatHeaderFastenerType)
        {
            try
            {
                MasterDataVehicleSeatHeaderFastenerTypeService.UpdateVehicleSeatHeaderFastenerType(vehicleSeatHeaderFastenerType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatHeaderFastenerTypeController", "UpdateVehicleSeatHeaderFastenerType", E);
            }
            return Ok("Vehicle Seat Header Fastener Type Successfully Updated");
        }

        [Route("DeleteVehicleSeatHeaderFastenerType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerTypeDto vehicleSeatHeaderFastenerType)
        {
            try
            {
                MasterDataVehicleSeatHeaderFastenerTypeService.DeleteVehicleSeatHeaderFastenerType(vehicleSeatHeaderFastenerType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatHeaderFastenerTypeController", "DeleteVehicleSeatHeaderFastenerType", E);
            }
            return Ok("Vehicle Seat Header Fastener Type Successfully Deleted");
        }


    }
}
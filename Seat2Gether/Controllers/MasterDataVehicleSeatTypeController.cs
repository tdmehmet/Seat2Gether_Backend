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
    [RoutePrefix("api/VehicleSeatType")]
    public class MasterDataVehicleSeatTypeController : BaseController
    {
        private MasterDataVehicleSeatTypeService MasterDataVehicleSeatTypeService = null;

        public MasterDataVehicleSeatTypeController()
        {
            MasterDataVehicleSeatTypeService = new MasterDataVehicleSeatTypeService();
        }

        [Route("VehicleSeatTypelList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleSeatTypeFindList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehicleSeatTypeService.VehicleSeatTypeFindList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatTypeController", "VehicleSeatTypeFindList", E);

            }
            return result;
        }

        [Route("AddVehicleSeatType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleSeatType(MasterDataVehicleSeatTypeDto vehicleSeatType)
        {
            try
            {
                MasterDataVehicleSeatTypeService.AddVehicleSeatType(vehicleSeatType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatTypeController", "AddVehicleSeatType", E);
            }
            return Ok("Vehicle Seat Type Successfully Created");
        }

        [Route("DeleteVehicleSeatType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleSeatType(MasterDataVehicleSeatTypeDto vehicleSeatType)
        {
            try
            {
                MasterDataVehicleSeatTypeService.DeleteVehicleSeatType(vehicleSeatType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatTypeController", "DeleteVehicleSeatType", E);
            }
            return Ok("Vehicle Seat Type Successfully Deleted");
        }

        [Route("UpdateVehicleSeatTypeModel")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleModel(MasterDataVehicleSeatTypeDto vehicleSeatType)
        {
            try
            {
                MasterDataVehicleSeatTypeService.UpdateVehicleSeatType(vehicleSeatType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleSeatTypeController", "DeleteVehicleSeatType", E);
            }
            return Ok("Vehicle Seat Type Successfully Updated");
        }
    }
}
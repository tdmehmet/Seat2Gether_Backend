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
    

        [RoutePrefix("api/VehicleType")]
        public class MasterDataVehicleTypeController : BaseController
        {
            private MasterDataVehicleTypeService vehicleTypeService = null;

            public MasterDataVehicleTypeController()
            {
            vehicleTypeService = new MasterDataVehicleTypeService();
            }


            [Route("FindVehicleTypes")]
            [HttpPost]
            [Authorize]
            public IHttpActionResult FindVehicleTypes()
            {
                IHttpActionResult result = null;
                try
                {
                    result = Ok(vehicleTypeService.FindVehicleTypes());
                }
                catch (Exception E)
                {
                    throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleTypeController", "FindVehicleTypes", E);
                }

                return result;
            }

    }
}
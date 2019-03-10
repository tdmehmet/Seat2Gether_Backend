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
    [RoutePrefix("api/VehicleHolderAssemblyType")]
    public class MasterDataVehicleHolderAssemblyTypeController : BaseController
    {
        private MasterDataVehicleHolderAssemblyTypeService MasterDataVehicleHolderAssemblyTypeService = null;

        public MasterDataVehicleHolderAssemblyTypeController()
        {
            MasterDataVehicleHolderAssemblyTypeService = new MasterDataVehicleHolderAssemblyTypeService();
        }

        [Route("VehicleHolderAssemblyTypeList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleHolderAssemblyTypeList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataVehicleHolderAssemblyTypeService.VehicleHolderAssemblyTypeList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHolderAssemblyTypeController", "VehicleHolderAssemblyTypeList", E);
            }
            return result;
        }


        [Route("AddVehicleHolderAssemblyType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyTypeDto vehicleHolderAssemblyType)
        {
            try
            {
                MasterDataVehicleHolderAssemblyTypeService.AddVehicleHolderAssemblyType(vehicleHolderAssemblyType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHolderAssemblyTypeController", "AddVehicleHolderAssemblyType", E);
            }
            return Ok("Vehicle Holder Assembly Type Successfully Created");
        }


        [Route("UpdateVehicleHolderAssemblyType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyTypeDto vehicleHolderAssemblyType)
        {
            try
            {
                MasterDataVehicleHolderAssemblyTypeService.UpdateVehicleHolderAssemblyType(vehicleHolderAssemblyType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHolderAssemblyTypeController", "UpdateVehicleHolderAssemblyType", E);
            }
            return Ok("Vehicle Holder Assembly Type Successfully Updated");
        }


        [Route("DeleteVehicleHolderAssemblyType")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyTypeDto vehicleHolderAssemblyType)
        {
            try
            {
                MasterDataVehicleHolderAssemblyTypeService.DeleteVehicleHolderAssemblyType(vehicleHolderAssemblyType);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHolderAssemblyTypeController", "DeleteVehicleHolderAssemblyType", E);
            }
            return Ok("Vehicle Holder Assembly Type Successfully Deleted");
        }


    }
}
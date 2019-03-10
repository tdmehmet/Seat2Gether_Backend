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
    [RoutePrefix("api/VehicleHandHolderDecorate")]
    public class MasterDataVehicleHandHolderDecorateController : BaseController
    {
        private MasterDataVehicleHandHolderDecorateService MasterDataVehicleHandHolderDecorateService = null;

        public MasterDataVehicleHandHolderDecorateController()
        {
            MasterDataVehicleHandHolderDecorateService = new MasterDataVehicleHandHolderDecorateService();
        }

        [Route("VehicleHandHolderDecorateList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult VehicleHandHolderDecorateList()
        {
            IHttpActionResult result = null;
            try
            {
                result= Ok(MasterDataVehicleHandHolderDecorateService.VehicleHandHolderDecorateList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHandHolderDecorateController", "VehicleHandHolderDecorateList", E);
            }
            return result;

        }

        [Route("AddVehicleHandHolderDecorate")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorateDto VehicleHandHolderDecorate)
        {
            try
            {
                MasterDataVehicleHandHolderDecorateService.AddMasterDataVehicleHandHolderDecorate(VehicleHandHolderDecorate);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHandHolderDecorateController", "AddVehicleHandHolderDecorate",E);
            }
            return Ok("Vehicle Hand Holder Decorate Successfully Created");
        }

        [Route("UpdateVehicleHandHolderDecorate")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorateDto VehicleHandHolderDecorate)
        {
            try
            {
                MasterDataVehicleHandHolderDecorateService.UpdateMasterDataVehicleHandHolderDecorate(VehicleHandHolderDecorate);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHandHolderDecorateController", "UpdateVehicleHandHolderDecorate", E);
            }
            return Ok("Vehicle Hand Holder Decorate Successfully Updated");
        }

        [Route("DeleteVehicleHandHolderDecorate")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorateDto VehicleHandHolderDecorate)
        {
            try
            {
                MasterDataVehicleHandHolderDecorateService.DeleteMasterDataVehicleHandHolderDecorate(VehicleHandHolderDecorate);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataVehicleHandHolderDecorateController", "DeleteVehicleHandHolderDecorate", E);
            }
            return Ok("Vehicle Hand Holder Decorate Successfully Deleted");
        }

    }
}
using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/StCharacteristic")]
    public class MasterDataStCharacteristicController : BaseController
    {
        private MasterDataStCharacteristicService StCharacteristicButtonService = null;

        public MasterDataStCharacteristicController()
        {
            StCharacteristicButtonService = new MasterDataStCharacteristicService();
        }


        [Route("StCharacteristicList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult StCharacteristicList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(StCharacteristicButtonService.StCharacteristicList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStCharacteristicController", "StCharacteristicList", E);
            }

            return result;
        }

        [Route("addStCharacteristic")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddStCharacteristic(MasterDataSTCharacteristicDto stCharacteristic)
        {
            try
            {
                StCharacteristicButtonService.AddStCharacteristic(stCharacteristic);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStCharacteristicController", "addStCharacteristic", E);
            }
            
            return Ok("ST Characteristic Successfully Created");
        }

        [Route("updateStCharacteristic")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateStCharacteristic(MasterDataSTCharacteristicDto stCharacteristic)
        {
            try
            {
                StCharacteristicButtonService.UpdateStCharacteristic(stCharacteristic);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStCharacteristicController", "updateStCharacteristic", E);
            }

            return Ok("ST Characteristic Successfully Updated");
        }

        [Route("deleteStCharacteristic")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteStCharacteristic(MasterDataSTCharacteristicDto stCharacteristic)
        {
            try
            {
                StCharacteristicButtonService.DeleteStCharacteristic(stCharacteristic);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataStCharacteristicController", "deleteStCharacteristic", E);
            }

            return Ok("ST Characteristic Type Successfully Deleted");
        }
    }


}
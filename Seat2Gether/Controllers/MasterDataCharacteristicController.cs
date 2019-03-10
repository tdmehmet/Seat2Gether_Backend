using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Characteristic")]
    public class MasterDataCharacteristicController : ApiController
    {
        private MasterDataCharacteristicService CharacteristicButtonService = null;

        public MasterDataCharacteristicController()
        {
            CharacteristicButtonService = new MasterDataCharacteristicService();
        }


        [Route("CharacteristicList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult CharacteristicList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(CharacteristicButtonService.TCharacteristicList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataCharacteristicController", "CharacteristicList", E);
            }

            return result;
        }

        [Route("addCharacteristic")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddCharacteristic(MasterDataCharacteristic characteristic)
        {
            try
            {
                CharacteristicButtonService.AddCharacteristic(characteristic);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataCharacteristicController", "addCharacteristic", E);
            }

            return Ok("Characteristic Successfully Created");

        }

        [Route("deleteCharacteristic")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteCharacteristic(MasterDataCharacteristic characteristic)
        {
            try
            {
                CharacteristicButtonService.DeleteCharacteristic(characteristic);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataCharacteristicController", "deleteCharacteristic", E);
            }

            return Ok("Characteristic Successfully Deleted");
        }

        [Route("updateCharacteristic")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateCharacteristic(MasterDataCharacteristic characteristic)
        {
            try
            {
                CharacteristicButtonService.UpdateCharacteristic(characteristic);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataCharacteristicController", "updateCharacteristic", E);
            }

            return Ok("Characteristic Successfully Updated");
        }


    }
}
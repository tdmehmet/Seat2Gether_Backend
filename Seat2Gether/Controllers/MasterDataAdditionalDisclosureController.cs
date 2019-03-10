using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{


    [RoutePrefix("api/AdditionalDisclosure")]
    public class MasterDataAdditionalDisclosureController : BaseController
    {
        private MasterDataAdditionalDisclosureService AdditionalDisclosureButtonService = null;

        public MasterDataAdditionalDisclosureController()
        {
            AdditionalDisclosureButtonService = new MasterDataAdditionalDisclosureService();
        }


        [Route("AdditionalDisclosureList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AdditionalDisclosureList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(AdditionalDisclosureButtonService.AdditionalDisclosureList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdditionalDisclosureController", "AdditionalDisclosureList", E);
            }

            return result;
        }

        [Route("addAdditionalDisclosure")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            try
            {
                AdditionalDisclosureButtonService.AddAdditionalDisclosure(additionalDisclosure);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdditionalDisclosureController", "addAdditionalDisclosure", E);
            }
            
            return Ok("Additional Disclosure Successfully Created");

        }

        [Route("deleteAdditionalDisclosure")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            try
            {
                AdditionalDisclosureButtonService.DeleteAdditionalDisclosure(additionalDisclosure);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdditionalDisclosureController", "deleteAdditionalDisclosure", E);
            }
            
            return Ok("Additional Disclosure Successfully Deleted");
        }

        [Route("updateAdditionalDisclosure")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateAdditionalDisclosure(MasterDataAdditionalDisclosure additionalDisclosure)
        {
            try
            {
                AdditionalDisclosureButtonService.UpdateAdditionalDisclosure(additionalDisclosure);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataAdditionalDisclosureController", "updateAdditionalDisclosure", E);
            }
            
            return Ok("Additional Disclosure Successfully Updated");
        }


    }

}
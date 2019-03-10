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
    [RoutePrefix("api/SupportTubes")]
    public class MasterDataSupportTubesController:BaseController
    {
        private MasterDataSupportTubesService MasterDataSupportTubesService = null;

        public MasterDataSupportTubesController()
        {
            MasterDataSupportTubesService = new MasterDataSupportTubesService();
        }

        [Route("SupportTubesList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult SupportTubesList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataSupportTubesService.SupportTubesList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSupportTubesController", "SupportTubesList", E);
            }
            return result;
        }


        [Route("AddSupportTubes")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddSupportTubes(MasterDataSupportTubesDto supportTubes)
        {
            try
            {
                MasterDataSupportTubesService.AddSupportTubes(supportTubes);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSupportTubesController", "AddSupportTubes", E);
            }
            return Ok("Support Tubes Successfully Created.");
        }

        [Route("UpdateSupportTubes")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateSupportTubes(MasterDataSupportTubesDto supportTubes)
        {
            try
            {
                MasterDataSupportTubesService.UpdateSupportTubes(supportTubes);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSupportTubesController", "UpdateSupportTubes", E);
            }
            return Ok("Support Tubes Successfully Updated.");
        }

        [Route("DeleteSupportTubes")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteSupportTubes(MasterDataSupportTubesDto supportTubes)
        {
            try
            {
                MasterDataSupportTubesService.DeleteSupportTubes(supportTubes);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSupportTubesController", "DeleteSupportTubes", E);
            }
            return Ok("Support Tubes Successfully Deleted.");
        }
    }
}
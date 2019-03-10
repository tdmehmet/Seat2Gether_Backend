using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/ChairFoot")]
    public class MasterDataChairFootController : BaseController
    {
        private MasterDataChairFootService ChairFootButtonService = null;

        public MasterDataChairFootController()
        {
            ChairFootButtonService = new MasterDataChairFootService();
        }


        [Route("ChairFootList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ChairFootList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(ChairFootButtonService.ChairFootList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairFootController", "ChairFootList", E);
            }

            return result;
        }

        [Route("addChairFoot")]  // DEFAULT MERKMAL DEĞERİ 15 OLACAK ŞEKİLDE AYARLANACAKTIR.   G.S.
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddChairFootList(MasterDataChairFoot chairFoot)
        {
            try
            {
                ChairFootButtonService.AddChairFoot(chairFoot);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairFootController", "addChairFootList", E);
            }
            
            return Ok("Chair Foot Successfully Created");

        }

        [Route("updateChairFoot")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateChairFoot(MasterDataChairFoot chairFoot)
        {
            try
            {
                ChairFootButtonService.UpdateChairFoot(chairFoot);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairFootController", "updateChairFoot", E);
            }

            return Ok("Chair Foot Successfully Updated");
        }

        [Route("deleteChairFoot")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteChairFoot(MasterDataChairFoot chairFoot)
        {
            try
            {
                ChairFootButtonService.DeleteChairFoot(chairFoot);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataChairFootController", "deleteChairFoot", E);
            }
            
            return Ok("Chair Foot Successfully Deleted");
        }


    }
}
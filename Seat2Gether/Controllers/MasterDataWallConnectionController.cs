using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/WallConnection")]
    public class MasterDataWallConnectionController : BaseController
    {
        private MasterDataWallConnectionService WallConnectionButtonService = null;

        public MasterDataWallConnectionController()
        {
            WallConnectionButtonService = new MasterDataWallConnectionService();
        }

        [Route("WallConnectionList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult WallConnectionList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(WallConnectionButtonService.WallConnectionList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataWallConnectionController", "WallConnectionList", E);
            }

            return result;
        }

        [Route("addWallConnection")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddWallConnection(MasterDataWallConnectionDto wallConnection)
        {
            try
            {
                WallConnectionButtonService.AddWallConnection(wallConnection);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataWallConnectionController", "addWallConnection", E);
            }

            return Ok("Wall Connection Successfully Created");
        }

        

        [Route("deleteWallConnection")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteWallConnection(MasterDataWallConnectionDto wallConnection)
        {
            try
            {
                WallConnectionButtonService.DeleteWallConnection(wallConnection);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataWallConnectionController", "deleteWallConnection", E);
            }

            return Ok("Wall Connection Successfully Deleted");
        }
    }


}
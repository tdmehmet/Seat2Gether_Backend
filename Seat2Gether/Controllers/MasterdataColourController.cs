using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/MasterdataColor")]
    public class MasterdataColorController : BaseController
    {
        private MasterDataColourService MasterDataColourService;

        public MasterdataColorController()
        {
            MasterDataColourService = new MasterDataColourService();
        }

        [Route("findColors")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindColor()
        {
            IHttpActionResult result = null;
            try
            {
               result = Ok(MasterDataColourService.FindColors());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterdataColorController", "FindColor", E);
            }

            return result;
        }

        [Route("findColorById/{Id}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindColorById(Int32 Id)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataColourService.FindColorById(Id));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterdataColorController", "findColorById", E);
            }

            return result;
        }


        [Route("deleteColor")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteColor(MasterDataColour colour)
        {
            try
            {
                MasterDataColourService.DeleteColour(colour);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterdataColorController", "DeleteColor", E);
            }
            
            return Ok("Masterdata Color Successfully Deleted");
        }

        [Route("saveColor")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult SaveColor(MasterDataColour color)
        {
            try
            {
                MasterDataColourService.SaveColour(color);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterdataColorController", "SaveColor", E);
            }
            
            return Ok("Masterdata Color Successfully Saved");
        }

        [Route("updateColor")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateColor(MasterDataColour color)
        {
            try
            {
                MasterDataColourService.UpdateColour(color);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterdataColorController", "updateColor", E);
            }
            
            return Ok("Color Successfully Updated");
        }
    }
}
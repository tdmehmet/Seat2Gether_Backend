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
    [RoutePrefix("api/SeatFrame")]
    public class MasterDataSeatFrameController:BaseController
    {
        private MasterDataSeatFrameService MasterDataSeatFrameService = null;

        public MasterDataSeatFrameController()
        {
            MasterDataSeatFrameService = new MasterDataSeatFrameService();
        }

        [Route("SeatFrameList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult SeatFrameList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataSeatFrameService.SeatFrameList());
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatFrameController", "SeatFrameList", E);
            }
            return result;
        }

        [Route("AddSeatFrame")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddSeatFrame(MasterDataSeatFrameDto seatFrame)
        {
            
            try
            {
              MasterDataSeatFrameService.AddSeatFrame(seatFrame);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatFrameController", "AddSeatFrame", E);
            }
            return Ok("Seat Frame Successfully Created.");
        }

        [Route("UpdateSeatFrame")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateSeatFrame(MasterDataSeatFrameDto seatFrame)
        {

            try
            {
                MasterDataSeatFrameService.UpdateSeatFrame(seatFrame);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatFrameController", "UpdateSeatFrame", E);
            }
            return Ok("Seat Frame Successfully Updated.");
        }

        [Route("DeleteSeatFrame")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteSeatFrame(MasterDataSeatFrameDto seatFrame)
        {

            try
            {
                MasterDataSeatFrameService.DeleteSeatFrame(seatFrame);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatFrameController", "DeleteSeatFrame", E);
            }
            return Ok("Seat Frame Successfully Deleted.");
        }



        [Route("SeatFramePartList/{bbNumber}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult SeatFramePartList(string bbNumber)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MasterDataSeatFrameService.SeatFramePartList(bbNumber));
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataSeatFrameController", "SeatFramePartList", E);
            }
            return result;
        }



    }
}
using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using Seat2Gether.services.ExternalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/Seat")]
    public class SeatController : ApiController
    {
        private SeatService seatService;
        public SeatController()
        {
            seatService = new SeatService();
        }

        [HttpPost]
        [Route("UpdateSeat")]
        [Authorize]
        public IHttpActionResult UpdateSeat(ExSeatPlacementDto seat)
        {
            try
            {
                seatService.Update(seat);
                return Ok(seat);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "SeatController", "UpdateSeat", E);
            }
        }

        [HttpPost]
        [Route("GetSeatList")]
        [Authorize]
        public IHttpActionResult GetSeatList()
        {
            try
            {
                var seatList = seatService.GetList();
                return Ok(seatList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "SeatController", "GetSeatList", E);
            }
        }

        [HttpPost]
        [Route("AddSeat")]
        [Authorize]
        public IHttpActionResult AddSeat(ExSeatPlacementDto seat)
        {
            try
            {
                seatService.Add(seat);
                return Ok(seat);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "SeatController", "AddSeat", E);
            }
        }

        [HttpPost]
        [Route("DeleteSeat")]
        [Authorize]
        public IHttpActionResult DeleteSeat(ExSeatPlacementDto seat)
        {
            try
            {
                seatService.Delete(seat);
                return Ok(seat.Id);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "SeatController", "DeleteSeat", E);
            }
        }
    }
}

using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using Seat2Gether.services.ExternalServices;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/Station")]
    public class StationController : ApiController
    {
        StationService stationService;
        public StationController()
        {
            stationService = new StationService();
        }

        [HttpPost]
        [Route("UpdateStation")]
        [Authorize]
        public IHttpActionResult UpdateStation(ExStationDto model)
        {
            try
            {
                stationService.Update(model);
                return Ok(model);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "StationController", "UpdateStation", E);
            }
        }

        [HttpPost]
        [Route("GetStationList")]
        [Authorize]
        public IHttpActionResult GetStationList()
        {
            try
            {
                var stationList = stationService.GetNamedList();
                return Ok(stationList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "StationController", "GetStationList", E);
            }
        }

        [HttpPost]
        [Route("AddStation")]
        [Authorize]
        public IHttpActionResult AddStation(ExStationDto station)
        {
            try
            {
                stationService.Add(station);
                return Ok(station);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "StationController", "AddStation", E);
            }
        }

        [HttpPost]
        [Route("DeleteStation")]
        [Authorize]
        public IHttpActionResult DeleteStation(ExStationDto station)
        {
            try
            {
                stationService.Delete(station);
                return Ok(station.StationNumber);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "StationController", "DeleteStation", E);
            }
        }
    }
}

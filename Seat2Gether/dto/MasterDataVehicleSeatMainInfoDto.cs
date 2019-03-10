using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataVehicleSeatMainInfoDto
    {
        public decimal ID { get; set; }
        public string ImageURL { get; set; }
        public decimal SeatType { get; set; }
        public decimal Passenger { get; set; }
        public decimal DriverSeatCount { get; set; }
        public string SeatHolder { get; set; }
        public decimal Hostess { get; set; }
        public string Hostes { get; set; }
        public string VehicleBBNumber { get; set; }
        public decimal VehicleId { get; set; }

    }
}
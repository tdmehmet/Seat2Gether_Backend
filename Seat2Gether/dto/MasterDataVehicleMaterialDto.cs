using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataVehicleMaterialDto
    {
        public decimal ID { get; set; }
        public decimal SubGroup { get; set; }
        public string VehicleBBNumber { get; set; }
        public string MaterialNumber { get; set; }
        public decimal Amount { get; set; }
        public string BMType { get; set; }
        public decimal OrderNumber { get; set; }
        public decimal VehicleId { get; set; }
    }
}
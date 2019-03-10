using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataVehicleDto
    {
        public decimal ID { get; set; }
        public string BBNumber { get; set; }
        public decimal TypeId { get; set; }
        public string Country { get; set; }
        public decimal ModelId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataVehicleSeatFabricDto
    {
        public decimal ID { get; set; }
        public string SittingArea { get; set; }
        public string SideArea { get; set; }
        public string BellowsArea { get; set; }
        public string BeltArea { get; set; }
        public string BackArea { get; set; }
        public string Rib { get; set; }
        public string HeaderStatic { get; set; }
        public string HeaderDynamic { get; set; }
        public decimal HeaderFastenerType { get; set; }
        public string VehicleBBNumber { get; set; }
        public decimal VehicleId { get; set; }
    }
}
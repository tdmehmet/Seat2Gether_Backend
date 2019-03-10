using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExMasterDataSeatFabricTypeDto
    {
        public string SeatFabricNo { get; set; }
        public string Definition { get; set; }
        public string Title => SeatFabricNo +" - "+ Definition;
     }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExSeatPlacementDto
    {
        public int Id { get; set; }

        public string BBNumber { get; set; }

       
        public string MaterialNumber { get; set; }

       
        public string SeatCode { get; set; }

       
        public string SeatTypeCode { get; set; }

        public int Quantity { get; set; }
    }
}
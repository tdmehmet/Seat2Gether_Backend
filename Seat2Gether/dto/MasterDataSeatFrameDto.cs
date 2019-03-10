using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataSeatFrameDto
    {
        public string EbNumber { get; set; }
        public string Designation { get; set; }
        public string TnrSupportTube { get; set; }
        public int Amount { get; set; }
        public int Template { get; set; }
        public double SeatPitch { get; set; }
        public string Page { get; set; }
        public string ColorInfo { get; set; }
        public bool Adapter { get; set; }
    }
}
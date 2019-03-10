using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataSupportTubesDto
    {
        public string PartNumber { get; set; }
        public double Length { get; set; }
        public Int32 Characteristic { get; set; }
        public bool Reinforced { get; set; }
    }
}
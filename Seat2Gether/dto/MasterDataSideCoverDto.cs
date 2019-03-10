using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataSideCoverDto
    {
        public string PartNumber { get; set; }
        public string Designations { get; set; }
        public bool BeltAisleSide { get; set; }
        public bool ArmRest { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataMaterialMasterDto
    {
        public int lfdnrMaterial { get; set; }
        public string PartNumber { get; set; }
        public string Designation { get; set; }
        public string Position { get; set; }
        public int lfdnrCharacteristic { get; set; }
        public double StandardTimeInMinute { get; set; }
        public double VZKO { get; set; }
        public double VZBW { get; set; }
        public double VZEL { get; set; }
        public double VZAZ { get; set; }
        public double VZVS { get; set; }
        public double VZMO { get; set; }
        public double VZAL { get; set; }
        public double VZGF { get; set; }
        public bool Standart { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string AlteredFrom { get; set; }
        public DateTime ChangedOn { get; set; }
        public bool BulkGood { get; set; }
        public int NumberAdditionalShare { get; set; }
        public string Background { get; set; }
        public string Foreground { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Picture { get; set; }
        public string AcquisitionVariation { get; set; }
        public string PartNumberWithout { get; set; }
    }
}
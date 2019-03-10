using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataMaterialDto
    {

        public decimal ID { get; set; }
        public string CharacteristicName { get; set; }
        public decimal CharacteristicValue { get; set; }
        public string MaterialNumber { get; set; }
        public string MBMaterialNumber { get; set; }
        public string ShortDescription { get; set; }
        public string Unit { get; set; }
        public string PNSK2 { get; set; }
        public string ClassType { get; set; }
        public string Class { get; set; }
        public decimal ProductionArea { get; set; }
        public string ChangeText { get; set; }
        public string Comment { get; set; }
    }
}
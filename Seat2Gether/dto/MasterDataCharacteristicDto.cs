using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataCharacteristicDto
    {

        public int LfdnrCharacteristic { get; set; }
        public string CharacteristicValue { get; set; }
        public string Area { get; set; } //Combobox Show
        public Int64 Sort { get; set; }
    }
}

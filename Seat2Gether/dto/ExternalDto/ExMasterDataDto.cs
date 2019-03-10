using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExMasterDataDto
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Tr { get; set; }

        public string En { get; set; }
       
        public string De { get; set; }

        public int? MasterDataTypeId { get; set; }
    }
}
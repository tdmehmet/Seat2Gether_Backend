namespace Seat2Gether.Models.ExternalModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExMasterData
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(500)]
        public string Tr { get; set; }

        [StringLength(500)]
        public string En { get; set; }

        [StringLength(500)]
        public string De { get; set; }

        public int? MasterDataTypeId { get; set; }

        public virtual ExMasterDataType ExMasterDataType { get; set; }
    }
}

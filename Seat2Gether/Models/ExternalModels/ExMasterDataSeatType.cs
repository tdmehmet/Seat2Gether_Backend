namespace Seat2Gether.Models.ExternalModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExMasterDataSeatType
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Tr { get; set; }

        [StringLength(50)]
        public string De { get; set; }

        [StringLength(50)]
        public string En { get; set; }
    }
}

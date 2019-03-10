using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.A_Sitzgestellmerkmale")]
    public class MasterDataSeatFrameCharacteristic
    {
        [Display(Name ="Lfdnr Characteristic")]
        [Column("lfdNr_Merkmal")]
        [Key]
        public int lfdNrCharacteristic { get; set; }

        [Display(Name ="Characteristic")]
        [Column("Merkmal")]
        public string characteristic { get; set; }
    }
}
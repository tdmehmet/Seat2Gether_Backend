using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_Wandanbindung")]
    public class MasterDataWallConnection
    {
        [Display(Name = "PartNumber")]
        [Column("TNR")]
        [Key]
        public string PartNumber { get; set; }

        [Display(Name = "Characteristic")]
        [Column("Merkmal")]
        public int Characteristic { get; set; }

    }
}
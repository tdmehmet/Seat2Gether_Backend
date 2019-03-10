using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_Sitzkassetten")]
    public class MasterDataRearSeatPan
    {
        [Display(Name = "PartNumber")]
        [Column("TNR")]
        [Key]
        public string PartNumber { get; set; }


        [Display(Name = "Narrow")]
        [Column("schmal")]
        public int Narrow { get; set; }


        [Display(Name = "Characteristic")]
        [Column("Merkmal")]
        public int Characteristic { get; set; }

        [Display(Name = "Remark")]
        [Column("Bemerkung")]
        public string Remark { get; set; }
    }
}
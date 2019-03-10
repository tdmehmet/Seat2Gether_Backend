using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.T_ST_Stuhlfuss")]
    public class MasterDataChairFoot
    {
        [Display(Name = "TNR")]
        [Column("TNR", Order = 0)]
        [Key]
        public string PartNumber { get; set; }


        [Display(Name = "Characteristic")]
        [Column("Merkmal")]
        public int Characteristic { get; set; }
    }
}
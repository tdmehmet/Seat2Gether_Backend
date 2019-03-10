using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_Bemerkungen_Vorgabe")]
    public class MasterDataRemark
    {
        [Display(Name = "Remark")]
        [Column("Bemerkung")]
        [Key]
        public string Remarkk { get; set; }

    }
}

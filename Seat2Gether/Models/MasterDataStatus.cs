using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_Status")]
    public class MasterDataStatus
    {
        [Display(Name = "LfdnrStatus")]
        [Column("lfdNr_Status")]
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LfdnrStatus { get; set; }


        [Display(Name = "Status")]
        [Column("Status")]
        public string StatusValue { get; set; }



    }
}
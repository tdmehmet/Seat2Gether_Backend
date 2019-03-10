using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_Angaben")]
    public class MasterDataAdditionalDisclosure
    {
        [Display(Name = "Lfdnr Specification")]
        [Column("lfdNr_Angabe")]
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LfdnrSpecification { get; set; }


        [Display(Name = "Specification")]
        [Column("Angabe")]
        public string Specification { get; set; }

        [Display(Name = "Standard Time")]
        [Column("Vorgabezeit")]
        public double StandardTime { get; set; }



    }
}
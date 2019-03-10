using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_Sesselblenden")]
    public class MasterDataSideCover
    {
        [Display(Name = "PartNumber")]
        [Column("TNR")]
        [Key]
        public string PartNumber { get; set; }


        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designations { get; set; }


        [Display(Name = "Belt Aisle Side")]
        [Column("Gurt_Gangseitig")]
        public bool BeltAisleSide { get; set; }

        [Display(Name = "ArmRest")]
        [Column("Armlehne")]
        public bool ArmRest { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_Tragrohre")]
    public class MasterDataSupportTubes
    {
        [Display(Name = "PartNumber")]
        [Column("TNR")]
        [Key]
        public string PartNumber { get; set; }
        
        [Display(Name = "Length")]
        [Column("Länge")]
        public double Length { get; set; }
        
        [Display(Name = "Characteristic")]
        [Column("Merkmal")]
        public Int32 Characteristic { get; set; }

        [Display(Name = "Reinforced")]
        [Column("Verstärkt")]
        public bool Reinforced { get; set; }
    }
}
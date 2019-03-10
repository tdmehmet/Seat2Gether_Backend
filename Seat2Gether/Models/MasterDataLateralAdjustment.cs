using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_EB_Seitenverstellung")]
    public class MasterDataLateralAdjustment
    {
        [Display(Name = "EB")]
        [Column("EB")]
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EB { get; set; }


        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }

        [Display(Name = "LateralAdjustment Lİ")]
        [Column("Seitenverstellung_li")]
        public bool LateralAdjustmentLI { get; set; }

        [Display(Name = "LateralAdjustment RE")]
        [Column("Seitenverstellung_re")]
        public bool LateralAdjustmentRE { get; set; }

        [Display(Name = "Gauge")]
        [Column("Schablone")]
        public string Gauge { get; set; }
    }
}
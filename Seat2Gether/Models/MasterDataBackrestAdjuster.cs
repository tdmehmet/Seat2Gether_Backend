using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("T_ST_EB_Verstellung")]
    public class MasterDataBackrestAdjuster
    {
        [Display(Name = "EB")]
        [Column("EB")]
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EB { get; set; }


        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }

        [Display(Name = "Number Of Pneumatic Spring")]
        [Column("Anzahl_Gasfeder")]
        public int NumberOfPneumaticSpring { get; set; }

        [Display(Name = "Pretense-Li")]
        [Column("Verstellung_li")]
        public int PretenseLi { get; set; }

        [Display(Name = "Pretense-Re")]
        [Column("Verstellung_re")]
        public int PretenseRe { get; set; }

    }
}
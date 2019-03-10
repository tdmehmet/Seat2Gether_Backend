using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.T_ST_EB_Sitzgestell_Stückliste")]
    public class MasterDataSeatFramePartList
    {
        [Display(Name = "EB Number")]
        [Column("EB", Order = 1)]
        [Key]
        public string EbNumber { get; set; }

        [Display(Name = "Characteristic")]
        [Column("Merkmal", Order = 2)]
        [Key]
        public int Characteristic { get; set; }

        [Display(Name = "TNR Li")]
        [Column("TNR_li")]
        public string TNRli { get; set; }

        [Display(Name = "TNR Re")]
        [Column("TNR_re")]
        public string TNRre { get; set; }

        [Display(Name = "amount")]
        [Column("Menge")]
        public int Amount { get; set; }
    }
}
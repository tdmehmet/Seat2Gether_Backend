using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_Merkmal")]
    public class MasterDataCharacteristic
    {
        [Display(Name = "LfdnrCharacteristic")]
        [Column("lfdNr_Merkmal")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LfdnrCharacteristic { get; set; }

        [Display(Name = "Merkmal")]
        [Column("Merkmal")]
        public string CharacteristicValue { get; set; }


        [Display(Name = "Area")]
        [Column("Bereich")]
        public int Area { get; set; }


        [Display(Name = "Sort")]
        [Column("Sort")]
        public Int64 Sort { get; set; }
    }
}
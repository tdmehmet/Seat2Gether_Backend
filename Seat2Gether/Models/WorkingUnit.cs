using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.Tb_WorkingUnit")]
    public class WorkingUnit
    {

        [Display(Name = "ID")]
        [Column("ID")]
        [Key]
        public Int32 ID { get; set; }

        [Display(Name = "Tr")]
        [Column("Tr")]
        public string Tr { get; set; }


        [Display(Name = "De")]
        [Column("De")]
        public string De { get; set; }


        [Display(Name = "En")]
        [Column("En")]
        public string En { get; set; }

    }
}
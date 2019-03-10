using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.A_ST_Variante_Fahrerstuhl")]
    public class VariantDriverChair
    {

        [Display(Name = "AuftragsNr")]
        [Column("AuftragsNr")]
        [Required]
        [Key]
        public string OrderID { get; set; }

        [Display(Name = "Bezeichnung")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }

        [Display(Name = "angelegt_am")]
        [Column("angelegt_am")]
        public Nullable<DateTime> Created_On { get; set; }

        [Display(Name = "angelegt_von")]
        [Column("angelegt_von")]
        public string Created_By { get; set; }

        [Display(Name = "Hersteller")]
        [Column("Hersteller")]
        public string Manufacturer { get; set; }

        [Display(Name = "Bemerkungen")]
        [Column("Bemerkungen")]
        public string Remarks { get; set; }

        [Display(Name = "Bezug")]
        [Column("Bezug")]
        public string Reference { get; set; }

        [Display(Name = "Ausführung")]
        [Column("Ausführung")]
        public string Execution { get; set; }

        [Display(Name = "Keder")]
        [Column("Keder")]
        public string Edge_Reinforcement { get; set; }

        [Display(Name = "Kopfteil")]
        [Column("Kopfteil")]
        public string Headboard { get; set; }

        [Display(Name = "TNR")]
        [Column("TNR")]
        public string PartNumber { get; set; }
    }
}

    
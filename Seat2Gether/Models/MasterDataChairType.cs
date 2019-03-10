using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_Stuhltyp")]
    public class MasterDataChairType
    {
        [Display(Name = "Lfdnr ChairType")]
        [Column("lfdNr_Stuhltyp")]
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LfdnrChairType { get; set; }


        [Display(Name = "Chair Type")]
        [Column("Stuhltyp")]
        public string Chairtype { get; set; }

        [Display(Name = "Classification")]
        [Column("Klassifizierung")]
        public string Classification { get; set; }

        [Display(Name = "Setup Time")]
        [Column("Rüstzeit")]
        public Nullable<double> SetupTime { get; set; }

        [Display(Name = "Active")]
        [Column("aktiv")]
        public Nullable<bool> Active { get; set; }

        [Display(Name = "Janz List")]
        [Column("Janzliste")]
        public Nullable<bool> JanzList { get; set; }

        [Display(Name = "Outside Company")]
        [Column("Fremdfirma")]
        public string OutsideCompany { get; set; }

        [Display(Name = "Feedback")]
        [Column("Rückmeldung")]
        public string Feedback { get; set; }

        [Display(Name = "Chair Type")]
        [Column("Vorgabezeit_Bezug_wenden")]
        public double ReferenceTime { get; set; }

        [Display(Name = "Chair Type")]
        [Column("Vorgabezeit_Bezug_schlitzen")]
        public double PresetTimeReferenceSlot { get; set; }

        [Display(Name = "Group")]
        [Column("Gruppe")]
        public string Group { get; set; }

        [Display(Name = "Upholstery Line")]
        [Column("Polsterlinie")]
        public Nullable<bool> UpholsteryLine { get; set; }

        [Display(Name = "TB Seat Frame")]
        [Column("TB_Sitzgestell")]
        public string TBSeatFrame { get; set; }

        [Display(Name = "Colloquial")]
        [Column("UGS")]
        public Nullable<bool> Colloquial { get; set; }

        [Display(Name = "Chair Type")]
        [Column("Faktor_für_Anzahlberechnung")]
        public double FactorForNumberCalculation { get; set; }

    }

}
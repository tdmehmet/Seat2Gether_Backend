using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("dbo.A_BBNR")]
    public class BBNR
    {
        [Display(Name = "BBNR")]
        [Column("BBNr", Order = 0)]
        [Key]
        public string BBNRID { get; set; }

        [Display(Name = "AuftragsNr")]
        [Column("AuftragsNr", Order =1)]
        public string OrderID { get; set; }

        [Display(Name = "Anzahl_links")]
        [Column("Anzahl_links")]
        public int NumberOfLeft { get; set; }

        [Display(Name = "Anzahl_rechts")]
        [Column("Anzahl_rechts")]
        public int NumberOfRight { get; set; }

        [Display(Name = "Anzahl_Fond")]
        [Column("Anzahl_Fond")]
        public int NumberOfBack { get; set; }

        [Display(Name = "Anzahl_Clubecke")]
        [Column("Anzahl_Clubecke")]
        public int Count_ClubEdge { get; set; }

        [Display(Name = "Stuhltyp")]
        [Column("Stuhltyp")]
        public string ArmChairType { get; set; }

        [Display(Name = "Soll_Termin")]
        [Column("Soll_Termin")]
        public DateTime ToBe_Date { get; set; }

        [Display(Name = "Reihenfolge")]
        [Column("Reihenfolge")]
        public double  Ranking { get; set; }

        [Display(Name = "Ist_Termin")]
        [Column("Ist_Termin")]
        public Nullable<DateTime> AsIs_Date { get; set; }

        [Display(Name = "angelegt_am")]
        [Column("angelegt_am")]
        public DateTime Created_On { get; set; }

        [Display(Name = "angelegt_von")]
        [Column("angelegt_von")]
        public string Created_By { get; set; }

        [Display(Name = "lfdNr_Status")]
        [Column("lfdNr_Status")]
        public int LfdnrStatus { get; set; }

        [Display(Name = "Status_gesetzt_am")]
        [Column("Status_gesetzt_am")]
        public DateTime Status_Set_On { get; set; }

        [Display(Name = "BBNr_Farbe_Bezug")]
        [Column("BBNr_Farbe_Bezug")]
        public int BBNRColorReference { get; set; }

        [Display(Name = "BBNr_Farbe_Lederkopfteil")]
        [Column("BBNr_Farbe_Lederkopfteil")]
        public int Vehicle_Color_LeatherHeadPart { get; set; }

        [Display(Name = "Länderkennzeichen")]
        [Column("Länderkennzeichen")]
        public string CountryCode { get; set; }

        [Display(Name = "Kunde")]
        [Column("Kunde")]
        public string Customer { get; set; }

        [Display(Name = "intern")]
        [Column("intern")]
        public bool Internally { get; set; }

        [Display(Name = "Anzahl_UD_links")]
        [Column("Anzahl_UD_links")]
        public int Count_UD_Left { get; set; }

        [Display(Name = "Anzahl_UD_rechts")]
        [Column("Anzahl_UD_rechts")]
        public int Count_UD_Right { get; set; }

        [Display(Name = "Werk")]
        [Column("Werk")]
        public string Plant { get; set; }

        [Display(Name = "Sitzeinteilung")]
        [Column("Sitzeinteilung")]
        public string SeatingArrangement { get; set; }

        [Display(Name = "Belegung")]
        [Column("Belegung")]
        public int Assignment { get; set; }

        [Display(Name = "Ansprechpartner_Vertrieb")]
        [Column("Ansprechpartner_Vertrieb")]
        public string ContactSales { get; set; }

        [Display(Name = "Ansprechpartner_AZ")]
        [Column("Ansprechpartner_AZ")]
        public string ContactAZ { get; set; }

        [Display(Name = "EU_Richtilinie")]
        [Column("EU_Richtilinie")]
        public string EUGuidelines { get; set; }

        [Display(Name = "Abnahme")]
        [Column("Abnahme")]
        public string Decrease { get; set; }

        [Display(Name = "Baumuster")]
        [Column("Baumuster")]
        public string Model { get; set; }

        [Display(Name = "Maktx")]
        [Column("Maktx")]
        public string Maktx { get; set; }

        [Display(Name = "FZG_Per_RequestNumber")]
        [Column("FZG_pro_AuftragsNr")]
        public int? FZG_Per_RequestNumber { get; set; }

       // public String FZG_Per_RequestNumber { get; set; }

        [Display(Name = "BBNr_Min")]
        [Column("BBNr_Min")]
        public string BBNRMin { get; set; }

        [Display(Name = "BBNr_Max")]
        [Column("BBNr_Max")]
        public string BBNRMax { get; set; }

        [Display(Name = "Steuern_nach")]
        [Column("Steuern_nach")]
        public string Control_Via { get; set; }
        
        [Display(Name = "Jahr")]
        [Column("Jahr")]
        public int Year { get; set; }

        [Display(Name = "Anzahl_Lose")]
        [Column("Anzahl_Lose")]
        public string NumberOfLots { get; set; }

        [Display(Name = "Typ")]
        [Column("Typ")]
        public string BBNRType { get; set; }

        [Display(Name = "Standort")]
        [Column("Standort")]
        public string Location { get; set; }

    }
}
      
  
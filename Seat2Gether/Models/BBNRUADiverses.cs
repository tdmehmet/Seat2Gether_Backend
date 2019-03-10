using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    public class BBNRUADiverses
    {
        public string AUftragsNr { get; set; }
        public string OrderID
        {
            get
            {
                return AUftragsNr;
            }
            set
            {
                OrderID = AUftragsNr;
            }
        }

        public string Seitenwand { get; set; }
        public string SideWall
        {
            get
            {
                return Seitenwand;
            }
            set
            {
                SideWall = Seitenwand;
            }
        }

        public string Vorhang { get; set; }
        public string Curtain
        {
            get
            {
                return Vorhang;
            }
            set
            {

                Curtain = Vorhang;

            }
        }

        public string Gepäckablage { get; set; }
        public string LuggageRack
        {
            get
            {
                return Gepäckablage;
            }
            set
            {
                LuggageRack = Gepäckablage;
            }
        }

        public string Innendecke { get; set; }
        public string InteriorCeiling
        {
            get
            {
                return Innendecke;
            }
            set
            {
                InteriorCeiling = Innendecke;
            }
        }

        public string Dekorstreifen { get; set; }
        public string DecorativeStrips
        {
            get
            {
                return Dekorstreifen;
            }
            set
            {
                DecorativeStrips = Dekorstreifen;
            }
        }
    }
}

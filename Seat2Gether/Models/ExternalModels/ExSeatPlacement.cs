using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models.ExternalModels
{
    public class ExSeatPlacement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string BBNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string MaterialNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string SeatCode { get; set; }

        [Required]
        [StringLength(50)]
        public string SeatTypeCode { get; set; }

        public int Quantity { get; set; }
    }
}
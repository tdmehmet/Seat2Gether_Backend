using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models.ExternalModels
{
   public class ExMasterDataSeatFabricType
   {
      [Key]
      [StringLength(50)]
      public string SeatFabricNo { get; set; }
      [StringLength(500)]
      public string Definition { get; set; }
   }
}
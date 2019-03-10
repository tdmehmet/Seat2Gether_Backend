using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.Tb_OrderStatus")]
    public class OrderStatus
    {
        [Display(Name = "Id")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Display(Name = "OrderNumber")]
        [Column("OrderNumber")]
        public string OrderNumber { get; set; }

        [Display(Name = "StatusID")]
        [Column("StatusID")]
        public Nullable<Int32> StatusID { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{

    [Table("dbo.Tb_MasterDataVehicleType")]
    public class MasterDataVehicleType
    {
        [Display(Name = "Id")]
        [Column("Id", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Display(Name = "TR")]
        [Column("TR")]
        public string TR { get; set; }

        [Display(Name = "DE")]
        [Column("DE")]
        public string DE{ get; set; }

        [Display(Name = "EN")]
        [Column("EN")]
        public string EN { get; set; }

    }
}
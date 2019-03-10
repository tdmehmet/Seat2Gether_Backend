namespace Seat2Gether.Models.ExternalModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ExTb_VehicleMaterial")]
    public partial class ExVehicleMaterial
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string VehicleBBNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string StationNumber { get; set; }

        [StringLength(250)]
        public string MaterialName { get; set; }

        [StringLength(100)]
        public string MaterialNumber { get; set; }

        public double Quantity { get; set; }

        [StringLength(100)]
        public string Unit { get; set; }
        public string SubGroupId { get; set; }

        public virtual ExStation ExStation { get; set; }

        public virtual ExVehicle ExVehicle { get; set; }
        public virtual ExMaterialWarehouse ExMaterialWarehouse { get;  set; }
    }
}

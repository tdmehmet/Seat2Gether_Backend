namespace Seat2Gether.Models.ExternalModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ExTb_Vehicle")]
    public partial class ExVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExVehicle()
        {
            ExVehicleMaterial = new HashSet<ExVehicleMaterial>();
        }

        [Key]
        [StringLength(100)]
        public string BBNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TypeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CountryId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ModelId { get; set; }

        [StringLength(128)]
        public string InsertUser { get; set; }

        [StringLength(128)]
        public string UpdateUser { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BandRecivingDate { get; set; }

        [StringLength(8)]
        public string KwInfo { get; set; }

        [StringLength(50)]
        public string SeatsConditioningPicture { get; set; }

        public int? SeatType { get; set; }

        [StringLength(50)]
        public string BackRowSeatPicture { get; set; }

        public int? BackRowSeatCount { get; set; }

        public int? HostessSeatCount { get; set; }

        public int? SeatCount { get; set; }

        [StringLength(50)]
        public string PassengerSitting { get; set; }

        [StringLength(50)]
        public string PassengerLateral { get; set; }

        [StringLength(50)]
        public string PassengerBellows { get; set; }

        [StringLength(50)]
        public string PassengerBrush { get; set; }

        [StringLength(50)]
        public string PassengerOutBack { get; set; }

        [StringLength(50)]
        public string PassengerHead { get; set; }

        [StringLength(50)]
        public string PassengerWick { get; set; }

        public int? PortableHeadFastener { get; set; }

        public int? PortableHeadPortableFixed { get; set; }

        [StringLength(50)]
        public string PortableHeadPortableFixedFabric { get; set; }

        [StringLength(50)]
        public string CurtainFirstFabric { get; set; }

        [StringLength(50)]
        public string CurtainSecondFabric { get; set; }

        public int? DoorType { get; set; }

        [StringLength(50)]
        public string DriverSleepingQuarter { get; set; }

        [StringLength(50)]
        public string DriverSitting { get; set; }

        [StringLength(50)]
        public string DriverLateral { get; set; }

        [StringLength(50)]
        public string DriverFace { get; set; }

        [StringLength(50)]
        public string DriverOutBack { get; set; }

        [StringLength(50)]
        public string DriverHead { get; set; }

        public int? DriverArmrest { get; set; }

        public int? DriverHeating { get; set; }

        public int? DriverVibration { get; set; }

        public int? DriverMercedesStar { get; set; }

        [StringLength(50)]
        public string HostessHead { get; set; }

        public int? HostessElectrical { get; set; }

        public int? HostessLock { get; set; }

        public int? NetType { get; set; }

        [StringLength(50)]
        public string NetFabricCode { get; set; }
        [StringLength(50)]
        public string DriverBackCurtainFabric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExVehicleMaterial> ExVehicleMaterial { get; set; }
    }
}

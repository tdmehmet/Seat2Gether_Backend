using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExVehicleDto
    {
        [Required]
        public string BBNumber { get; set; }
        public decimal? TypeId { get; set; }
        public decimal? CountryId { get; set; }
        public decimal? ModelId { get; set; }
        public string State { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? BandRecivingDate { get; set; }
        public string KwInfo { get; set; }
        public string SeatsConditioningPicture { get; set; }
        public int? SeatType { get; set; }
        public string BackRowSeatPicture { get; set; }
        public int? BackRowSeatCount { get; set; }
        public int? HostessSeatCount { get; set; }
        public int? SeatCount { get; set; }
        public string PassengerSitting { get; set; }
        public string PassengerLateral { get; set; }
        public string PassengerBellows { get; set; }
        public string PassengerBrush { get; set; }
        public string PassengerOutBack { get; set; }
        public string PassengerHead { get; set; }
        public string PassengerWick { get; set; }
        public int? PortableHeadFastener { get; set; }
        public int? PortableHeadPortableFixed { get; set; }
        public string PortableHeadPortableFixedFabric { get; set; }
        public string CurtainFirstFabric { get; set; }
        public string CurtainSecondFabric { get; set; }
        public int? DoorType { get; set; }
        public string DriverSleepingQuarter { get; set; }
        public string DriverSitting { get; set; }
        public string DriverLateral { get; set; }
        public string DriverFace { get; set; }
        public string DriverOutBack { get; set; }
        public string DriverHead { get; set; }
        public int? DriverArmrest { get; set; }
        public int? DriverHeating { get; set; }
        public int? DriverVibration { get; set; }
        public int? DriverMercedesStar { get; set; }
        public string HostessHead { get; set; }
        public int? HostessElectrical { get; set; }
        public int? HostessLock { get; set; }
        public int? NetType { get; set; }
        public string NetFabricCode { get; set; }
        public string DriverBackCurtainFabric { get; set; }
    }
}
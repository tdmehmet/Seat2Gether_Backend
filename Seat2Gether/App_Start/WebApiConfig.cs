using Seat2Gether.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Data.Entity;
using System;
using Seat2Gether.dto;
using Seat2Gether.Models.ExternalModels;

namespace Seat2Gether
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes 
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "WithActionApi",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
        }
    }

    public class Seat2GetherDBContext : IdentityDbContext<IdentityUser>
    {


        public Seat2GetherDBContext() : base("Seat2GetherDBContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<GeneralParam> GeneralParams { get; set; }
        public DbSet<BBNR> BBNr { get; set; }
        public DbSet<BBNRKSW> BBNrKSW { get; set; }
        public DbSet<BBNRRemarksCut> BBNRRemarksCut { get; set; }
        public DbSet<VariantDriverChair> VariantDriverChair { get; set; }
        public DbSet<MasterDataCharacteristic> Characteristic { get; set; }
        public DbSet<MasterDataColour> MasterDataColour { get; set; }
        public DbSet<MasterDataStatus> Status { get; set; }
        public DbSet<MasterDataAdditionalDisclosure> AdditionalDisclosure { get; set; }
        public DbSet<MasterDataMaterialMaster> MaterialMaster { get; set; }
        public DbSet<MasterDataChairType> ChairType { get; set; }
        public DbSet<MasterDataEBBelt> EBBelt { get; set; }
        public DbSet<MasterDataLateralAdjustment> LateralAdjustment { get; set; }
        public DbSet<MasterDataBackrestAdjuster> BackrestAdjuster { get; set; }
        public DbSet<MasterDataChairFoot> ChairFoot { get; set; }
        public DbSet<MasterDataAdjustingLever> AdjustingLever { get; set; }
        public DbSet<MasterDataSTMaterialMaster> STMaterialMaster { get; set; }
        public DbSet<MasterDataRearSeatPan> RearSeatPan { get; set; }
        public DbSet<MasterDataRemark> Remark { get; set; }
        public DbSet<MasterDataWallConnection> WallConnection { get; set; }
        public DbSet<MasterDataSideCover> SideCover { get; set; }
        public DbSet<MasterDataSTCharacteristic> STCharacteristic { get; set; }
        public DbSet<Error> Error { get; set; }
        public DbSet<MasterDataMaterial> Material { get; set; }
        public DbSet<MasterDataVehicleSeatFabric> VehicleSeatFabric { get; set; }
        public DbSet<MasterDataVehicleMaterial> VehicleMaterial { get; set; }
        public DbSet<MasterDataVehicleSeatMainInfo> VehicleSeatMainInfo { get; set; }
        public DbSet<MasterDataVehicleModel> VehicleModel { get; set; }
        public DbSet<MasterDataVehicleSeatType> VehicleSeatType { get; set; }
        public DbSet<MasterDataVehicleType> MasterDataVehicleType { get; set; }
        public DbSet<MasterDataVehicleSeatHeaderFastenerType> VehicleSeatHeaderFastenerType { get; set; }
        public DbSet<MasterDataVehicleWcType> VehicleWcType { get; set; }
        public DbSet<MasterDataVehicleWcPillowType> VehicleWcPillowType { get; set; }
        public DbSet<MasterDataVehicleHolderAssemblyType> VehicleHolderAssemblyType { get; set; }
        public DbSet<MasterDataVehiclePillow> VehiclePillow { get; set; }
        public DbSet<MasterDataVehicleBackRowPillow> VehicleBackRowPillow { get; set; }
        public DbSet<MasterDataVehicleHandHolderDecorate> VehicleHandHolderDecorate { get; set; }
        public DbSet<ReportOrder> ReportOrder { get; set; }
        public DbSet<WorkingUnit> WorkingUnit { get; set; }
        public DbSet<ReportComment> ReportComment { get; set; }
        public DbSet<OrderStatusInfo> OrderStatusID { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<VehicleMasterData> VehicleMasterData { get; set; }
        public DbSet<ReportLog> ReportLog { get; set; }
        public DbSet<MasterDataSupportTubes> SupportTubes { get; set; }
        public DbSet<MasterDataSeatFrame> SeatFrame { get; set; }
        public DbSet<MasterDataSeatFramePartList> SeatFramePartList { get; set; }
        public DbSet<MasterDataSeatFrameCharacteristic> SeatFrameCharacteristic { get; set; }
        public DbSet<OrderWorkingUnitReportComment> OrderWorkingUnitComment{ get; set; }
        public DbSet<MasterDataVehicle> MasterDataVehicle { get; set; }
        public virtual DbSet<ExStation> ExStation { get; set; }
        public virtual DbSet<ExVehicleMaterial> ExVehicleMaterial { get; set; }
        public virtual DbSet<ExVehicle> ExVehicle { get; set; }
        public virtual DbSet<ExMaterialWarehouse> ExMaterialWarehouse { get; set; }
        public virtual DbSet<ExMasterDataSeatFabricType> ExMasterDataSeatFabricType { get; set; }
        public virtual DbSet<ExMasterData> ExMasterData { get; set; }
        public virtual DbSet<ExMasterDataType> ExMasterDataType { get; set; }
        public virtual DbSet<ExSeatPlacement> ExSeatPlacement { get; set; }
        public virtual DbSet<ExMasterDataSeatType> ExMasterDataSeatType { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>().ToTable("Tb_Users");
            modelBuilder.Entity<IdentityUserRole>().ToTable("Tb_UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("Tb_UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("Tb_UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Tb_Roles");
            modelBuilder.Entity<Menu>().ToTable("Tb_Menus");
            modelBuilder.Entity<RoleMenu>().HasKey(rm => new { rm.RoleId, rm.MenuId }).ToTable("Tb_RoleMenus");
            modelBuilder.Entity<Menu>().HasMany(m => m.RoleMenus).WithRequired().HasForeignKey(rm => rm.MenuId);
            modelBuilder.Entity<Role>().HasMany(r => r.RoleMenus).WithRequired().HasForeignKey(rm => rm.RoleId);

            modelBuilder.Entity<ExMasterDataSeatType>().ToTable("ExTb_MasterDataSeatType");
            modelBuilder.Entity<ExMasterDataSeatType>()
               .Property(e => e.Tr)
               .IsUnicode(false);

            modelBuilder.Entity<ExMasterDataSeatType>()
                .Property(e => e.De)
                .IsUnicode(false);

            modelBuilder.Entity<ExMasterDataSeatType>()
                .Property(e => e.En)
                .IsUnicode(false);

            modelBuilder.Entity<ExSeatPlacement>().ToTable("ExTb_SeatPlacement");
            modelBuilder.Entity<ExSeatPlacement>()
               .Property(e => e.BBNumber)
               .IsUnicode(false);

            modelBuilder.Entity<ExSeatPlacement>()
                .Property(e => e.MaterialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ExSeatPlacement>()
                .Property(e => e.SeatCode)
                .IsUnicode(false);

            modelBuilder.Entity<ExSeatPlacement>()
                .Property(e => e.SeatTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ExMasterData>().ToTable("ExTb_MasterData");
            modelBuilder.Entity<ExMasterDataType>().ToTable("ExTb_MasterDataType");

            modelBuilder.Entity<ExMasterData>()
                .Property(e => e.Tr)
                .IsUnicode(false);

            modelBuilder.Entity<ExMasterData>()
                .Property(e => e.En)
                .IsUnicode(false);

            modelBuilder.Entity<ExMasterData>()
                .Property(e => e.De)
                .IsUnicode(false);

            modelBuilder.Entity<ExMasterDataType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ExMasterDataType>()
                .HasMany(e => e.ExTb_MasterData)
                .WithOptional(e => e.ExMasterDataType)
                .HasForeignKey(e => e.MasterDataTypeId);
            modelBuilder.Entity<ExMasterDataSeatFabricType>().ToTable("ExTb_MasterDataSeatFabricType");

            modelBuilder.Entity<ExMasterDataSeatFabricType>()
               .Property(e => e.SeatFabricNo)
               .IsUnicode(false);

            modelBuilder.Entity<ExMasterDataSeatFabricType>()
               .Property(e => e.Definition)
               .IsUnicode(false);

            modelBuilder.Entity<ExStation>().ToTable("ExTb_Station");

            modelBuilder.Entity<ExStation>()
                .Property(e => e.StationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ExStation>()
                .Property(e => e.StationName)
                .IsUnicode(false);

            modelBuilder.Entity<ExStation>()
                .HasMany(e => e.ExVehicleMaterial)
                .WithRequired(e => e.ExStation)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ExVehicleMaterial>().ToTable("ExTb_VehicleMaterial");

            modelBuilder.Entity<ExVehicleMaterial>()
                .Property(e => e.VehicleBBNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicleMaterial>()
                .Property(e => e.StationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicleMaterial>()
                .Property(e => e.MaterialName)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicleMaterial>()
                .Property(e => e.MaterialNumber)
                .IsUnicode(false);


            modelBuilder.Entity<ExVehicleMaterial>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicleMaterial>()
                .Property(e => e.SubGroupId)
                .IsUnicode(false);



            modelBuilder.Entity<ExVehicle>().ToTable("ExTb_Vehicle");

            modelBuilder.Entity<ExVehicle>()
                 .Property(e => e.BBNumber)
                 .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.TypeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.ModelId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.CountryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.KwInfo)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.SeatsConditioningPicture)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.BackRowSeatPicture)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerSitting)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerLateral)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerBellows)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerBrush)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerOutBack)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerHead)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PassengerWick)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.PortableHeadPortableFixedFabric)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.CurtainFirstFabric)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.CurtainSecondFabric)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.DriverSleepingQuarter)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.DriverSitting)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.DriverLateral)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.DriverFace)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.DriverOutBack)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.DriverHead)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.HostessHead)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .Property(e => e.NetFabricCode)
                .IsUnicode(false);

            modelBuilder.Entity<ExVehicle>()
                .HasMany(e => e.ExVehicleMaterial)
                .WithRequired(e => e.ExVehicle)
                .HasForeignKey(e => e.VehicleBBNumber)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ExMaterialWarehouse>().ToTable("ExTb_MaterialWarehouse");

            modelBuilder.Entity<ExMaterialWarehouse>()
                .Property(e => e.MaterialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ExMaterialWarehouse>()
               .Property(e => e.UndottedMaterialNumber)
               .IsUnicode(false);

            modelBuilder.Entity<ExMaterialWarehouse>()
               .Property(e => e.WarehouseNumber)
               .IsUnicode(false);

            modelBuilder.Entity<ExMaterialWarehouse>()
                .HasMany(e => e.ExVehicleMaterial)
                .WithRequired(e => e.ExMaterialWarehouse)
                .HasForeignKey(e => e.MaterialNumber)
                .WillCascadeOnDelete(true);


        }
    }
}

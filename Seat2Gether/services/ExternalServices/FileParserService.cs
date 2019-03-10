using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
    public class FileParserService
    {

        private DataConverter dataConverter;
        private VehicleService vehicleService;
        private StationService stationService;
        private MaterialService materialService;
        private MaterialWarehouseService materialWarehouseService;
        public FileParserService()
        {
            stationService = new StationService();
            dataConverter = new DataConverter();
            vehicleService = new VehicleService();
            materialService = new MaterialService();
            materialWarehouseService = new MaterialWarehouseService();
        }
        public List<ExMaterialGroupByVehicleDto> FileParseAndSave(byte[] data, string user)
        {
            var list = dataConverter.Parse(data);
            var bbNumbers = list.GroupBy(k => k.VehicleBBNumber).Select(k => k.Key).ToList();
            var createdVehicles = vehicleService.GetList().Where(l => bbNumbers.Contains(l.BBNumber)).ToList();
            var unCreatedVehicles = bbNumbers.Where(k => !createdVehicles.Select(t => t.BBNumber)
            .Contains(k)).Select(s => new ExVehicle { InsertUser = user, UpdateUser = user, BBNumber = s, InsertDate = DateTime.Now, UpdateDate = DateTime.Now });
            vehicleService.AddRange(unCreatedVehicles);

            var stationNumbers = list.GroupBy(k => k.StationNumber).Select(k => k.Key).ToList();
            var createdStations = stationService.GetList().Where(s => stationNumbers
            .Contains(s.StationNumber)).ToList();
            var unCreatedStations = stationNumbers.Where(s => !createdStations.Select(k => k.StationNumber)
            .Contains(s)).Select(s => new ExStation { StationNumber = s });
            stationService.AddRange(unCreatedStations);


            var materialNumbers = list.GroupBy(k => k.MaterialNumber).Select(k => k.Key).ToList();

            var unCreatedMaterialWarehouse = materialNumbers.Select(s => new ExMaterialWarehouse
            {
                MaterialNumber = s,
                UndottedMaterialNumber = s.Replace(".", "")
            }).ToList();
            materialWarehouseService.AddRange(unCreatedMaterialWarehouse);

            var unCreatedMaterials = list.Where(k => !createdVehicles.Select(l => l.BBNumber)
         .Contains(k.VehicleBBNumber)).ToList().CreateMappedList<ExMaterialDto, ExVehicleMaterial>();
            materialService.AddRange(unCreatedMaterials);

            var showUserMaterials = list.GroupBy(k => k.VehicleBBNumber).Select(p => new ExMaterialGroupByVehicleDto
            {
                BBNumber = p.Key,
                Created = !createdVehicles.Select(l => l.BBNumber).Contains(p.Key),
                Materials = p.ToList()
            }).ToList();


            return showUserMaterials;
        }
        public List<ExMaterialGroupByVehicleDto> FileParseAndSaveForBBNumber(string bbNumber, byte[] data)
        {

            var list = dataConverter.Parse(data).Where(k => k.VehicleBBNumber == bbNumber).ToList();
            var stationNumbers = list.GroupBy(k => k.StationNumber).Select(k => k.Key).ToList();
            var createdStations = stationService.GetList().Where(s => stationNumbers
            .Contains(s.StationNumber)).ToList();
            var unCreatedStations = stationNumbers.Where(s => !createdStations.Select(k => k.StationNumber)
            .Contains(s)).Select(s => new ExStation { StationNumber = s });
            stationService.AddRange(unCreatedStations);

            var materialNumbers = list.GroupBy(k => k.MaterialNumber).Select(k => k.Key).ToList();
            var unCreatedMaterialWarehouse = materialNumbers.Select(s => new ExMaterialWarehouse
            {
                MaterialNumber = s,
                UndottedMaterialNumber = s.Replace(".", "")
            }).ToList();
            materialWarehouseService.AddRange(unCreatedMaterialWarehouse);
            var deletedMaterials = materialService.GetList().Where(k => k.VehicleBBNumber == bbNumber).ToList();
            foreach (var item in deletedMaterials)
            {
                materialService.Delete(item);
            }
            var newMaterials = list.CreateMappedList<ExMaterialDto, ExVehicleMaterial>();
            materialService.AddRange(newMaterials);
            var result = list.GroupBy(k => k.VehicleBBNumber).Select(p => new ExMaterialGroupByVehicleDto
            {
                BBNumber = p.Key,
                Created = true,
                Materials = p.ToList()
            }).ToList();
            return result;
        }
    }
}
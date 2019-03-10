using Seat2Gether.dto;
using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Repositories;
using Seat2Gether.Repositories.ExternalRepositories;
using Seat2Gether.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
    public class MaterialService
    {
        private MaterialRepository Repository = null;
        private MaterialWarehouseService MaterialWarehouseService = null;
        private StationService StationService = null;
        private DataConverter dataConverter;
        public MaterialService()
        {
            Repository = new MaterialRepository();
            MaterialWarehouseService = new MaterialWarehouseService();
            StationService = new StationService();
            dataConverter = new DataConverter();
        }

        public IQueryable<ExVehicleMaterial> GetList()
        {
            return Repository.GetList();
        }

        public ExVehicleMaterial Find(object[] Id)
        {
            return Repository.Find(Id);
        }
        public void Add(ExMaterialDto entity)
        {

            if (!StationService.Exist(entity.StationNumber))
            {
                StationService.Add(new ExStationDto { StationNumber = entity.StationNumber });
            }

            var material = Repository.Get(t => t.VehicleBBNumber == entity.VehicleBBNumber && t.MaterialNumber == entity.MaterialNumber);
            if (material != null)
            {
                throw new Exception("This material already exists");
            }

            var wareHouse = MaterialWarehouseService.Find(entity.MaterialNumber);

            if (wareHouse == null)
            {
                MaterialWarehouseService.Add(new ExMaterialWarehouseDto
                {
                    MaterialNumber = entity.MaterialNumber,
                    UndottedMaterialNumber = entity.MaterialNumber?.Replace(".", "")
                });
            }
            var mappedEntity = entity.CreateMapped<ExMaterialDto, ExVehicleMaterial>();
            Repository.Add(mappedEntity);
        }
        public void AddRange(IEnumerable<ExVehicleMaterial> entity)
        {
            Repository.AddRange(entity);
        }
        public void SaveMaterials(ExMaterialGroupByVehicleDto data)
        {
            var deleteMaterials = Repository.GetList().Where(k => k.VehicleBBNumber == data.BBNumber).ToList();
            foreach (var item in deleteMaterials)
            {
                Repository.Delete(item);
            }
            var addMaterials = data.Materials.CreateMappedList<ExMaterialDto, ExVehicleMaterial>();
            Repository.AddRange(addMaterials);
        }
        public void Update(ExMaterialDto entity)
        {
            var material = entity.CreateMapped<ExMaterialDto, ExVehicleMaterial>();
            Repository.Update(material);
        }

        public IQueryable<ExMaterialDto> MaterialList(string bbNumber)
        {
            var materialList = Repository.GetList().Where(k => k.VehicleBBNumber == bbNumber)
               .Include(W => W.ExMaterialWarehouse)
               .Select(m => new ExMaterialDto
               {
                   SubGroupId = m.SubGroupId,
                   MaterialNumber = m.MaterialNumber,
                   Id = m.Id,
                   MaterialName = m.MaterialName,
                   Quantity = m.Quantity,
                   StationNumber = m.StationNumber,
                   Unit = m.Unit,
                   VehicleBBNumber = m.VehicleBBNumber,
                   WarehouseNumber = m.ExMaterialWarehouse.WarehouseNumber
               }).AsQueryable();
            return materialList;
        }
        public IQueryable<ExStationMaterialDto> MaterialListGroupByStation(string bbNumber)
        {
            var materialList = Repository.GetList().Where(k => k.VehicleBBNumber == bbNumber)
                .Include(K => K.ExStation)
                .Include(W => W.ExMaterialWarehouse)
                .GroupBy(l => new { l.StationNumber, l.ExStation }).Select(l => new ExStationMaterialDto
                {
                    StationNumber = l.Key.ExStation.StationNumber,
                    MaterialList = l.Select(m => new ExMaterialDto
                    {
                        SubGroupId = m.SubGroupId,
                        MaterialNumber = m.MaterialNumber,
                        Id = m.Id,
                        MaterialName = m.MaterialName,
                        Quantity = m.Quantity,
                        StationNumber = m.StationNumber,
                        Unit = m.Unit,
                        VehicleBBNumber = m.VehicleBBNumber,
                        WarehouseNumber = m.ExMaterialWarehouse.WarehouseNumber
                    }).ToList(),

                    StationName = l.Key.ExStation.StationName
                }).OrderByDescending(k => k.StationName);

            

            return materialList;
        }
        public void Delete(ExVehicleMaterial entity)
        {
            Repository.Delete(entity);
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
        public void DeleteByBbNumber(string bbNumber)
        {
            var materials = Repository.GetList().Where(k => k.VehicleBBNumber == bbNumber).ToList();
            foreach (var item in materials)
            {
                Repository.Delete(item);
            }

        }
    }
}
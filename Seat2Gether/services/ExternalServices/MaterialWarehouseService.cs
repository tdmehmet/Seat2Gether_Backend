using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Repositories.ExternalRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
    public class MaterialWarehouseService
    {
        private MaterialWarehouseRepository Repository = null;

        public MaterialWarehouseService()
        {
            Repository = new MaterialWarehouseRepository();
        }
        public List<ExMaterialWarehouseDto> GetList()
        {
            return Repository.GetList().ToList().CreateMappedList<ExMaterialWarehouse, ExMaterialWarehouseDto>();
        }
        public List<ExMaterialWarehouseDto> GetNamedList()
        {
            return Repository.GetList().Where(k=> !string.IsNullOrEmpty(k.WarehouseNumber)).ToList().CreateMappedList<ExMaterialWarehouse, ExMaterialWarehouseDto>();
        }
        public ExMaterialWarehouse Find(object Id)
        {
            return Repository.Find(Id);
        }
        public void Add(ExMaterialWarehouseDto entity)
        {
            var materialWarehouse = entity.CreateMapped<ExMaterialWarehouseDto, ExMaterialWarehouse>();
            Repository.Add(materialWarehouse);
        }
        public void AddRange(IEnumerable<ExMaterialWarehouse> entity)
        {
            var stations = entity.Where(k => !Repository.GetList().Select(p => p.MaterialNumber).ToList().Contains(k.MaterialNumber));
            Repository.AddRange(stations);
        }
        public void Update(ExMaterialWarehouseDto entity)
        {
            var warehouse = entity.CreateMapped<ExMaterialWarehouseDto, ExMaterialWarehouse>();
            Repository.Update(warehouse);
        }

        public void Delete(ExMaterialWarehouseDto entity)
        {
            var warehouse = entity.CreateMapped<ExMaterialWarehouseDto, ExMaterialWarehouse>();
            Repository.Delete(warehouse);
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
    }
}